using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using ConcertsDataBase;

namespace WindowsFormsConcertsEF
{
    public partial class FormArtistInfo : Form
    {
        private int id;
        private readonly string name;
        private ConcertsDataBase.ConcertsEntities concerts;

        public FormArtistInfo(int _id, string _name)
        {
            InitializeComponent();

            id = _id;
            name = _name;

            concerts = new ConcertsDataBase.ConcertsEntities();
            Text = String.Concat(Text, " ", name);
            findArtistInfo();
        }

        void findArtistInfo()
        {
            var chE = concerts.ChangeTracker.Entries<Artists>().Where(a => a.State != EntityState.Unchanged).ToList();
            if (chE.Count != 0)
            {
                MessageBox.Show("Необхідно зберегти зміни");
            }
            else
            {
                concerts.Dispose();
                concerts = new ConcertsDataBase.ConcertsEntities();

                var query = (from c1 in concerts.Artists
                             join c2 in concerts.Concerts on c1.Artist_ID equals c2.Concert_Artist_ID
                             where c1.Artist_ID == id
                             select c2);

                query.Load();

                concertsBindingSource.DataSource = concerts.Concerts.Local.ToBindingList();
            }
        }

        public FormArtistInfo()
        {
            InitializeComponent();
        }

        private void dataGridViewArtists_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

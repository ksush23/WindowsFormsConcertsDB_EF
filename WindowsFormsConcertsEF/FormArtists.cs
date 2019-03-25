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
    public partial class FormArtists : Form
    {
        private ConcertsDataBase.ConcertsEntities1 concerts;

        private void findArtist()
        {
            /*var chE = concerts.ChangeTracker.Entries<Artists>().Where(a => a.State != EntityState.Unchanged).ToList();
            if (chE.Count != 0)
            {
                MessageBox.Show("Необхідно зберегти зміни");
            }
            else*/
            {
                concerts = new ConcertsDataBase.ConcertsEntities1();

                var query = (from c in concerts.Artists
                             where c.Artist_Genre.Contains(comboBoxGenre.Text)
                             select c);

                query.Load();

                artistsBindingSource.DataSource = concerts.Artists.Local.ToBindingList();
            }
        }
        public FormArtists()
        {
            InitializeComponent();
            findArtist();
        }

        private void FormArtists_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxGenre_SelectedValueChanged(object sender, EventArgs e)
        {
            findArtist();
        }
    }
}

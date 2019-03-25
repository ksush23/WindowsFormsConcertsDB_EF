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
    public partial class FormTickets : Form
    {
        private ConcertsDataBase.ConcertsEntities1 concerts;

        public FormTickets()
        {
            InitializeComponent();
        }

        private void findTickets()
        {
            /*var chE = concerts.ChangeTracker.Entries<Artists>().Where(a => a.State != EntityState.Unchanged).ToList();
            if (chE.Count != 0)
            {
                MessageBox.Show("Необхідно зберегти зміни");
            }
            else*/
            {
                concerts = new ConcertsDataBase.ConcertsEntities1();

                var query = (from c1 in concerts.Artists
                             join c2 in concerts.Concerts on c1.Artist_ID equals c2.Concert_Artist_ID
                             join c3 in concerts.Tickets on c2.Concert_ID equals c3.Ticket_Concert_ID
                             join c4 in concerts.Places on c2.Concert_Place_ID equals c4.Place_ID
                             select c3);

                if (!String.IsNullOrWhiteSpace(textBoxArtist.Text))
                    query = query.Where(c => c.Concerts.Artists.Artist_Name.Contains(textBoxArtist.Text));

                if (!String.IsNullOrWhiteSpace(textBoxPlace.Text))
                    query = query.Where(c => c.Concerts.Places.Place_Name.Contains(textBoxPlace.Text));

                if (!String.IsNullOrWhiteSpace(comboBoxState.Text))
                    query = query.Where(c => c.Ticket_States.Name.Contains(comboBoxState.Text));

                query.Load();

                ticketsBindingSource.DataSource = concerts.Tickets.Local.ToBindingList();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            findTickets();
        }
    }
}

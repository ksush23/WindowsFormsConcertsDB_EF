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
    public partial class ConcertsForm : Form
    {
        private ConcertsDataBase.ConcertsEntities1 ctx;
        public ConcertsForm()
        {
            InitializeComponent();
            ctx = new ConcertsDataBase.ConcertsEntities1();

            ctx.Artists.Load();
            this.artistsBindingSource.DataSource = ctx.Artists.Local.ToBindingList();

            ctx.Concerts.Load();
            this.concertsBindingSource.DataSource = ctx.Concerts.Local.ToBindingList();

            ctx.Places.Load();
            this.placesBindingSource.DataSource = ctx.Places.Local.ToBindingList();

            ctx.Seats.Load();
            this.seatsBindingSource.DataSource = ctx.Seats.Local.ToBindingList();

            ctx.Sectors.Load();
            this.sectorsBindingSource.DataSource = ctx.Sectors.Local.ToBindingList();

            ctx.Tickets.Load();
            this.ticketsBindingSource.DataSource = ctx.Tickets.Local.ToBindingList();

            ctx.Ticket_States.Load();
            this.ticketStatesBindingSource.DataSource = ctx.Ticket_States.Local.ToBindingList();
        }

        private void dataGridViewSeats_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonSaveArtists_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();

        }

        private void buttonDeleteArtists_Click(object sender, EventArgs e)
        {
            try
            {
                Artists art = (Artists)dataGridViewArtists.CurrentRow.DataBoundItem;
                var b = (from c in ctx.Concerts where (c.Concert_Artist_ID == art.Artist_ID) select c).Any();
                if (b)
                {
                    MessageBox.Show("Видалення неможливе\n До виконавця прив'язані елементи");
                }
                else
                {
                    artistsBindingSource.RemoveCurrent();
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Помилка видалення виконавця");
                throw;
            }
        }

        private void buttonSaveConcerts_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void buttonDeleteConcerts_Click(object sender, EventArgs e)
        {
            try
            {
                Concerts con = (Concerts)dataGridViewConcerts.CurrentRow.DataBoundItem;
                var b = (from c in ctx.Tickets where (c.Ticket_Concert_ID == con.Concert_ID) select c).Any();
                if (b)
                {
                    MessageBox.Show("Видалення неможливе\n До концерту прив'язані елементи");
                }
                else
                {
                    concertsBindingSource.RemoveCurrent();
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Помилка видалення концерту");
                throw;
            }
        }

        private void buttonSaveTickets_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void buttonDeleteTickets_Click(object sender, EventArgs e)
        {
            ticketsBindingSource.RemoveCurrent();
            ctx.SaveChanges();
        }

        private void buttonSavePlaces_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void buttonDeletePlaces_Click(object sender, EventArgs e)
        {
            try
            {
                Places place = (Places)dataGridViewPlaces.CurrentRow.DataBoundItem;
                var b = (from c in ctx.Sectors where (c.Sector_Place_ID == place.Place_ID) select c).Any();
                var m = (from d in ctx.Concerts where (d.Concert_Place_ID == place.Place_ID) select d).Any();
                if (b || m)
                {
                    MessageBox.Show("Видалення неможливе\n До місця проведення прив'язані елементи");
                }
                else
                {
                    placesBindingSource.RemoveCurrent();
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Помилка видалення місця проведення");
                throw;
            }
        }

        private void buttonSaveSectors_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void buttonDeleteSectors_Click(object sender, EventArgs e)
        {
            try
            {
                Sectors sec = (Sectors)dataGridViewSectors.CurrentRow.DataBoundItem;
                var b = (from c in ctx.Seats where (c.Seat_Sector_ID == sec.Sector_ID) select c).Any();
                if (b)
                {
                    MessageBox.Show("Видалення неможливе\n До сектора прив'язані елементи");
                }
                else
                {
                    sectorsBindingSource.RemoveCurrent();
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Помилка видалення сектора");
                throw;
            }
        }

        private void buttonSaveSeats_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void buttonDeleteSeats_Click(object sender, EventArgs e)
        {
            try
            {
                Seats seat = (Seats)dataGridViewSeats.CurrentRow.DataBoundItem;
                var b = (from c in ctx.Tickets where (c.Ticket_Seat_ID == seat.Seat_ID) select c).Any();
                if (b)
                {
                    MessageBox.Show("Видалення неможливе\n До місця прив'язані елементи");
                }
                else
                {
                    seatsBindingSource.RemoveCurrent();
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Помилка видалення місця");
                throw;
            }
        }

        private void dataGridViewArtists_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var chE = ctx.ChangeTracker.Entries<Artists>().Where(a => a.State != EntityState.Unchanged).ToList();
            if (chE.Count != 0)
            {
                MessageBox.Show("Необхідно зберегти зміни");
            }
            else
            {
                try
                {
                    Artists art = (Artists)dataGridViewArtists.CurrentRow.DataBoundItem;
                    FormArtistInfo formSearch = new FormArtistInfo(art.Artist_ID, art.Artist_Name);
                    formSearch.ShowDialog(this);
                    formSearch.Dispose();
                }
                catch
                {
                    MessageBox.Show("Помилка переходу");
                }
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            FormArtists form = new FormArtists();
            form.ShowDialog(this);
            form.Dispose();
        }

        private void buttonSearchTickets_Click(object sender, EventArgs e)
        {
            FormTickets form = new FormTickets();
            form.ShowDialog(this);
            form.Dispose();
        }

        private void tabArtists_Click(object sender, EventArgs e)
        {

        }
    }
}

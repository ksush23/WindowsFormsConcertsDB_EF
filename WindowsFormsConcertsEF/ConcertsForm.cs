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
        public ConcertsForm()
        {
            InitializeComponent();

            var ctx = new ConcertsDataBase.ConcertsEntities();
        }

        private void dataGridViewSeats_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

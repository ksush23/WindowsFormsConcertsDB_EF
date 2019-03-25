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
    public partial class FormSignUp : Form
    {
        private ConcertsDataBase.ConcertsEntities1 concertsEntities;
        public FormSignUp()
        {
            InitializeComponent();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            concertsEntities = new ConcertsDataBase.ConcertsEntities1();
            ConcertsDataBase.Authorization authorization = new ConcertsDataBase.Authorization();
            authorization.Login = textBoxLogin.Text;
            authorization.Password = textBoxPassword.Text;
            concertsEntities.Authorization.Add(authorization);
            concertsEntities.SaveChanges();
        }
    }
}

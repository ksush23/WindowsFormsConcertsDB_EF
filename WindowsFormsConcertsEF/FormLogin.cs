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
    public partial class FormLogin : Form
    {
        private ConcertsDataBase.ConcertsEntities1 concertsEntities;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            concertsEntities = new ConcertsDataBase.ConcertsEntities1();

            var query = (from c in concertsEntities.Authorization
                         where c.Login == textBoxLogin.Text && c.Password == textBoxPassword.Text
                         select c).Count();
            if (query == 0)
                MessageBox.Show("Неправильний логін і пароль!");
            else
            {
                ConcertsForm form = new ConcertsForm();
                form.ShowDialog(this);
                form.Dispose();
            }
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            FormSignUp form = new FormSignUp();
            form.ShowDialog(this);
            form.Dispose();
        }
    }
}

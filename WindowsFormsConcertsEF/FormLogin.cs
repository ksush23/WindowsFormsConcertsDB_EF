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
using DSLogin;

namespace WindowsFormsConcertsEF
{
    public partial class FormLogin : Form
    {
        private DSLogin.LoginEntities entities;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            entities = new DSLogin.LoginEntities();

            var query = (from c in entities.Login
                         where c.Логін.Contains(textBoxLogin.Text) && c.Пароль.Contains(textBoxPassword.Text)
                         select c);
            if (query.Count() == 0)
                MessageBox.Show("Неправильний логін і пароль!");
            else
            {
                ConcertsForm form = new ConcertsForm();
                form.ShowDialog(this);
                form.Dispose();
            }
        }
    }
}

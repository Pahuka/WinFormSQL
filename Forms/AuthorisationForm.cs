using System;
using System.Linq;
using System.Windows.Forms;
using WinFormSQL.Data;

namespace WinFormSQL
{
    public partial class AuthorisationForm : Form
    {       
        public AuthorisationForm()
        {
            InitializeComponent();
        }

        private void Authorisation_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (var cont = new DataBaseContext())
            {
                var user = cont.Users.Where(x => x.Login == textBox1.Text && x.Password == textBox2.Text).FirstOrDefault();
                if (user != null)
                {
                    new MainForm(user).Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Пользователь не найден", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

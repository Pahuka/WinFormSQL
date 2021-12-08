using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using DBase;
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
            //DataBase.OpenConnection();
            //SqlCommand command = new SqlCommand($"SELECT * FROM Users WHERE Login = N'{textBox1.Text}' AND Password = N'{textBox2.Text}'",
            //  DataBase.GetConnection());
            //SqlDataReader ds = command.ExecuteReader();

            //if (ds.HasRows)
            //{
            //    new MainForm(ds).Show();
            //    this.Hide();
            //}
            //else
            //    MessageBox.Show("Пользователь не найден", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //DataBase.CloseConnection();

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

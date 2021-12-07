using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBase;

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
            DataBase.OpenConnection();
            SqlCommand command = new SqlCommand($"SELECT * FROM Users WHERE Login = N'{textBox1.Text}' AND Password = N'{textBox2.Text}'", DataBase.GetConnection());
            SqlDataReader ds = command.ExecuteReader();
            
            if (ds.HasRows)
            {
                new MainForm(ds).Show();
                this.Hide();
            }
            else
                MessageBox.Show("Пользователь не найден", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            DataBase.CloseConnection();
        }
    }
}

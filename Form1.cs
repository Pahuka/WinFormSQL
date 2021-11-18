using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormSQL
{
    public partial class Form1 : Form
    {
        static Data data = new Data();        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private async void UpdateData()
        {
            textBox1.Clear();
            data.OpenConnection();
            SqlCommand command = new SqlCommand("SELECT * FROM [Users]", data.GetConnection());
            SqlDataReader reader = await command.ExecuteReaderAsync();
            while (reader.Read())
            {
                textBox1.Text += $"{Convert.ToString(reader["Id"])}, {Convert.ToString(reader["UserName"])}, {Convert.ToString(reader["Date"])}\r\n";
            }
            reader.Close();
            data.CloseConnection();
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            data.OpenConnection();
            SqlCommand command = new SqlCommand($"INSERT INTO [Users] (UserName) VALUES (N'{textBox2.Text}')", data.GetConnection());
            command.ExecuteNonQuery();
            data.CloseConnection();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void removeUserButton_Click(object sender, EventArgs e)
        {
            data.OpenConnection();
            SqlCommand command = new SqlCommand($"DELETE FROM [Users] WHERE UserName = '{textBox3.Text}'", data.GetConnection());
            command.ExecuteNonQuery();
            data.CloseConnection();
        }
    }
}

using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormSQL
{
    public partial class Form1 : Form
    {
        static Data data = new Data();
        static DataSet dataSet;
        static SqlCommand command;
        static SqlDataAdapter adapter;

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

        private void UpdateData()
        {
            data.OpenConnection();
            dataSet = new DataSet();
            adapter = new SqlDataAdapter("SELECT * FROM [Users]", data.GetConnection());
            adapter.Fill(dataSet, "Users");
            dataGridView1.DataSource = dataSet.Tables["Users"];
            data.CloseConnection();
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            data.OpenConnection();
            command = new SqlCommand($"INSERT INTO [Users] (UserName) VALUES (N'{textBox2.Text}')", data.GetConnection());
            command.ExecuteNonQuery();
            data.CloseConnection();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
        }

        private void removeUserButton_Click(object sender, EventArgs e)
        {
            data.OpenConnection();
            command = new SqlCommand($"DELETE FROM [Users] WHERE UserName = '{textBox3.Text}'", data.GetConnection());
            command.ExecuteNonQuery();
            data.CloseConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            data.OpenConnection();
            dataSet = new DataSet();
            adapter = new SqlDataAdapter($"SELECT * FROM [Users] WHERE UserName = '{textBox1.Text}'", data.GetConnection());
            adapter.Fill(dataSet, "Users");
            dataGridView1.DataSource = dataSet.Tables["Users"];
            data.CloseConnection();
        }
    }
}

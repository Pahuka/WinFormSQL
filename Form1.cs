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
            StartPosition = FormStartPosition.CenterScreen;
            countRows.Text = $"Количество записей - {dataGridView1.Rows.Count.ToString()}";
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
            if (data.GetConnection().State == System.Data.ConnectionState.Closed)
                data.OpenConnection();
            dataSet = new DataSet();
            adapter = new SqlDataAdapter("SELECT * FROM [Users]", data.GetConnection());
            adapter.Fill(dataSet, "Users");
            dataGridView1.DataSource = dataSet.Tables["Users"];
            countRows.Text = $"Количество записей - {dataGridView1.Rows.Count.ToString()}";
            data.CloseConnection();
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0)
                MessageBox.Show("Введите имя пользователя", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                data.OpenConnection();
                command = new SqlCommand($"INSERT INTO [Users] (Id, [User Name]) VALUES ('{Guid.NewGuid()}', N'{textBox2.Text}')", data.GetConnection());
                command.ExecuteNonQuery();
                UpdateData();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            countRows.Text = "Количество записей - 0";
        }

        private void removeUserButton_Click(object sender, EventArgs e)
        {
            data.OpenConnection();
            command = new SqlCommand($"DELETE FROM [Users] WHERE [User Name] = N'{textBox3.Text}'", data.GetConnection());
            command.ExecuteNonQuery();
            UpdateData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            data.OpenConnection();
            dataSet = new DataSet();
            adapter = new SqlDataAdapter($"SELECT * FROM [Users] WHERE [User Name] = N'{textBox1.Text}'", data.GetConnection());
            adapter.Fill(dataSet, "Users");
            dataGridView1.DataSource = dataSet.Tables["Users"];
            countRows.Text = $"Количество записей - {dataGridView1.Rows.Count.ToString()}";
            data.CloseConnection();
        }
    }
}

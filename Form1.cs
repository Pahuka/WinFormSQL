using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormSQL
{
    public partial class Form1 : Form
    {
        //static Data data = new Data();
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
            if (Data.GetConnection().State == System.Data.ConnectionState.Closed)
                Data.OpenConnection();
            dataSet = new DataSet();
            adapter = new SqlDataAdapter("SELECT * FROM [Users]", Data.GetConnection());
            adapter.Fill(dataSet, "Users");
            dataGridView1.DataSource = dataSet.Tables["Users"];
            countRows.Text = $"Количество записей - {dataGridView1.Rows.Count.ToString()}";
            Data.CloseConnection();
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0)
                MessageBox.Show("Введите имя пользователя", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                Data.OpenConnection();
                command = new SqlCommand($"INSERT INTO [Users] (Id, [User Name]) VALUES ('{Guid.NewGuid()}', N'{textBox2.Text}')", Data.GetConnection());
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
            Data.OpenConnection();
            command = new SqlCommand($"DELETE FROM [Users] WHERE [User Name] = N'{textBox3.Text}'", Data.GetConnection());
            command.ExecuteNonQuery();
            UpdateData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data.OpenConnection();
            dataSet = new DataSet();
            adapter = new SqlDataAdapter($"SELECT * FROM [Users] WHERE [User Name] = N'{textBox1.Text}'", Data.GetConnection());
            adapter.Fill(dataSet, "Users");
            dataGridView1.DataSource = dataSet.Tables["Users"];
            countRows.Text = $"Количество записей - {dataGridView1.Rows.Count.ToString()}";
            Data.CloseConnection();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var form2 = new Form2();
            form2.SqlCommand = $"SELECT * FROM [Users] WHERE [{dataGridView1.Columns[e.ColumnIndex].Name}] = N'{dataGridView1[e.ColumnIndex, e.RowIndex].Value}'";
            form2.ShowDialog(this);
        }
    }
}

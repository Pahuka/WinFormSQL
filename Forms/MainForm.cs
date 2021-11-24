using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DataBase;

namespace WinFormSQL
{
    public partial class MainForm : Form
    {
        static DataSet dataSet;
        static SqlCommand command;
        static SqlDataAdapter adapter;
        public User user;

        public MainForm(SqlDataReader userData)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            countRows.Text = $"Количество записей - {dataGridView1.Rows.Count.ToString()}";
            user = new User(userData);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (user.Administrator)
                addUserButton.Enabled = true;
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
            adapter = new SqlDataAdapter("SELECT [User name], Post, Sex, Salary, Date FROM [Employees]", Data.GetConnection());
            adapter.Fill(dataSet, "Employees");
            dataGridView1.DataSource = dataSet.Tables["Employees"];
            countRows.Text = $"Количество записей - {dataGridView1.Rows.Count.ToString()}";
            Data.CloseConnection();
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            new AddUserForm().ShowDialog(this);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            countRows.Text = "Количество записей - 0";
        }

        private void removeUserButton_Click(object sender, EventArgs e)
        {
            Data.OpenConnection();
            command = new SqlCommand($"DELETE FROM [Employees] WHERE [User Name] = N'{textBox3.Text}'", Data.GetConnection());
            command.ExecuteNonQuery();
            UpdateData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data.OpenConnection();
            dataSet = new DataSet();
            adapter = new SqlDataAdapter($"SELECT * FROM [Employees] WHERE [User Name] = N'{textBox1.Text}'", Data.GetConnection());
            adapter.Fill(dataSet, "Employees");
            dataGridView1.DataSource = dataSet.Tables["Employees"];
            countRows.Text = $"Количество записей - {dataGridView1.Rows.Count.ToString()}";
            Data.CloseConnection();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            var form2 = new Form2();
            if (dataGridView1[e.ColumnIndex, e.RowIndex].ValueType == typeof(DateTime))
            {
                var selectedCell = (DateTime)dataGridView1[e.ColumnIndex, e.RowIndex].Value;
                form2.SqlCommand = 
                    $"SELECT * FROM [Employees] WHERE [{dataGridView1.Columns[e.ColumnIndex].Name}] = N'{selectedCell.ToString("yyyy-MM-dd HH:mm:ss.fff")}'";
            }
            else
                form2.SqlCommand =
                    $"SELECT * FROM [Employees] WHERE [{dataGridView1.Columns[e.ColumnIndex].Name}] = N'{dataGridView1[e.ColumnIndex, e.RowIndex].Value}'";
            form2.ShowDialog(this);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

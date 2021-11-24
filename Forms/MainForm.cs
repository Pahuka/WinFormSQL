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
        public User CurrentUser { get; set; }

        public MainForm(SqlDataReader userData)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            countRows.Text = $"Количество записей - {dataGridView1.Rows.Count.ToString()}";
            CurrentUser = new User(userData);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (CurrentUser.Administrator)
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
            adapter = new SqlDataAdapter("SELECT Id, Title, Requisites, Author, [Creation Date] FROM [Incidents]", Data.GetConnection());
            adapter.Fill(dataSet, "Incidents");
            dataGridView1.DataSource = dataSet.Tables["Incidents"];
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
            command = new SqlCommand($"DELETE FROM [Incidents] WHERE [Id] = N'{textBox3.Text}'", Data.GetConnection());
            command.ExecuteNonQuery();
            UpdateData();
        }

        private void searchIncident_Click(object sender, EventArgs e)
        {
            //Data.OpenConnection();
            //dataSet = new DataSet();
            //adapter = new SqlDataAdapter($"SELECT * FROM [Incidents] WHERE [User Name] = N'{textBox1.Text}'", Data.GetConnection());
            //adapter.Fill(dataSet, "Incidents");
            //dataGridView1.DataSource = dataSet.Tables["Incidents"];
            //countRows.Text = $"Количество записей - {dataGridView1.Rows.Count.ToString()}";
            //Data.CloseConnection();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            var form2 = new Form2();
            //if (dataGridView1[e.ColumnIndex, e.RowIndex].ValueType == typeof(DateTime))
            //{
            //    var selectedCell = (DateTime)dataGridView1[e.ColumnIndex, e.RowIndex].Value;
            //    form2.SqlCommand = 
            //        $"SELECT * FROM [Incidents] WHERE [{dataGridView1.Columns[e.ColumnIndex].Name}] = N'{selectedCell.ToString("yyyy-MM-dd HH:mm:ss.fff")}'";
            //}
            //else
            form2.SqlCommand =
                    $"SELECT * FROM [Incidents] WHERE [{dataGridView1.Columns[0].Name}] = N'{dataGridView1[0, e.RowIndex].Value}'";
            form2.ShowDialog(this);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void createIncident_Click(object sender, EventArgs e)
        {
            new IncidentForm(CurrentUser).ShowDialog(this);
        }
    }
}

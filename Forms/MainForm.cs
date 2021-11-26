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
            {
                addUserButton.Enabled = true;
                removeUserButton.Enabled = true;
            }
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
            adapter = new SqlDataAdapter("SELECT Incidents.Id, Incidents.Title, Incidents.Requisites, Incidents.[Creation Date], " +
                "CONCAT(Users.[First Name], ' ', Users.[Last Name]) AS Author " +
                "FROM [Incidents], Users WHERE Users.Id = Incidents.Author", Data.GetConnection());
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
            command = new SqlCommand($"DELETE FROM [Users] WHERE Login = N'{textBox3.Text}'", Data.GetConnection());
            if (command.ExecuteNonQuery() > 0)
                MessageBox.Show("Пользователь успешно удален", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Такой пользователь не найден", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Data.CloseConnection();
        }

        private void searchIncident_Click(object sender, EventArgs e)
        {
            Data.OpenConnection();
            dataSet = new DataSet();
            adapter = new SqlDataAdapter($"SELECT * FROM [Incidents] WHERE Id = N'{textBox1.Text}'", Data.GetConnection());
            adapter.Fill(dataSet, "Incidents");
            dataGridView1.DataSource = dataSet.Tables["Incidents"];
            countRows.Text = $"Количество записей - {dataGridView1.Rows.Count.ToString()}";
            Data.CloseConnection();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            var form2 = new Form2();
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

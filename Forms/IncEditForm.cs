using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using DataBase;

namespace WinFormSQL
{
    public partial class IncEditForm : Form
    {
        private int IncidentId { get; set; }
        public string SqlCommand { get; set; }
        public IncEditForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Data.OpenConnection();
            SqlDataReader dataReader = new SqlCommand(SqlCommand, Data.GetConnection()).ExecuteReader();
            while (dataReader.Read())
            {
                titleBox.Text = (string)dataReader.GetValue(1);
                reqBox.Text = (string)dataReader.GetValue(2);
                IncidentId = (int)dataReader.GetValue(0);
            }
            Data.CloseConnection();
            Data.OpenConnection();
            var historyReader = new SqlCommand($"SELECT [Editing Date], Content, CONCAT(Users.[First Name], ' ', Users.[Last Name]) AS Author " +
                    $"FROM History, Users WHERE [Incident Id] = N'{IncidentId}' AND History.[User Id] = Users.Id " +
                    $"ORDER BY [Editing Date]", Data.GetConnection()).ExecuteReader();
            while (historyReader.Read())
            {
                contentBox.Text += $"{historyReader.GetValue(0)} \t{historyReader.GetValue(2)} \r\n{historyReader.GetValue(1)}\r\n";
            }
            Data.CloseConnection();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Data.OpenConnection();
            new SqlCommand($"INSERT INTO History (Id, [Incident Id], [User Id], Content) " +
                $"VALUES (N'{Guid.NewGuid()}', N'{IncidentId}', N'{MainForm.CurrentUser.Id}', N'{editTextBox.Text}')", Data.GetConnection())
                .ExecuteNonQuery();
            Data.CloseConnection();
            Data.OpenConnection();
            var historyReader = new SqlCommand($"SELECT [Editing Date], Content, CONCAT(Users.[First Name], ' ', Users.[Last Name]) AS Author " +
                    $"FROM History, Users WHERE [Incident Id] = N'{IncidentId}' AND History.[User Id] = Users.Id " +
                    $"ORDER BY [Editing Date]", Data.GetConnection()).ExecuteReader();
            contentBox.Clear();
            while (historyReader.Read())
            {
                contentBox.Text += $"{historyReader.GetValue(0)} \t{historyReader.GetValue(2)} \r\n{historyReader.GetValue(1)}\r\n";
            }
            Data.CloseConnection();
            editTextBox.Clear();
        }
    }
}

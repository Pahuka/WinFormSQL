using DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormSQL
{
    public partial class IncidentForm : Form
    {
        public User CurrentUser { get; set; }
        public IncidentForm(User user)
        {
            InitializeComponent();
            CurrentUser = user;
        }

        private void IncidentForm_Load(object sender, EventArgs e)
        {

        }

        private void createButton_Click(object sender, EventArgs e)
        {
            Data.OpenConnection();
            //var reader = new SqlCommand($"INSERT INTO [Incidents] (Title, Requisites, Author, Content) " +
            //    $"VALUES (N'{titleBox.Text}', N'{reqBox.Text}', N'{CurrentUser.Id}', N'{contentBox.Text}')", Data.GetConnection())
            //    .ExecuteNonQuery();
            var command = new SqlCommand($"INSERT INTO [Incidents] (Title, Requisites, Author, Content) " +
                $"VALUES (N'{titleBox.Text}', N'{reqBox.Text}', N'{CurrentUser.Id}', N'{contentBox.Text}') " +
                $"SELECT SCOPE_IDENTITY()", Data.GetConnection());
            var lastId = command.ExecuteScalar();
            new SqlCommand($"INSERT INTO [History] (Id, [Incident Id], [User Id], Content)" +
                $"VALUES (N'{Guid.NewGuid()}', N'{lastId.ToString()}', N'{MainForm.CurrentUser.Id}', N'{contentBox.Text}')", Data.GetConnection())
                .ExecuteNonQuery();
            Data.CloseConnection();
            this.Close();
        }
    }
}

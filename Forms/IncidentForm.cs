using DBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WinFormSQL.Data;
using WinFormSQL.Data.Tables;

namespace WinFormSQL
{
    public partial class IncidentForm : Form
    {
        //public User CurrentUser { get; set; }
        //public IncidentForm(User user)
        public DbUser CurrentUser { get; set; }
        public IncidentForm(DbUser user)
        {
            InitializeComponent();
            CurrentUser = user;
        }

        private void IncidentForm_Load(object sender, EventArgs e)
        {

        }

        private void createButton_Click(object sender, EventArgs e)
        {
            //DataBase.OpenConnection();
            //var command = new SqlCommand($"INSERT INTO [Incidents] (Title, Requisites, Author, Content) " +
            //    $"VALUES (N'{titleBox.Text}', N'{reqBox.Text}', N'{CurrentUser.Id}', N'{contentBox.Text}') " +
            //    $"SELECT SCOPE_IDENTITY()", DataBase.GetConnection());
            //var lastId = command.ExecuteScalar();
            //new SqlCommand($"INSERT INTO [History] (Id, [Incident Id], [User Id], Content)" +
            //    $"VALUES (N'{Guid.NewGuid()}', N'{lastId.ToString()}', N'{MainForm.CurrentUser.Id}', N'{contentBox.Text}')", DataBase.GetConnection())
            //    .ExecuteNonQuery();
            //DataBase.CloseConnection();

            using (var context = new DataBaseContext())
            {
                context.Incidents.Add(new DbIncident() {
                Author = CurrentUser.Id,
                Requisites = reqBox.Text,
                Title = titleBox.Text,
                Content = contentBox.Text});
                context.SaveChanges();
                var incidentId = context.Incidents.OrderByDescending(x => x.CreationDate).FirstOrDefault().Id;
                context.History.Add(new DbHistory() {
                IncidentNumber = incidentId,
                UserId = CurrentUser.Id,
                Content = contentBox.Text});
                context.SaveChanges();
            }
            this.Close();
        }
    }
}

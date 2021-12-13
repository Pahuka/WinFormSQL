using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WinFormSQL.Data;
using WinFormSQL.Data.Tables;

namespace WinFormSQL
{
    public partial class IncEditForm : Form
    {
        //private int IncidentNumber { get; set; }
        //public string SqlCommand { get; set; }
        public int IncidentId { get; set; }
        public DbUser CurrentUser { get; set; }
        public IncEditForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //DataBase.OpenConnection();
            //SqlDataReader dataReader = new SqlCommand(SqlCommand, DataBase.GetConnection()).ExecuteReader();
            //while (dataReader.Read())
            //{
            //    titleBox.Text = (string)dataReader.GetValue(1);
            //    reqBox.Text = (string)dataReader.GetValue(2);
            //    IncidentNumber = (int)dataReader.GetValue(0);
            //}
            //DataBase.CloseConnection();
            //DataBase.OpenConnection();
            //var historyReader = new SqlCommand($"SELECT [Editing Date], Content, CONCAT(Users.[First Name], ' ', Users.[Last Name]) AS AuthorId " +
            //        $"FROM History, Users WHERE [Incident Id] = N'{IncidentNumber}' AND History.[User Id] = Users.Id " +
            //        $"ORDER BY [Editing Date]", DataBase.GetConnection()).ExecuteReader();
            //while (historyReader.Read())
            //{
            //    contentBox.Text += $"{historyReader.GetValue(0)} \t{historyReader.GetValue(2)} \r\n{historyReader.GetValue(1)}\r\n";
            //}
            //DataBase.CloseConnection();

            UpdateTextInForm();
        }

        private void UpdateTextInForm()
        {
            using (var context = new DataBaseContext())
            {
                var incident = context.Incidents
                    .Where(x => x.Id == IncidentId)
                    .FirstOrDefault();
                titleBox.Text = incident.Title;
                reqBox.Text = incident.Requisites;
                var history = context.History
                    .Where(x => x.IncidentNumber == IncidentId)
                    .OrderBy(x => x.EditingDate);

                foreach (var item in history)
                {
                    var user = context.Users
                        .Where(x => x.Id == item.UserId)
                        .FirstOrDefault();
                    contentBox.Text += $"{user.FirstName} {user.LastName} \t{item.EditingDate} \r\n{item.Content}\r\n";
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //DataBase.OpenConnection();
            //new SqlCommand($"INSERT INTO History (Id, [Incident Id], [User Id], Content) " +
            //    $"VALUES (N'{Guid.NewGuid()}', N'{IncidentNumber}', N'{MainForm.CurrentUser.Id}', N'{editTextBox.Text}')", DataBase.GetConnection())
            //    .ExecuteNonQuery();
            //DataBase.CloseConnection();
            //DataBase.OpenConnection();
            //var historyReader = new SqlCommand($"SELECT [Editing Date], Content, CONCAT(Users.[First Name], ' ', Users.[Last Name]) AS AuthorId " +
            //        $"FROM History, Users WHERE [Incident Id] = N'{IncidentNumber}' AND History.[User Id] = Users.Id " +
            //        $"ORDER BY [Editing Date]", DataBase.GetConnection()).ExecuteReader();
            //contentBox.Clear();
            //while (historyReader.Read())
            //{
            //    contentBox.Text += $"{historyReader.GetValue(0)} \t{historyReader.GetValue(2)} \r\n{historyReader.GetValue(1)}\r\n";
            //}
            //DataBase.CloseConnection();
            //editTextBox.Clear();

            using (var context = new DataBaseContext())
            {
                context.History.Add(new DbHistory() {
                Content = editTextBox.Text,
                IncidentNumber = IncidentId,
                UserId = CurrentUser.Id});
                context.SaveChanges();
            }
            contentBox.Clear();
            editTextBox.Clear();
            UpdateTextInForm();
        }
    }
}

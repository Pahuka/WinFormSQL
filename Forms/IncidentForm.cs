using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WinFormSQL.Data;
using WinFormSQL.Data.Tables;

namespace WinFormSQL
{
    public partial class IncidentForm : Form
    {
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
            using (var context = new DataBaseContext())
            {
                context.Incidents.Add(new DbIncident() {
                AuthorId = CurrentUser.Id,
                Author = $"{CurrentUser.FirstName} {CurrentUser.LastName}",
                Requisites = reqBox.Text,
                Title = titleBox.Text,
                Content = contentBox.Text});;
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

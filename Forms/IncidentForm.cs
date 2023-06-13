using System;
using System.Linq;
using System.Windows.Forms;
using WinFormSQL.Data;
using WinFormSQL.Data.Tables;

namespace WinFormSQL;

public partial class IncidentForm : Form
{
	private readonly DbUser _currentUser;

	public IncidentForm(DbUser user)
	{
		InitializeComponent();
		_currentUser = user;
	}

	private void IncidentForm_Load(object sender, EventArgs e)
	{
	}

	private void createButton_Click(object sender, EventArgs e)
	{
		using (var context = new DataBaseContext())
		{
			context.Incidents.Add(new DbIncident
			{
				AuthorId = _currentUser.Id,
				Author = $"{_currentUser.FirstName} {_currentUser.LastName}",
				Requisites = reqBox.Text,
				Title = titleBox.Text,
				Content = contentBox.Text
			});
			context.SaveChanges();
			var incidentId = context.Incidents.OrderByDescending(x => x.CreationDate).FirstOrDefault()!.Id;
			context.History.Add(new DbHistory
			{
				IncidentNumber = incidentId,
				UserId = _currentUser.Id,
				Content = contentBox.Text
			});
			context.SaveChanges();
		}

		Close();
	}
}
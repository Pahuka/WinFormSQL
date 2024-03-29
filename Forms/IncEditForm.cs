﻿using System;
using System.Linq;
using System.Windows.Forms;
using WinFormSQL.Data;
using WinFormSQL.Data.Tables;

namespace WinFormSQL;

public partial class IncEditForm : Form
{
	public IncEditForm()
	{
		InitializeComponent();
	}

	public int IncidentId { get; set; }
	public DbUser CurrentUser { get; set; }

	private void Form2_Load(object sender, EventArgs e)
	{
		UpdateTextInForm();
	}

	private void UpdateTextInForm()
	{
		using (var context = new DataBaseContext())
		{
			var incident = context.Incidents
				.FirstOrDefault(x => x.Id == IncidentId);

			if (incident != null)
			{
				titleBox.Text = incident.Title;
				reqBox.Text = incident.Requisites;
			}

			var history = context.History
				.Where(x => x.IncidentNumber == IncidentId)
				.OrderBy(x => x.EditingDate);

			foreach (var item in history)
			{
				var user = context.Users
					.FirstOrDefault(x => x.Id == item.UserId);

				if (user != null)
					contentBox.Text += $"{user.FirstName} {user.LastName} \t{item.EditingDate} \r\n{item.Content}\r\n";
			}
		}
	}

	private void saveButton_Click(object sender, EventArgs e)
	{
		using (var context = new DataBaseContext())
		{
			context.History.Add(new DbHistory
			{
				Content = editTextBox.Text,
				IncidentNumber = IncidentId,
				UserId = CurrentUser.Id
			});
			context.SaveChanges();
		}

		contentBox.Clear();
		editTextBox.Clear();
		UpdateTextInForm();
	}
}
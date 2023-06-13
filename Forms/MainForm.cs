using System;
using System.Linq;
using System.Windows.Forms;
using WinFormSQL.Data;
using WinFormSQL.Data.Tables;

namespace WinFormSQL;

public partial class MainForm : Form
{
	private readonly DbUser _currentUser;

	public MainForm(DbUser userData)
	{
		InitializeComponent();
		StartPosition = FormStartPosition.CenterScreen;
		countRows.Text = $"Количество записей - {incidentsGridView.Rows.Count.ToString()}";
		_currentUser = userData;
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		if (_currentUser.Administrator)
			adminMenu.Enabled = true;
		UpdateData();
	}

	private void UpdateData()
	{
		using (var context = new DataBaseContext())
		{
			incidentsGridView.DataSource = context.Incidents.ToList();
			incidentsGridView.Columns[0].HeaderText = "Номер инцидента";
			incidentsGridView.Columns[1].HeaderText = "Заголовок";
			incidentsGridView.Columns[2].HeaderText = "Реквизиты";
			incidentsGridView.Columns[3].HeaderText = "Автор инцидента";
			incidentsGridView.Columns[5].HeaderText = "Дата создания";
			incidentsGridView.Columns[4].Visible = false;
			incidentsGridView.Columns[6].Visible = false;
		}

		countRows.Text = $"Количество записей - {incidentsGridView.Rows.Count.ToString()}";
	}

	private void incidentGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		if (e.RowIndex < 0 || e.ColumnIndex < 0)
			return;
		var form2 = new IncEditForm();

		form2.IncidentId = int.Parse(incidentsGridView[0, e.RowIndex].Value.ToString());
		form2.CurrentUser = _currentUser;
		form2.ShowDialog(this);
	}

	private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
	{
		Application.Exit();
	}

	private void adminMenu_Click(object sender, EventArgs e)
	{
		new UsersForm().ShowDialog(this);
	}

	private void updateIncList_Click(object sender, EventArgs e)
	{
		UpdateData();
	}

	private void searchTextBox_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Enter)
		{
			using (var context = new DataBaseContext())
			{
				try
				{
					var searchId = int.Parse(searchTextBox.Text);
					var incident = context.Incidents.Where(x => x.Id == searchId).ToList();
					if (incident != null)
						incidentsGridView.DataSource = incident;
				}
				catch (Exception)
				{
					MessageBox.Show("Вводите только цифры", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}

			countRows.Text = $"Количество записей - {incidentsGridView.Rows.Count.ToString()}";
		}
	}

	private void createInc_Click(object sender, EventArgs e)
	{
		new IncidentForm(_currentUser).ShowDialog(this);
		UpdateData();
	}
}
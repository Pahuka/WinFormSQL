using System;
using System.Linq;
using System.Windows.Forms;
using WinFormSQL.Data;

namespace WinFormSQL;

public partial class AuthorizationForm : Form
{
	public AuthorizationForm()
	{
		InitializeComponent();
	}

	private void Authorisation_Load(object sender, EventArgs e)
	{
	}

	private void EnterClick(object sender, EventArgs e)
	{
		using (var cont = new DataBaseContext())
		{
			var user = cont.Users.FirstOrDefault(x => x.Login == loginTextBox.Text && x.Password == passwordTextBox.Text);
			if (user != null)
			{
				new MainForm(user).Show();
				Hide();
			}
			else
			{
				MessageBox.Show("Пользователь не найден", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
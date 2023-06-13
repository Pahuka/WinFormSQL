using System;
using System.Linq;
using System.Windows.Forms;
using WinFormSQL.Data;
using WinFormSQL.Data.Tables;

namespace WinFormSQL;

public partial class UsersForm : Form
{
	public UsersForm()
	{
		InitializeComponent();
		UpdateUsers();
	}

	private void UpdateUsers()
	{
		using (var context = new DataBaseContext())
		{
			usersGridView.DataSource = context.Users.ToList();
			usersGridView.Columns[1].HeaderText = "Имя";
			usersGridView.Columns[2].HeaderText = "Фамилия";
			usersGridView.Columns[3].HeaderText = "Логин";
			usersGridView.Columns[4].HeaderText = "Пароль";
			usersGridView.Columns[5].HeaderText = "Права администратора";
		}
	}

	private void addUser_Click(object sender, EventArgs e)
	{
		if (firstName.Text.Length == 0 || lastName.Text.Length == 0 || password.Text.Length == 0 ||
			login.Text.Length == 0)
			MessageBox.Show("Заполните все поля", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		else
			using (var context = new DataBaseContext())
			{
				if (context.Users.Where(x => x.Login.Contains(login.Text)).ToList().Count() > 0)
				{
					MessageBox.Show("Такой логин уже зарегистрирован", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					context.Users.Add(new DbUser
					{
						Administrator = adminCheck.Checked,
						FirstName = firstName.Text,
						LastName = lastName.Text,
						Login = login.Text,
						Password = password.Text
					});
					context.SaveChanges();
					MessageBox.Show("Пользователь успешно добавлен", "", MessageBoxButtons.OK,
						MessageBoxIcon.Information);
					UpdateUsers();
				}
			}
	}

	private void deleteButton_Click(object sender, EventArgs e)
	{
		using (var context = new DataBaseContext())
		{
			var user = context.Users.Where(x => x.Login.Contains(deleteUserLogin.Text)).FirstOrDefault();
			if (user != null)
			{
				context.Users.Remove(user);
				context.SaveChanges();
				MessageBox.Show("Пользователь успешно удален", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
				UpdateUsers();
			}
			else
			{
				MessageBox.Show("Такой пользователь не найден", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
	}

	private void usersGridView_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		if (e.RowIndex < 0 || e.ColumnIndex < 0)
			return;
		deleteUserLogin.Text = usersGridView[3, e.RowIndex].Value.ToString();
	}
}
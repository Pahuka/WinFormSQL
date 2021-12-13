using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using WinFormSQL.Data;

namespace WinFormSQL
{
    public partial class AddUserForm : Form
    {
        static SqlCommand command;

        public AddUserForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (firstName.Text.Length == 0 || lastName.Text.Length == 0 || password.Text.Length == 0 || login.Text.Length == 0)
                MessageBox.Show("Заполните все поля", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                //DataBase.OpenConnection();
                //var admin = adminCheck.Checked == true ? "true" : "false";
                //command = new SqlCommand($"SELECT Login FROM [Users] WHERE Login = N'{login.Text}'", DataBase.GetConnection());
                //if (command.ExecuteReader().HasRows)
                //{
                //    MessageBox.Show("Такой логин уже зарегистрирован", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
                //else
                //{
                //    DataBase.CloseConnection();
                //    DataBase.OpenConnection();
                //    command = new SqlCommand($"INSERT INTO [Users] (Id, [First Name], [Last Name], Login, Password, Administrator) " +
                //    $"VALUES ('{Guid.NewGuid()}', N'{firstName.Text}', N'{lastName.Text}', N'{login.Text}', N'{password.Text}' , N'{admin}')", DataBase.GetConnection());
                //    command.ExecuteNonQuery();
                //    DataBase.CloseConnection();
                //    MessageBox.Show("Пользователь успешно добавлен", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                using (var context = new DataBaseContext())
                {
                    if (context.Users.Where(x => x.Login.Contains(login.Text)).ToList().Count() > 0)
                        MessageBox.Show("Такой логин уже зарегистрирован", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        context.Users.Add(new Data.Tables.DbUser() {
                        Administrator = adminCheck.Checked,
                        FirstName = firstName.Text,
                        LastName = lastName.Text,
                        Login = login.Text,
                        Password = password.Text});
                        context.SaveChanges();
                        MessageBox.Show("Пользователь успешно добавлен", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}

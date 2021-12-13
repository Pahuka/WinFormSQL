using DBase;
using System;
using System.Linq;
using System.Windows.Forms;
using WinFormSQL.Data;

namespace WinFormSQL
{
    public partial class DeleteUserForm : Form
    {
        public DeleteUserForm()
        {
            InitializeComponent();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //DataBase.OpenConnection();
            //var command = new SqlCommand($"DELETE FROM [Users] WHERE Login = N'{deleteUserLogin.Text}'", DataBase.GetConnection());
            //if (command.ExecuteNonQuery() > 0)
            //    MessageBox.Show("Пользователь успешно удален", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //else
            //    MessageBox.Show("Такой пользователь не найден", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //DataBase.CloseConnection();

            using (var context = new DataBaseContext())
            {
                var user = context.Users.Where(x => x.Login.Contains(deleteUserLogin.Text)).FirstOrDefault();
                if (user != null)
                {
                    context.Users.Remove(user);
                    context.SaveChanges();
                    MessageBox.Show("Пользователь успешно удален", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Такой пользователь не найден", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

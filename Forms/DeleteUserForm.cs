using DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Data.OpenConnection();
            var command = new SqlCommand($"DELETE FROM [Users] WHERE Login = N'{deleteUserLogin.Text}'", Data.GetConnection());
            if (command.ExecuteNonQuery() > 0)
                MessageBox.Show("Пользователь успешно удален", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Такой пользователь не найден", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Data.CloseConnection();
        }
    }
}

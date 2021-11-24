using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataBase;

namespace WinFormSQL
{
    public partial class AddUserForm : Form
    {
        //static DataSet dataSet;
        static SqlCommand command;
        //static SqlDataAdapter adapter;

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
                Data.OpenConnection();
                var admin = adminCheck.Checked == true ? "true" : "false";
                command = new SqlCommand($"INSERT INTO [Users] (Id, [First Name], [Last Name], Login, Password, Administrator) " +
                    $"VALUES ('{Guid.NewGuid()}', N'{firstName.Text}', N'{lastName.Text}', N'{login.Text}', N'{password.Text}' , N'{admin}')", Data.GetConnection());
                command.ExecuteNonQuery();
                Data.CloseConnection();
                MessageBox.Show("Пользователь успешно добавлен", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

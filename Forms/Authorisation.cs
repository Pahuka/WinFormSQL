﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBase;

namespace WinFormSQL.Forms
{
    public partial class Authorisation : Form
    {
        public Authorisation()
        {
            InitializeComponent();
        }

        private void Authorisation_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data.OpenConnection();
            SqlCommand command = new SqlCommand($"SELECT * FROM Users WHERE Login = N'{textBox1.Text}' AND Password = N'{textBox2.Text}'", Data.GetConnection());
            SqlDataReader ds = command.ExecuteReader();
            
            if (ds.HasRows)
            {
                new MainForm(ds).Show();
                this.Hide();
            }
            else
                MessageBox.Show("Пользователь не найден", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using DataBase;

namespace WinFormSQL
{
    public partial class Form2 : Form
    {
        public string SqlCommand { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Data.OpenConnection();
            var command = new SqlCommand(SqlCommand, Data.GetConnection());
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                titleBox.Text = (string)dataReader.GetValue(1);
                reqBox.Text = (string)dataReader.GetValue(2);
                contentBox.Text = (string)dataReader.GetValue(5);
            }
            Data.CloseConnection();
        }
    }
}

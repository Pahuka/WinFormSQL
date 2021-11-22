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
            var dataSet = new DataSet();
            var adapter = new SqlDataAdapter(SqlCommand, Data.GetConnection());
            adapter.Fill(dataSet, "Users");
            dataGridView1.DataSource = dataSet.Tables["Users"];
            //countRows.Text = $"Количество записей - {dataGridView1.Rows.Count.ToString()}";
            Data.CloseConnection();
        }
    }
}

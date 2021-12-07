﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DBase;

namespace WinFormSQL
{
    public partial class MainForm : Form
    {
        static DataSet dataSet;
        //static SqlCommand command;
        static SqlDataAdapter adapter;
        public static User CurrentUser { get; set; }

        public MainForm(SqlDataReader userData)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            countRows.Text = $"Количество записей - {dataGridView1.Rows.Count.ToString()}";
            CurrentUser = new User(userData);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (CurrentUser.Administrator)
                adminMenu.Enabled = true;
            UpdateData();
        }

        private void UpdateData()
        {
            if (DataBase.GetConnection().State == System.Data.ConnectionState.Closed)
                DataBase.OpenConnection();
            dataSet = new DataSet();
            adapter = new SqlDataAdapter("SELECT Incidents.Id, Incidents.Title, Incidents.Requisites, Incidents.[Creation Date], " +
                "CONCAT(Users.[First Name], ' ', Users.[Last Name]) AS Author " +
                "FROM [Incidents], Users WHERE Users.Id = Incidents.Author", DataBase.GetConnection());
            adapter.Fill(dataSet, "Incidents");
            dataGridView1.DataSource = dataSet.Tables["Incidents"];
            countRows.Text = $"Количество записей - {dataGridView1.Rows.Count.ToString()}";
            DataBase.CloseConnection();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            var form2 = new IncEditForm();
            form2.SqlCommand =
                    $"SELECT * FROM [Incidents] WHERE [{dataGridView1.Columns[0].Name}] = N'{dataGridView1[0, e.RowIndex].Value}'";
            form2.ShowDialog(this);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void addUserMenu_Click(object sender, EventArgs e)
        {
            new AddUserForm().ShowDialog(this);
        }

        private void deleteUserMenu_Click(object sender, EventArgs e)
        {
            new DeleteUserForm().ShowDialog(this);
        }

        private void updateIncList_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void searchTextBox_Enter(object sender, EventArgs e)
        {
            DataBase.OpenConnection();
            dataSet = new DataSet();
            adapter = new SqlDataAdapter($"SELECT * FROM [Incidents] WHERE Id = N'{searchTextBox.Text}'", DataBase.GetConnection());
            adapter.Fill(dataSet, "Incidents");
            dataGridView1.DataSource = dataSet.Tables["Incidents"];
            countRows.Text = $"Количество записей - {dataGridView1.Rows.Count.ToString()}";
            DataBase.CloseConnection();
        }

        private void searchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataBase.OpenConnection();
                dataSet = new DataSet();
                adapter = new SqlDataAdapter($"SELECT * FROM [Incidents] WHERE Id = N'{searchTextBox.Text}'", DataBase.GetConnection());
                adapter.Fill(dataSet, "Incidents");
                dataGridView1.DataSource = dataSet.Tables["Incidents"];
                countRows.Text = $"Количество записей - {dataGridView1.Rows.Count.ToString()}";
                DataBase.CloseConnection();
            }
        }

        private void createInc_Click(object sender, EventArgs e)
        {
            new IncidentForm(CurrentUser).ShowDialog(this);
            UpdateData();
        }
    }
}

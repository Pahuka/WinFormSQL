using System;
using System.Linq;
using System.Windows.Forms;
using WinFormSQL.Data;
using WinFormSQL.Data.Tables;

namespace WinFormSQL
{
    public partial class MainForm : Form
    {
        public static DbUser CurrentUser { get; set; }
        public MainForm(DbUser userData)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            countRows.Text = $"Количество записей - {dataGridView1.Rows.Count.ToString()}";
            CurrentUser = userData;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (CurrentUser.Administrator)
                adminMenu.Enabled = true;
            UpdateData();
        }

        private void UpdateData()
        {

            using (var context = new DataBaseContext()) 
            {
                dataGridView1.DataSource = context.Incidents.ToList();
                dataGridView1.Columns[0].HeaderText = "Номер инцидента";
                dataGridView1.Columns[1].HeaderText = "Заголовок";
                dataGridView1.Columns[2].HeaderText = "Реквизиты";
                dataGridView1.Columns[3].HeaderText = "Автор инцидента";
                dataGridView1.Columns[5].HeaderText = "Дата создания";
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[6].Visible = false;
            }
            countRows.Text = $"Количество записей - {dataGridView1.Rows.Count.ToString()}";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            var form2 = new IncEditForm();

            form2.IncidentId = int.Parse(dataGridView1[0, e.RowIndex].Value.ToString());
            form2.CurrentUser = CurrentUser;
            form2.ShowDialog(this);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void adminMenu_Click(object sender, EventArgs e)
        {
            new UsersForm().ShowDialog(this);
        }

        private void updateIncList_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void searchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                using (var context = new DataBaseContext())
                {
                    try
                    {
                        var searchId = int.Parse(searchTextBox.Text);
                        var incident = context.Incidents.Where(x => x.Id == searchId).ToList();
                        if (incident != null)
                            dataGridView1.DataSource = incident;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Вводите только цифры", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                countRows.Text = $"Количество записей - {dataGridView1.Rows.Count.ToString()}";
            }
        }

        private void createInc_Click(object sender, EventArgs e)
        {
            new IncidentForm(CurrentUser).ShowDialog(this);
            UpdateData();
        }
    }
}


namespace WinFormSQL
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			incidentsGridView = new System.Windows.Forms.DataGridView();
			countRows = new System.Windows.Forms.Label();
			menuStrip1 = new System.Windows.Forms.MenuStrip();
			adminMenu = new System.Windows.Forms.ToolStripMenuItem();
			updateIncList = new System.Windows.Forms.ToolStripMenuItem();
			searchMenuBbutton = new System.Windows.Forms.ToolStripMenuItem();
			searchTextBox = new System.Windows.Forms.ToolStripTextBox();
			createInc = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)incidentsGridView).BeginInit();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// incidentsGridView
			// 
			incidentsGridView.AllowUserToAddRows = false;
			incidentsGridView.AllowUserToDeleteRows = false;
			incidentsGridView.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			incidentsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			incidentsGridView.BackgroundColor = System.Drawing.Color.White;
			incidentsGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			incidentsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			incidentsGridView.Location = new System.Drawing.Point(12, 39);
			incidentsGridView.Name = "incidentsGridView";
			incidentsGridView.ReadOnly = true;
			incidentsGridView.RowTemplate.Height = 25;
			incidentsGridView.Size = new System.Drawing.Size(820, 393);
			incidentsGridView.TabIndex = 4;
			incidentsGridView.CellDoubleClick += incidentGridView_CellDoubleClick;
			// 
			// countRows
			// 
			countRows.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
			countRows.AutoSize = true;
			countRows.Location = new System.Drawing.Point(12, 440);
			countRows.Name = "countRows";
			countRows.Size = new System.Drawing.Size(136, 15);
			countRows.TabIndex = 5;
			countRows.Text = "Количество записей - 0";
			// 
			// menuStrip1
			// 
			menuStrip1.BackColor = System.Drawing.SystemColors.Control;
			menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { adminMenu, updateIncList, searchMenuBbutton, createInc });
			menuStrip1.Location = new System.Drawing.Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new System.Drawing.Size(844, 24);
			menuStrip1.TabIndex = 6;
			menuStrip1.Text = "menuStrip1";
			// 
			// adminMenu
			// 
			adminMenu.Enabled = false;
			adminMenu.Name = "adminMenu";
			adminMenu.Size = new System.Drawing.Size(134, 20);
			adminMenu.Text = "Администрирование";
			adminMenu.Click += adminMenu_Click;
			// 
			// updateIncList
			// 
			updateIncList.Name = "updateIncList";
			updateIncList.Size = new System.Drawing.Size(183, 20);
			updateIncList.Text = "Обновить список инцидентов";
			updateIncList.Click += updateIncList_Click;
			// 
			// searchMenuBbutton
			// 
			searchMenuBbutton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { searchTextBox });
			searchMenuBbutton.Name = "searchMenuBbutton";
			searchMenuBbutton.Size = new System.Drawing.Size(115, 20);
			searchMenuBbutton.Text = "Поиск инцидента";
			// 
			// searchTextBox
			// 
			searchTextBox.Name = "searchTextBox";
			searchTextBox.Size = new System.Drawing.Size(100, 23);
			searchTextBox.KeyDown += searchTextBox_KeyDown;
			// 
			// createInc
			// 
			createInc.Name = "createInc";
			createInc.Size = new System.Drawing.Size(117, 20);
			createInc.Text = "Создать инцидент";
			createInc.Click += createInc_Click;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(844, 464);
			Controls.Add(countRows);
			Controls.Add(incidentsGridView);
			Controls.Add(menuStrip1);
			MinimumSize = new System.Drawing.Size(860, 497);
			Name = "MainForm";
			StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "SqlTest";
			FormClosed += MainForm_FormClosed;
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)incidentsGridView).EndInit();
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private System.Windows.Forms.DataGridView incidentsGridView;
		private System.Windows.Forms.Label countRows;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem adminMenu;
		private System.Windows.Forms.ToolStripMenuItem updateIncList;
		private System.Windows.Forms.ToolStripMenuItem searchMenuBbutton;
		private System.Windows.Forms.ToolStripTextBox searchTextBox;
		private System.Windows.Forms.ToolStripMenuItem createInc;
	}
}


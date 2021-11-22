
namespace WinFormSQL
{
    partial class Form1
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
            this.updateButton = new System.Windows.Forms.Button();
            this.addUserButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clearButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.removeUserButton = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.countRows = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // updateButton
            // 
            this.updateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updateButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.updateButton.Location = new System.Drawing.Point(710, 12);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(117, 36);
            this.updateButton.TabIndex = 1;
            this.updateButton.Text = "Обновить данные";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // addUserButton
            // 
            this.addUserButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addUserButton.Location = new System.Drawing.Point(710, 234);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(117, 48);
            this.addUserButton.TabIndex = 1;
            this.addUserButton.Text = "Добавить пользователя";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(710, 288);
            this.textBox2.Name = "textBox2";
            this.textBox2.PlaceholderText = "Имя пользователя";
            this.textBox2.Size = new System.Drawing.Size(117, 23);
            this.textBox2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(702, 223);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(135, 103);
            this.panel1.TabIndex = 3;
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearButton.Location = new System.Drawing.Point(710, 52);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(117, 36);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Очистить поле";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(702, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(135, 100);
            this.panel2.TabIndex = 3;
            // 
            // removeUserButton
            // 
            this.removeUserButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.removeUserButton.Location = new System.Drawing.Point(710, 114);
            this.removeUserButton.Name = "removeUserButton";
            this.removeUserButton.Size = new System.Drawing.Size(117, 45);
            this.removeUserButton.TabIndex = 1;
            this.removeUserButton.Text = "Удалить пользователя";
            this.removeUserButton.UseVisualStyleBackColor = true;
            this.removeUserButton.Click += new System.EventHandler(this.removeUserButton_Click);
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(710, 168);
            this.textBox3.Name = "textBox3";
            this.textBox3.PlaceholderText = "Имя пользователя";
            this.textBox3.Size = new System.Drawing.Size(117, 23);
            this.textBox3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(672, 420);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(702, 344);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(135, 103);
            this.panel3.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(710, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(710, 409);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Имя пользователя";
            this.textBox1.Size = new System.Drawing.Size(117, 23);
            this.textBox1.TabIndex = 2;
            // 
            // countRows
            // 
            this.countRows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.countRows.AutoSize = true;
            this.countRows.Location = new System.Drawing.Point(12, 440);
            this.countRows.Name = "countRows";
            this.countRows.Size = new System.Drawing.Size(136, 15);
            this.countRows.TabIndex = 5;
            this.countRows.Text = "Количество записей - 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 464);
            this.Controls.Add(this.countRows);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.removeUserButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(860, 497);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SqlTest";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button removeUserButton;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label countRows;
    }
}


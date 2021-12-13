
namespace WinFormSQL
{
    partial class AddUserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.adminCheck = new System.Windows.Forms.CheckBox();
            this.password = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.adminCheck);
            this.groupBox1.Controls.Add(this.password);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.lastName);
            this.groupBox1.Controls.Add(this.login);
            this.groupBox1.Controls.Add(this.firstName);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 279);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные нового сотрудника";
            // 
            // adminCheck
            // 
            this.adminCheck.AutoSize = true;
            this.adminCheck.Location = new System.Drawing.Point(53, 191);
            this.adminCheck.Name = "adminCheck";
            this.adminCheck.Size = new System.Drawing.Size(113, 19);
            this.adminCheck.TabIndex = 4;
            this.adminCheck.Text = "Администратор";
            this.adminCheck.UseVisualStyleBackColor = true;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(53, 162);
            this.password.Name = "password";
            this.password.PlaceholderText = "Пароль";
            this.password.Size = new System.Drawing.Size(211, 23);
            this.password.TabIndex = 3;
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(53, 81);
            this.lastName.Name = "lastName";
            this.lastName.PlaceholderText = "Фамилия";
            this.lastName.Size = new System.Drawing.Size(211, 23);
            this.lastName.TabIndex = 1;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(53, 123);
            this.login.Name = "login";
            this.login.PlaceholderText = "Логин";
            this.login.Size = new System.Drawing.Size(211, 23);
            this.login.TabIndex = 2;
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(53, 42);
            this.firstName.Name = "firstName";
            this.firstName.PlaceholderText = "Имя";
            this.firstName.Size = new System.Drawing.Size(211, 23);
            this.firstName.TabIndex = 0;
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 306);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(365, 345);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(365, 345);
            this.Name = "AddUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление нового сотрудника";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.CheckBox adminCheck;
    }
}
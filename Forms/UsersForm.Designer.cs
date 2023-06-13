
namespace WinFormSQL
{
	partial class UsersForm
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
			deleteUserLogin = new System.Windows.Forms.TextBox();
			deleteButton = new System.Windows.Forms.Button();
			usersGridView = new System.Windows.Forms.DataGridView();
			firstName = new System.Windows.Forms.TextBox();
			lastName = new System.Windows.Forms.TextBox();
			login = new System.Windows.Forms.TextBox();
			password = new System.Windows.Forms.TextBox();
			adminCheck = new System.Windows.Forms.CheckBox();
			addUserButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)usersGridView).BeginInit();
			SuspendLayout();
			// 
			// deleteUserLogin
			// 
			deleteUserLogin.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
			deleteUserLogin.Location = new System.Drawing.Point(663, 202);
			deleteUserLogin.Name = "deleteUserLogin";
			deleteUserLogin.PlaceholderText = "Введите логин пользователя";
			deleteUserLogin.Size = new System.Drawing.Size(191, 23);
			deleteUserLogin.TabIndex = 6;
			// 
			// deleteButton
			// 
			deleteButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
			deleteButton.Location = new System.Drawing.Point(742, 237);
			deleteButton.Name = "deleteButton";
			deleteButton.Size = new System.Drawing.Size(112, 32);
			deleteButton.TabIndex = 7;
			deleteButton.Text = "Удалить";
			deleteButton.UseVisualStyleBackColor = true;
			deleteButton.Click += deleteButton_Click;
			// 
			// usersGridView
			// 
			usersGridView.AllowUserToAddRows = false;
			usersGridView.AllowUserToDeleteRows = false;
			usersGridView.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			usersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			usersGridView.BackgroundColor = System.Drawing.Color.White;
			usersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			usersGridView.Location = new System.Drawing.Point(13, 13);
			usersGridView.Name = "usersGridView";
			usersGridView.ReadOnly = true;
			usersGridView.RowTemplate.Height = 25;
			usersGridView.Size = new System.Drawing.Size(630, 256);
			usersGridView.TabIndex = 2;
			usersGridView.TabStop = false;
			usersGridView.CellClick += usersGridView_CellClick;
			// 
			// firstName
			// 
			firstName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
			firstName.Location = new System.Drawing.Point(663, 13);
			firstName.Name = "firstName";
			firstName.PlaceholderText = "Имя";
			firstName.Size = new System.Drawing.Size(191, 23);
			firstName.TabIndex = 0;
			// 
			// lastName
			// 
			lastName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
			lastName.Location = new System.Drawing.Point(663, 42);
			lastName.Name = "lastName";
			lastName.PlaceholderText = "Фамилия";
			lastName.Size = new System.Drawing.Size(191, 23);
			lastName.TabIndex = 1;
			// 
			// login
			// 
			login.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
			login.Location = new System.Drawing.Point(663, 71);
			login.Name = "login";
			login.PlaceholderText = "Логин";
			login.Size = new System.Drawing.Size(191, 23);
			login.TabIndex = 2;
			// 
			// password
			// 
			password.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
			password.Location = new System.Drawing.Point(663, 100);
			password.Name = "password";
			password.PlaceholderText = "Пароль";
			password.Size = new System.Drawing.Size(191, 23);
			password.TabIndex = 3;
			// 
			// adminCheck
			// 
			adminCheck.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
			adminCheck.AutoSize = true;
			adminCheck.Location = new System.Drawing.Point(663, 130);
			adminCheck.Name = "adminCheck";
			adminCheck.Size = new System.Drawing.Size(113, 19);
			adminCheck.TabIndex = 4;
			adminCheck.Text = "Администратор";
			adminCheck.UseVisualStyleBackColor = true;
			// 
			// addUserButton
			// 
			addUserButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
			addUserButton.Location = new System.Drawing.Point(742, 158);
			addUserButton.Name = "addUserButton";
			addUserButton.Size = new System.Drawing.Size(112, 32);
			addUserButton.TabIndex = 5;
			addUserButton.Text = "Добавить";
			addUserButton.UseVisualStyleBackColor = true;
			addUserButton.Click += addUser_Click;
			// 
			// UsersForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(866, 281);
			Controls.Add(adminCheck);
			Controls.Add(password);
			Controls.Add(login);
			Controls.Add(lastName);
			Controls.Add(firstName);
			Controls.Add(usersGridView);
			Controls.Add(addUserButton);
			Controls.Add(deleteButton);
			Controls.Add(deleteUserLogin);
			MinimizeBox = false;
			MinimumSize = new System.Drawing.Size(882, 320);
			Name = "UsersForm";
			StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			Text = "Пользователи";
			((System.ComponentModel.ISupportInitialize)usersGridView).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.TextBox deleteUserLogin;
		private System.Windows.Forms.Button deleteButton;
		private System.Windows.Forms.DataGridView usersGridView;
		private System.Windows.Forms.TextBox firstName;
		private System.Windows.Forms.TextBox lastName;
		private System.Windows.Forms.TextBox login;
		private System.Windows.Forms.TextBox password;
		private System.Windows.Forms.CheckBox adminCheck;
		private System.Windows.Forms.Button addUserButton;
	}
}
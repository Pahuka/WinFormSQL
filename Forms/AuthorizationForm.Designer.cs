
namespace WinFormSQL
{
	partial class AuthorizationForm
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
			passwordTextBox = new System.Windows.Forms.TextBox();
			loginTextBox = new System.Windows.Forms.TextBox();
			enterButton = new System.Windows.Forms.Button();
			SuspendLayout();
			// 
			// passwordTextBox
			// 
			passwordTextBox.Location = new System.Drawing.Point(51, 72);
			passwordTextBox.Name = "passwordTextBox";
			passwordTextBox.PlaceholderText = "Пароль";
			passwordTextBox.Size = new System.Drawing.Size(160, 23);
			passwordTextBox.TabIndex = 0;
			// 
			// loginTextBox
			// 
			loginTextBox.Location = new System.Drawing.Point(51, 24);
			loginTextBox.Name = "loginTextBox";
			loginTextBox.PlaceholderText = "Логин";
			loginTextBox.Size = new System.Drawing.Size(160, 23);
			loginTextBox.TabIndex = 0;
			// 
			// enterButton
			// 
			enterButton.Location = new System.Drawing.Point(85, 120);
			enterButton.Name = "enterButton";
			enterButton.Size = new System.Drawing.Size(92, 38);
			enterButton.TabIndex = 1;
			enterButton.Text = "Войти";
			enterButton.UseVisualStyleBackColor = true;
			enterButton.Click += EnterClick;
			// 
			// AuthorizationForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(264, 191);
			Controls.Add(enterButton);
			Controls.Add(loginTextBox);
			Controls.Add(passwordTextBox);
			MaximumSize = new System.Drawing.Size(280, 230);
			MinimumSize = new System.Drawing.Size(280, 230);
			Name = "AuthorizationForm";
			StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "Авторизация";
			Load += Authorisation_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.TextBox passwordTextBox;
		private System.Windows.Forms.TextBox loginTextBox;
		private System.Windows.Forms.Button enterButton;
	}
}
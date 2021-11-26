
namespace WinFormSQL
{
    partial class IncidentForm
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
            this.createButton = new System.Windows.Forms.Button();
            this.reqBox = new System.Windows.Forms.TextBox();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.contentBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // createButton
            // 
            this.createButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.createButton.Location = new System.Drawing.Point(561, 311);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(114, 34);
            this.createButton.TabIndex = 0;
            this.createButton.Text = "Создать";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // reqBox
            // 
            this.reqBox.Location = new System.Drawing.Point(12, 12);
            this.reqBox.Name = "reqBox";
            this.reqBox.PlaceholderText = "ИНН КПП";
            this.reqBox.Size = new System.Drawing.Size(187, 23);
            this.reqBox.TabIndex = 1;
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(234, 12);
            this.titleBox.Name = "titleBox";
            this.titleBox.PlaceholderText = "Заголовок";
            this.titleBox.Size = new System.Drawing.Size(316, 23);
            this.titleBox.TabIndex = 2;
            // 
            // contentBox
            // 
            this.contentBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contentBox.Location = new System.Drawing.Point(12, 50);
            this.contentBox.Multiline = true;
            this.contentBox.Name = "contentBox";
            this.contentBox.PlaceholderText = "Текст инцидента";
            this.contentBox.Size = new System.Drawing.Size(538, 295);
            this.contentBox.TabIndex = 3;
            // 
            // IncidentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.contentBox);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.reqBox);
            this.Controls.Add(this.createButton);
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "IncidentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "IncodentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.TextBox reqBox;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.TextBox contentBox;
    }
}
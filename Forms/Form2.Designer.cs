﻿
namespace WinFormSQL
{
    partial class Form2
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
            this.reqBox = new System.Windows.Forms.TextBox();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.contentBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // reqBox
            // 
            this.reqBox.Location = new System.Drawing.Point(12, 12);
            this.reqBox.Name = "reqBox";
            this.reqBox.ReadOnly = true;
            this.reqBox.Size = new System.Drawing.Size(187, 23);
            this.reqBox.TabIndex = 0;
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(234, 12);
            this.titleBox.Name = "titleBox";
            this.titleBox.ReadOnly = true;
            this.titleBox.Size = new System.Drawing.Size(316, 23);
            this.titleBox.TabIndex = 1;
            // 
            // contentBox
            // 
            this.contentBox.Location = new System.Drawing.Point(12, 50);
            this.contentBox.Multiline = true;
            this.contentBox.Name = "contentBox";
            this.contentBox.ReadOnly = true;
            this.contentBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.contentBox.Size = new System.Drawing.Size(538, 295);
            this.contentBox.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.contentBox);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.reqBox);
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Подробности записи";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox reqBox;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.TextBox contentBox;
    }
}
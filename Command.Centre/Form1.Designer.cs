﻿namespace Command.Centre
{
	partial class Form1
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
			this.lblStatus = new System.Windows.Forms.Label();
			this.btnGetSystemStatus = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblStatus
			// 
			this.lblStatus.AutoSize = true;
			this.lblStatus.Location = new System.Drawing.Point(19, 39);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(70, 13);
			this.lblStatus.TabIndex = 0;
			this.lblStatus.Text = "Status here...";
			// 
			// btnGetSystemStatus
			// 
			this.btnGetSystemStatus.Location = new System.Drawing.Point(22, 13);
			this.btnGetSystemStatus.Name = "btnGetSystemStatus";
			this.btnGetSystemStatus.Size = new System.Drawing.Size(135, 23);
			this.btnGetSystemStatus.TabIndex = 1;
			this.btnGetSystemStatus.Text = "Get system status";
			this.btnGetSystemStatus.UseVisualStyleBackColor = true;
			this.btnGetSystemStatus.Click += new System.EventHandler(this.btnGetSystemStatus_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnGetSystemStatus);
			this.Controls.Add(this.lblStatus);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.Button btnGetSystemStatus;
	}
}


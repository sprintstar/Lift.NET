namespace Command.Centre
{
	partial class MainForm
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
			this.tbLog = new System.Windows.Forms.TextBox();
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
			// tbLog
			// 
			this.tbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbLog.Location = new System.Drawing.Point(163, 13);
			this.tbLog.Multiline = true;
			this.tbLog.Name = "tbLog";
			this.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.tbLog.Size = new System.Drawing.Size(630, 246);
			this.tbLog.TabIndex = 2;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(805, 271);
			this.Controls.Add(this.tbLog);
			this.Controls.Add(this.btnGetSystemStatus);
			this.Controls.Add(this.lblStatus);
			this.Name = "MainForm";
			this.Text = "Main form";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.Button btnGetSystemStatus;
		private System.Windows.Forms.TextBox tbLog;
	}
}


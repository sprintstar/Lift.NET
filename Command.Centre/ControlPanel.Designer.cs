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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudFloor1 = new System.Windows.Forms.NumericUpDown();
            this.btnCall1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudFloor2 = new System.Windows.Forms.NumericUpDown();
            this.btnCall2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFloor1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFloor2)).BeginInit();
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
            this.tbLog.Location = new System.Drawing.Point(163, 74);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbLog.Size = new System.Drawing.Size(630, 246);
            this.tbLog.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudFloor1);
            this.groupBox1.Controls.Add(this.btnCall1);
            this.groupBox1.Location = new System.Drawing.Point(163, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 55);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shaft 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Floor";
            // 
            // nudFloor1
            // 
            this.nudFloor1.Location = new System.Drawing.Point(42, 19);
            this.nudFloor1.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.nudFloor1.Name = "nudFloor1";
            this.nudFloor1.Size = new System.Drawing.Size(84, 20);
            this.nudFloor1.TabIndex = 1;
            // 
            // btnCall1
            // 
            this.btnCall1.Location = new System.Drawing.Point(132, 16);
            this.btnCall1.Name = "btnCall1";
            this.btnCall1.Size = new System.Drawing.Size(75, 23);
            this.btnCall1.TabIndex = 0;
            this.btnCall1.Text = "Call";
            this.btnCall1.UseVisualStyleBackColor = true;
            this.btnCall1.Click += new System.EventHandler(this.btnCall1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.nudFloor2);
            this.groupBox2.Controls.Add(this.btnCall2);
            this.groupBox2.Location = new System.Drawing.Point(393, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(224, 55);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Shaft 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Floor";
            // 
            // nudFloor2
            // 
            this.nudFloor2.Location = new System.Drawing.Point(42, 19);
            this.nudFloor2.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.nudFloor2.Name = "nudFloor2";
            this.nudFloor2.Size = new System.Drawing.Size(84, 20);
            this.nudFloor2.TabIndex = 1;
            // 
            // btnCall2
            // 
            this.btnCall2.Location = new System.Drawing.Point(132, 16);
            this.btnCall2.Name = "btnCall2";
            this.btnCall2.Size = new System.Drawing.Size(75, 23);
            this.btnCall2.TabIndex = 0;
            this.btnCall2.Text = "Call";
            this.btnCall2.UseVisualStyleBackColor = true;
            this.btnCall2.Click += new System.EventHandler(this.btnCall2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 332);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbLog);
            this.Controls.Add(this.btnGetSystemStatus);
            this.Controls.Add(this.lblStatus);
            this.MinimumSize = new System.Drawing.Size(821, 371);
            this.Name = "MainForm";
            this.Text = "Main form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFloor1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFloor2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.Button btnGetSystemStatus;
		private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudFloor1;
        private System.Windows.Forms.Button btnCall1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudFloor2;
        private System.Windows.Forms.Button btnCall2;
    }
}


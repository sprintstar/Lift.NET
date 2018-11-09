using System;
using System.Reflection;
using System.Windows.Forms;
using log4net;

// ReSharper disable InconsistentNaming

namespace Command.Centre
{
	public partial class MainForm : Form
	{
		private LiftControl.LiftController _liftController;

		public MainForm()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			_liftController = new LiftControl.LiftController();
			var status = _liftController.GetStatus();
			lblStatus.Text = status.ToString();
		}

		private void btnGetSystemStatus_Click(object sender, EventArgs e)
		{
			var status = _liftController.GetStatus();
			lblStatus.Text = status.ToString();
		}
	}
}

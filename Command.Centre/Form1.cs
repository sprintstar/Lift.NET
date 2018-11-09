using System;
using System.Windows.Forms;
// ReSharper disable InconsistentNaming

namespace Command.Centre
{
	public partial class Form1 : Form
	{
		private LiftControl.LiftController _liftController;

		public Form1()
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

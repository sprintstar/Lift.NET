using LiftControl.Model.Messages.In;
using LiftControl.Model.Messages.Out;
using log4net;
using System;
using System.Reflection;
using System.Windows.Forms;
using TinyMessenger;

// ReSharper disable InconsistentNaming

namespace Command.Centre
{
    public partial class MainForm : Form
	{
        private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        private LiftControl.LiftController _liftController;
        private TinyMessengerHub _messageHub = new TinyMessengerHub();

        public MainForm()
		{
			InitializeComponent();
            _messageHub.Subscribe<PositionMessage>((m) => { _log.Info($"Lift status: {m.Status}"); });
        }

		private void Form1_Load(object sender, EventArgs e)
		{
            _liftController = new LiftControl.LiftController(_messageHub);
			var status = _liftController.GetStatus();
			lblStatus.Text = status.ToString();
		}

		private void btnGetSystemStatus_Click(object sender, EventArgs e)
		{
			var status = _liftController.GetStatus();
			lblStatus.Text = status.ToString();
		}

        private void btnCall_Click(object sender, EventArgs e)
        {
            var floor = (int)nudFloor.Value;
            _messageHub.Publish(new ButtonPressMessage(floor));
        }
    }
}

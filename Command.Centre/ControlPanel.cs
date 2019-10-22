using LiftControl;
using LiftControl.Model.Messages.In;
using LiftControl.Model.Messages.Out;
using log4net;
using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using TinyMessenger;
using static LiftControl.Config;

namespace Command.Centre
{
    public partial class MainForm : Form
    {
        private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        private LiftController _liftController;
        private TinyMessengerHub _messageHub = new TinyMessengerHub();

        public MainForm()
        {
            InitializeComponent();
            _messageHub.Subscribe<PositionMessage>((m) => { _log.Info($"Lift status: {m.Status}"); });
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var config = new Config(
                new ConfigShaft("shaft1", ConfigFloor.CreateRange(3, 10)),
                new ConfigShaft("shaft2", ConfigFloor.CreateRange(1, 20))
                );

            _liftController = new LiftController(_messageHub, config);
            var status = _liftController.GetStatus();
            lblStatus.Text = status.ToString();
            nudFloor1.Minimum = config.Shafts[0].Floors.First().Level;
            nudFloor1.Maximum = config.Shafts[0].Floors.Last().Level;
            nudFloor2.Minimum = config.Shafts[1].Floors.First().Level;
            nudFloor2.Maximum = config.Shafts[1].Floors.Last().Level;
        }

        private void btnGetSystemStatus_Click(object sender, EventArgs e)
        {
            var status = _liftController.GetStatus();
            lblStatus.Text = status.ToString();
        }

        private void btnCall1_Click(object sender, EventArgs e)
        {
            var floor = (int)nudFloor1.Value;
            _messageHub.Publish(new ButtonPressMessage("shaft1", floor));
        }

        private void btnCall2_Click(object sender, EventArgs e)
        {
            var floor = (int)nudFloor2.Value;
            _messageHub.Publish(new ButtonPressMessage("shaft2", floor));
        }
    }
}

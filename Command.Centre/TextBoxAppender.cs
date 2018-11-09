using log4net.Appender;
using log4net.Core;
using System.Windows.Forms;

namespace Command.Centre
{
	internal class TextBoxAppender : AppenderSkeleton
	{
		private TextBox _AppenderTextBox { get; set; }
		internal string FormName { get; set; }
		internal string TextBoxName { get; set; }

		private static Control _FindControlRecursive(Control root, string textBoxName)
		{
			if (root.Name == textBoxName) return root;
			foreach (Control c in root.Controls)
			{
				var t = _FindControlRecursive(c, textBoxName);
				if (t != null) return t;
			}
			return null;
		}

		protected override void Append(LoggingEvent loggingEvent)
		{
			if (_AppenderTextBox == null)
			{
				if (string.IsNullOrEmpty(FormName) ||
					string.IsNullOrEmpty(TextBoxName))
					return;

				var form = Application.OpenForms[FormName];
				if (form == null)
					return;

				_AppenderTextBox = (TextBox)_FindControlRecursive(form, TextBoxName);
				if (_AppenderTextBox == null)
					return;

				form.FormClosing += (s, e) => _AppenderTextBox = null;
			}

			_AppenderTextBox.BeginInvoke((MethodInvoker)delegate
			{
				_AppenderTextBox.AppendText(RenderLoggingEvent(loggingEvent));
			});
		}
	}
}

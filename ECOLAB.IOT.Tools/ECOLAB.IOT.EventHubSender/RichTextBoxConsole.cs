namespace ECOLAB.IOT.EventHubSender
{
    using global::ECOLAB.IOT.Tools.Entity;
    using System.Text;
    using System.Windows.Forms;

    internal class RichTextBoxConsole : TextWriter
    {
        RichTextBox output = null; //Textbox used to show Console's output.
        delegate void VoidAction();
        private static int counter = 0;
        private static QueueLength<string>  values = new QueueLength<string>(100);
        /// <summary>
        /// Custom TextBox-Class used to print the Console output.
        /// </summary>
        /// <param name="_output">Textbox used to show Console's output.</param>
        public RichTextBoxConsole(RichTextBox _output)
        {
            output = _output;
            output.ScrollBars = RichTextBoxScrollBars.Both;
            output.WordWrap = true;
        }

        //<summary>
        //Appends text to the textbox and to the logfile
        //</summary>
        //<param name="value">Input-string which is appended to the textbox.</param>
        public override void WriteLine(string value)
        {
            VoidAction action = delegate
            {
                try
                {
                    if (!string.IsNullOrEmpty(value))
                    {
                        var num = Interlocked.Increment(ref counter);
                        values.Enqueue(value);
                        output.Focus();
                        output.Select(output.TextLength, 0);
                        output.ScrollToCaret();
                        output.Text = string.Join("", values);
                        output.SelectionStart = output.Text.Length;
                        output.ScrollToCaret();
                    }
                    else
                    {
                        output.AppendText("empty");
                    }
                }
                catch (Exception ex)
                {

                }

            };
            if (output.IsHandleCreated)
            {
                try
                {
                    output.BeginInvoke(action);
                }
                catch { }
            }
        }


        public override Encoding Encoding
        {
            get { return Encoding.UTF8; }
        }

    }
}

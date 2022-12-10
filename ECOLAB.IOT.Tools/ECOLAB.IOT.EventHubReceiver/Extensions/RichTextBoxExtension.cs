namespace ECOLAB.IOT.EventHubReceiver.Extensions
{
    using System;
    using System.Windows.Forms;

    internal static class RichTextBoxExtension
    {
        public static void AppendTextColorful(this RichTextBox rtBox, string text, Color color, bool addNewLine = true)
        {
            rtBox.Invoke(new Action(() =>
            {
                if (addNewLine)
                {
                    text += Environment.NewLine;
                }
                rtBox.SelectionStart = rtBox.TextLength;
                rtBox.SelectionLength = 0;
                rtBox.SelectionColor = color;
                rtBox.AppendText(text);
                rtBox.SelectionColor = rtBox.ForeColor;
            }));
        }
    }
}

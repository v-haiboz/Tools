namespace ECOLAB.IOT.EventHubSender
{
    using global::ECOLAB.IOT.EventHubSender.Console;
    using global::ECOLAB.IOT.EventHubSender.Console.Processor;
    using global::ECOLAB.IOT.EventHubSender.Pattern.Narmal;
    using global::ECOLAB.IOT.Tools.Entity;
    using global::ECOLAB.IOT.Tools.Service;
    using System;

    public partial class ECOLAB : Form
    {
        private static ECOLABIOTToolConfigService eCOLABIOTToolConfigService = new ECOLABIOTToolConfigService();
        private static EventHubConfig eventHubConfig = eCOLABIOTToolConfigService.GetSenderEventHubConfig();
        private int heigh;
        float X, Y;
        public ECOLAB()
        {
            InitializeComponent();
        }

        private bool isShown = true;
        private void label_Response_Click(object sender, EventArgs e)
        {
            splitter2.Move -= splitter2_Move;
            if (isShown)
            {
                panel_Response.Height = label_Response.Height;
                isShown = false;
            }
            else
            {
                panel_Response.Height = heigh;
                isShown = true;
            }
            splitter2.Move += splitter2_Move;
        }

        private void ECOLAB_Load(object sender, EventArgs e)
        {
            X = this.Width;
            Y = this.Height;
            from_title = this.Text;
            heigh = panel_Response.Height;
            setTag(this);
            InitChildPattern();
            AddChildPattern(groupBox_Pattern1);
            this.textBox_ConnectionString.Text = eventHubConfig.ConnectionString;
            this.textBox_EventHubName.Text = eventHubConfig.EventHubName;
            this.textBox_Body.Text = eCOLABIOTToolConfigService.GetSenderBody();
            SetOutLog();
            textBox_ConnectionString.SelectionStart = textBox_ConnectionString.Text.Length;  //设置长度
            textBox_ConnectionString.ScrollToCaret();
        }
        string from_title;
        private void ECOLAB_Resize(object sender, EventArgs e)
        {
            float newx = (this.Width) / X;
            float newy = this.Height / Y;
            setControls(newx, newy, this);
            this.Text = $"{from_title} 宽:{this.Width} 高:{this.Height}";
            heigh = panel_Response.Height;
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            AddChildPattern(groupBox_Pattern1);
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            AddChildPattern(groupBox_Pattern2);
        }
        private void setControls(float newx, float newy, Control cons)
        {
            foreach (Control con in cons.Controls)
            {
                string[] mytag = con.Tag.ToString().Split(new char[] { ':' });
                float a = Convert.ToSingle(mytag[0]) * newx;
                con.Width = (int)a;
                a = Convert.ToSingle(mytag[1]) * newy;
                con.Height = (int)(a);
                a = Convert.ToSingle(mytag[2]) * newx;
                con.Left = (int)(a);
                a = Convert.ToSingle(mytag[3]) * newy;
                con.Top = (int)(a);
                Single currentSize = Convert.ToSingle(mytag[4]) * newy;
                con.Font = new Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit);
                if (con.Controls.Count > 0)
                {
                    setControls(newx, newy, con);
                }
            }
        }
        private void setTag(Control cons)
        {
            //遍历窗体中的控件
            foreach (Control con in cons.Controls)
            {
                con.Tag = con.Width + ":" + con.Height + ":" + con.Left + ":" + con.Top + ":" + con.Font.Size;
                if (con.Controls.Count > 0)
                    setTag(con);
            }
        }
        private GroupBox activeGroupBox = null;
        private GroupBox unActionedGroupBox = null;

        private void splitter2_Move(object sender, EventArgs e)
        {
            heigh = panel_Response.Height;
        }

        private void AddChildPattern(GroupBox childGroupBox)
        {
            unActionedGroupBox = activeGroupBox;
            if (unActionedGroupBox != null)
            {
                unActionedGroupBox.Hide();
            }
            activeGroupBox = childGroupBox;
            activeGroupBox.Show();
        }
        private void SetOutLog()
        {
            RichTextBoxConsole writer = new RichTextBoxConsole(this.richTextBox_Log);
            System.Console.SetOut(writer);
        }
        private async void button_Send_Click(object sender, EventArgs e)
        {
            if (this.radioButton1.Checked)
            {
                try
                {
                    await Normal();
                }
                finally
                {
                    this.button_Send.Enabled = true; // Re-enable everything after the above completes
                }
            }
            else if (this.radioButton2.Checked)
            {
                try
                {
                    await Advance();
                }
                finally
                {
                }
            }
        }
        private async Task Advance()
        {
            if (!string.IsNullOrEmpty(this.textBox_ConnectionString.Text) &&
                !string.IsNullOrEmpty(this.textBox_EventHubName.Text) &&
                !string.IsNullOrEmpty(this.textBox_Body.Text) &&
                !string.IsNullOrEmpty(this.numericUpDown_Time.Text) && int.TryParse(this.numericUpDown_Time.Text, out var totalTime) && totalTime > 0 &&
                !string.IsNullOrEmpty(this.numericUpDown_MutiThread.Text) && int.TryParse(this.numericUpDown_MutiThread.Text, out var threadCount) && threadCount > 0 &&
                !string.IsNullOrEmpty(this.numericUpDow_SleepTime.Text) && int.TryParse(this.numericUpDow_SleepTime.Text, out var sleepTime)
                )
            {
                this.button_Send.Enabled = false;
                CallerContext.SendEventOption = new Console.Entity.SendEventOption
                {
                    EventHubConnetionString = this.textBox_ConnectionString.Text,
                    EventHubName = this.textBox_EventHubName.Text,
                    Body = this.textBox_Body.Text,
                    TotalTime = totalTime,
                    SleepTime = sleepTime,
                    ThreadCount = threadCount
                };
                var instance = new EventHubDefaultProcessor((bl) => { this.button_Send.Enabled = true; });
                instance.Start();
            }
            else {
                System.Console.WriteLine("Advance Pattern Parameter incorrect.");
            }
        }

        private async Task Normal()
        {
            if (!string.IsNullOrEmpty(this.textBox_ConnectionString.Text) &&
                !string.IsNullOrEmpty(this.textBox_EventHubName.Text) &&
                !string.IsNullOrEmpty(this.textBox_Body.Text) &&
                !string.IsNullOrEmpty(this.numericUpDown_Quantity.Text) && int.TryParse(this.numericUpDown_Quantity.Text, out var quanlity))
            {
                this.button_Send.Enabled = false;
                var processor = new NormalProcessor(this.textBox_ConnectionString.Text,
                    this.textBox_EventHubName.Text,
                    this.textBox_Body.Text,
                    quanlity);
                await processor.Process(Guid.NewGuid().GetHashCode());
            }
            else
            {
                System.Console.WriteLine("Normal Pattern Parameter incorrect.");
            }

        }

        private void InitChildPattern()
        {
            groupBox_Pattern1.Dock = DockStyle.Fill;
            panel_Pattern_Content.Controls.Add(groupBox_Pattern1);
            groupBox_Pattern2.Dock = DockStyle.Fill;
            panel_Pattern_Content.Controls.Add(groupBox_Pattern2);
        }
    }
}

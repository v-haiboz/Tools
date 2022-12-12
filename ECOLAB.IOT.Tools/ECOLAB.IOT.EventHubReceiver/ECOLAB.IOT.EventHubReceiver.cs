namespace ECOLAB.IOT.EventHubReceiver
{
    using ECOLAB.IOT.EventHubReceiver.Extensions;
    using ECOLAB.IOT.Tools.Entity;
    using ECOLAB.IOT.Tools.Service;
    using System;

    public partial class Form1 : Form
    {
        private static ECOLABIOTToolConfigService eCOLABIOTToolConfigService = new ECOLABIOTToolConfigService();
        private static EventHubConfig eventHubConfig = eCOLABIOTToolConfigService.GetReceiverEventHubConfig();
        
        float X, Y;
        string from_title;

        private DispatchProcessor dataDispatcher;
        private EventHubListenProcessor eventHubListener;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Resize += new EventHandler(Form1_Resize);
            X = this.Width;
            Y = this.Height;
            from_title = this.Text;
            setTag(this);
            DataBing();
            
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            float newx = (this.Width) / X; 
            float newy = this.Height / Y;
            setControls(newx, newy, this);
            this.Text = $"{from_title} 宽:{this.Width} 高:{this.Height}";
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

        bool isStart = false;
        private void button_Listener_Click(object sender, EventArgs e)
        {
            if (!isStart)
            {
                Start();
                button_Listener.Text = "停止";
                button_Listener.BackColor=Color.DarkRed;
                isStart = true;
            }
            else {
                Stop();
                button_Listener.Text = "开始监听";
                button_Listener.BackColor = Color.Green;
                isStart = false;
            }
        }

        private void Start()
        {
            dataDispatcher = new DispatchProcessor();
            eventHubListener = new EventHubListenProcessor(richTextBox_ConnectionString.Text, textBox_EventHubName.Text, textBox_ConsumerGroup.Text, (content) => { dataDispatcher.Receive(content); });
            dataDispatcher.Start();
            eventHubListener.Start();
        }

        private void Stop()
        {
            eventHubListener.Stop();
            dataDispatcher.Stop();
        }

        public void OutPut(Color color, string str)
        {
            this.richTextBox1.AppendTextColorful(str,color);
        }

        private void DataBing()
        {
            this.richTextBox_ConnectionString.Text = eventHubConfig.ConnectionString;
            this.textBox_EventHubName.Text= eventHubConfig.EventHubName;
            this.textBox_ConsumerGroup.Text = eventHubConfig.ConsumerGroup;
            SetOutLog();
        }

        private void SetOutLog()
        {
            RichTextBoxConsole writer = new RichTextBoxConsole(this.richTextBox1,this.label_Header_LineContent);
            Console.SetOut(writer);
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
    }
}
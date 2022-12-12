namespace ECOLAB.IOT.EventHubSender
{
    partial class ECOLAB
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
            this.panel_Request = new System.Windows.Forms.Panel();
            this.groupBox_Request = new System.Windows.Forms.GroupBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel_EventHubConn = new System.Windows.Forms.Panel();
            this.button_Send = new System.Windows.Forms.Button();
            this.textBox_ConnectionString = new System.Windows.Forms.TextBox();
            this.label_EventhubConn = new System.Windows.Forms.Label();
            this.panel_Response = new System.Windows.Forms.Panel();
            this.label_Response = new System.Windows.Forms.Label();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_Body = new System.Windows.Forms.TabPage();
            this.tabPage_Pattern = new System.Windows.Forms.TabPage();
            this.panel_Pattern_Content = new System.Windows.Forms.Panel();
            this.groupBox_Pattern2 = new System.Windows.Forms.GroupBox();
            this.label_ThreadTime = new System.Windows.Forms.Label();
            this.label_MutiTheard = new System.Windows.Forms.Label();
            this.label_Time = new System.Windows.Forms.Label();
            this.groupBox_Pattern1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Pattern_Head = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.tabPage_EventHubName = new System.Windows.Forms.TabPage();
            this.textBox_EventHubName = new System.Windows.Forms.TextBox();
            this.label_EnventHubName = new System.Windows.Forms.Label();
            this.textBox_Body = new System.Windows.Forms.TextBox();
            this.richTextBox_Log = new System.Windows.Forms.RichTextBox();
            this.numericUpDown_Time = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_MutiThread = new System.Windows.Forms.NumericUpDown();
            this.numericUpDow_SleepTime = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Quantity = new System.Windows.Forms.NumericUpDown();
            this.panel_Request.SuspendLayout();
            this.groupBox_Request.SuspendLayout();
            this.panel_EventHubConn.SuspendLayout();
            this.panel_Response.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage_Body.SuspendLayout();
            this.tabPage_Pattern.SuspendLayout();
            this.panel_Pattern_Content.SuspendLayout();
            this.groupBox_Pattern2.SuspendLayout();
            this.groupBox_Pattern1.SuspendLayout();
            this.panel_Pattern_Head.SuspendLayout();
            this.tabPage_EventHubName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Time)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MutiThread)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDow_SleepTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Request
            // 
            this.panel_Request.Controls.Add(this.groupBox_Request);
            this.panel_Request.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Request.Location = new System.Drawing.Point(0, 0);
            this.panel_Request.Name = "panel_Request";
            this.panel_Request.Size = new System.Drawing.Size(1211, 318);
            this.panel_Request.TabIndex = 1;
            // 
            // groupBox_Request
            // 
            this.groupBox_Request.Controls.Add(this.tabControl1);
            this.groupBox_Request.Controls.Add(this.splitter1);
            this.groupBox_Request.Controls.Add(this.panel_EventHubConn);
            this.groupBox_Request.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Request.Location = new System.Drawing.Point(0, 0);
            this.groupBox_Request.Name = "groupBox_Request";
            this.groupBox_Request.Size = new System.Drawing.Size(1211, 318);
            this.groupBox_Request.TabIndex = 0;
            this.groupBox_Request.TabStop = false;
            this.groupBox_Request.Text = "发送区";
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(3, 127);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1205, 8);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // panel_EventHubConn
            // 
            this.panel_EventHubConn.Controls.Add(this.button_Send);
            this.panel_EventHubConn.Controls.Add(this.textBox_ConnectionString);
            this.panel_EventHubConn.Controls.Add(this.label_EventhubConn);
            this.panel_EventHubConn.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_EventHubConn.Location = new System.Drawing.Point(3, 26);
            this.panel_EventHubConn.Name = "panel_EventHubConn";
            this.panel_EventHubConn.Size = new System.Drawing.Size(1205, 101);
            this.panel_EventHubConn.TabIndex = 0;
            // 
            // button_Send
            // 
            this.button_Send.Location = new System.Drawing.Point(973, 14);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(112, 72);
            this.button_Send.TabIndex = 2;
            this.button_Send.Text = "Send";
            this.button_Send.UseVisualStyleBackColor = true;
            this.button_Send.Click += new System.EventHandler(this.button_Send_Click);
            // 
            // textBox_ConnectionString
            // 
            this.textBox_ConnectionString.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_ConnectionString.Location = new System.Drawing.Point(138, 3);
            this.textBox_ConnectionString.Multiline = true;
            this.textBox_ConnectionString.Name = "textBox_ConnectionString";
            this.textBox_ConnectionString.Size = new System.Drawing.Size(788, 95);
            this.textBox_ConnectionString.TabIndex = 1;
            // 
            // label_EventhubConn
            // 
            this.label_EventhubConn.AutoSize = true;
            this.label_EventhubConn.Location = new System.Drawing.Point(15, 32);
            this.label_EventhubConn.Name = "label_EventhubConn";
            this.label_EventhubConn.Size = new System.Drawing.Size(118, 24);
            this.label_EventhubConn.TabIndex = 0;
            this.label_EventhubConn.Text = "连接字符串：";
            // 
            // panel_Response
            // 
            this.panel_Response.Controls.Add(this.richTextBox_Log);
            this.panel_Response.Controls.Add(this.label_Response);
            this.panel_Response.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Response.Location = new System.Drawing.Point(0, 318);
            this.panel_Response.Name = "panel_Response";
            this.panel_Response.Size = new System.Drawing.Size(1211, 302);
            this.panel_Response.TabIndex = 2;
            // 
            // label_Response
            // 
            this.label_Response.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label_Response.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_Response.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Response.Location = new System.Drawing.Point(0, 0);
            this.label_Response.Name = "label_Response";
            this.label_Response.Padding = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.label_Response.Size = new System.Drawing.Size(1211, 37);
            this.label_Response.TabIndex = 0;
            this.label_Response.Text = "日志区";
            this.label_Response.Click += new System.EventHandler(this.label_Response_Click);
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter2.Location = new System.Drawing.Point(0, 308);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(1211, 10);
            this.splitter2.TabIndex = 3;
            this.splitter2.TabStop = false;
            this.splitter2.Move += new System.EventHandler(this.splitter2_Move);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_Pattern);
            this.tabControl1.Controls.Add(this.tabPage_EventHubName);
            this.tabControl1.Controls.Add(this.tabPage_Body);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 135);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1205, 180);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage_Body
            // 
            this.tabPage_Body.Controls.Add(this.textBox_Body);
            this.tabPage_Body.Location = new System.Drawing.Point(4, 33);
            this.tabPage_Body.Name = "tabPage_Body";
            this.tabPage_Body.Size = new System.Drawing.Size(1197, 143);
            this.tabPage_Body.TabIndex = 2;
            this.tabPage_Body.Text = "Body";
            this.tabPage_Body.UseVisualStyleBackColor = true;
            // 
            // tabPage_Pattern
            // 
            this.tabPage_Pattern.Controls.Add(this.panel_Pattern_Content);
            this.tabPage_Pattern.Controls.Add(this.panel_Pattern_Head);
            this.tabPage_Pattern.Location = new System.Drawing.Point(4, 33);
            this.tabPage_Pattern.Name = "tabPage_Pattern";
            this.tabPage_Pattern.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Pattern.Size = new System.Drawing.Size(1197, 143);
            this.tabPage_Pattern.TabIndex = 0;
            this.tabPage_Pattern.Text = "模式";
            this.tabPage_Pattern.UseVisualStyleBackColor = true;
            // 
            // panel_Pattern_Content
            // 
            this.panel_Pattern_Content.Controls.Add(this.groupBox_Pattern2);
            this.panel_Pattern_Content.Controls.Add(this.groupBox_Pattern1);
            this.panel_Pattern_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Pattern_Content.Location = new System.Drawing.Point(3, 38);
            this.panel_Pattern_Content.Name = "panel_Pattern_Content";
            this.panel_Pattern_Content.Size = new System.Drawing.Size(1191, 102);
            this.panel_Pattern_Content.TabIndex = 1;
            // 
            // groupBox_Pattern2
            // 
            this.groupBox_Pattern2.Controls.Add(this.numericUpDow_SleepTime);
            this.groupBox_Pattern2.Controls.Add(this.numericUpDown_MutiThread);
            this.groupBox_Pattern2.Controls.Add(this.numericUpDown_Time);
            this.groupBox_Pattern2.Controls.Add(this.label_ThreadTime);
            this.groupBox_Pattern2.Controls.Add(this.label_MutiTheard);
            this.groupBox_Pattern2.Controls.Add(this.label_Time);
            this.groupBox_Pattern2.Location = new System.Drawing.Point(30, 12);
            this.groupBox_Pattern2.Name = "groupBox_Pattern2";
            this.groupBox_Pattern2.Size = new System.Drawing.Size(978, 94);
            this.groupBox_Pattern2.TabIndex = 1;
            this.groupBox_Pattern2.TabStop = false;
            // 
            // label_ThreadTime
            // 
            this.label_ThreadTime.AutoSize = true;
            this.label_ThreadTime.Location = new System.Drawing.Point(554, 34);
            this.label_ThreadTime.Name = "label_ThreadTime";
            this.label_ThreadTime.Size = new System.Drawing.Size(166, 24);
            this.label_ThreadTime.TabIndex = 5;
            this.label_ThreadTime.Text = "请求间隔时间(秒)：";
            // 
            // label_MutiTheard
            // 
            this.label_MutiTheard.AutoSize = true;
            this.label_MutiTheard.Location = new System.Drawing.Point(337, 34);
            this.label_MutiTheard.Name = "label_MutiTheard";
            this.label_MutiTheard.Size = new System.Drawing.Size(82, 24);
            this.label_MutiTheard.TabIndex = 6;
            this.label_MutiTheard.Text = "线程数：";
            // 
            // label_Time
            // 
            this.label_Time.AutoSize = true;
            this.label_Time.Location = new System.Drawing.Point(97, 35);
            this.label_Time.Name = "label_Time";
            this.label_Time.Size = new System.Drawing.Size(80, 24);
            this.label_Time.TabIndex = 7;
            this.label_Time.Text = "时间(分):";
            // 
            // groupBox_Pattern1
            // 
            this.groupBox_Pattern1.Controls.Add(this.numericUpDown_Quantity);
            this.groupBox_Pattern1.Controls.Add(this.label1);
            this.groupBox_Pattern1.Location = new System.Drawing.Point(30, 112);
            this.groupBox_Pattern1.Name = "groupBox_Pattern1";
            this.groupBox_Pattern1.Size = new System.Drawing.Size(978, 109);
            this.groupBox_Pattern1.TabIndex = 0;
            this.groupBox_Pattern1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "数量：";
            // 
            // panel_Pattern_Head
            // 
            this.panel_Pattern_Head.Controls.Add(this.radioButton2);
            this.panel_Pattern_Head.Controls.Add(this.radioButton1);
            this.panel_Pattern_Head.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Pattern_Head.Location = new System.Drawing.Point(3, 3);
            this.panel_Pattern_Head.Name = "panel_Pattern_Head";
            this.panel_Pattern_Head.Size = new System.Drawing.Size(1191, 35);
            this.panel_Pattern_Head.TabIndex = 0;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(246, 3);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(71, 28);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "时间";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Click += new System.EventHandler(this.radioButton2_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(67, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(71, 28);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "数量";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // tabPage_EventHubName
            // 
            this.tabPage_EventHubName.Controls.Add(this.textBox_EventHubName);
            this.tabPage_EventHubName.Controls.Add(this.label_EnventHubName);
            this.tabPage_EventHubName.Location = new System.Drawing.Point(4, 33);
            this.tabPage_EventHubName.Name = "tabPage_EventHubName";
            this.tabPage_EventHubName.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_EventHubName.Size = new System.Drawing.Size(1197, 143);
            this.tabPage_EventHubName.TabIndex = 1;
            this.tabPage_EventHubName.Text = "名字";
            this.tabPage_EventHubName.UseVisualStyleBackColor = true;
            // 
            // textBox_EventHubName
            // 
            this.textBox_EventHubName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_EventHubName.Location = new System.Drawing.Point(183, 46);
            this.textBox_EventHubName.Multiline = true;
            this.textBox_EventHubName.Name = "textBox_EventHubName";
            this.textBox_EventHubName.Size = new System.Drawing.Size(302, 32);
            this.textBox_EventHubName.TabIndex = 5;
            // 
            // label_EnventHubName
            // 
            this.label_EnventHubName.AutoSize = true;
            this.label_EnventHubName.Location = new System.Drawing.Point(35, 50);
            this.label_EnventHubName.Name = "label_EnventHubName";
            this.label_EnventHubName.Size = new System.Drawing.Size(153, 24);
            this.label_EnventHubName.TabIndex = 4;
            this.label_EnventHubName.Text = "EventHub 名字：";
            // 
            // textBox_Body
            // 
            this.textBox_Body.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Body.Location = new System.Drawing.Point(0, 0);
            this.textBox_Body.Multiline = true;
            this.textBox_Body.Name = "textBox_Body";
            this.textBox_Body.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_Body.Size = new System.Drawing.Size(1197, 143);
            this.textBox_Body.TabIndex = 0;
            // 
            // richTextBox_Log
            // 
            this.richTextBox_Log.BackColor = System.Drawing.Color.Black;
            this.richTextBox_Log.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox_Log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_Log.ForeColor = System.Drawing.Color.White;
            this.richTextBox_Log.Location = new System.Drawing.Point(0, 37);
            this.richTextBox_Log.Name = "richTextBox_Log";
            this.richTextBox_Log.Size = new System.Drawing.Size(1211, 265);
            this.richTextBox_Log.TabIndex = 1;
            this.richTextBox_Log.Text = "";
            // 
            // numericUpDown_Time
            // 
            this.numericUpDown_Time.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown_Time.Location = new System.Drawing.Point(186, 34);
            this.numericUpDown_Time.Name = "numericUpDown_Time";
            this.numericUpDown_Time.Size = new System.Drawing.Size(101, 26);
            this.numericUpDown_Time.TabIndex = 11;
            this.numericUpDown_Time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_Time.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_MutiThread
            // 
            this.numericUpDown_MutiThread.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown_MutiThread.Location = new System.Drawing.Point(425, 33);
            this.numericUpDown_MutiThread.Name = "numericUpDown_MutiThread";
            this.numericUpDown_MutiThread.Size = new System.Drawing.Size(100, 26);
            this.numericUpDown_MutiThread.TabIndex = 12;
            this.numericUpDown_MutiThread.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_MutiThread.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDow_SleepTime
            // 
            this.numericUpDow_SleepTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDow_SleepTime.Location = new System.Drawing.Point(725, 34);
            this.numericUpDow_SleepTime.Name = "numericUpDow_SleepTime";
            this.numericUpDow_SleepTime.Size = new System.Drawing.Size(92, 26);
            this.numericUpDow_SleepTime.TabIndex = 13;
            this.numericUpDow_SleepTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDown_Quantity
            // 
            this.numericUpDown_Quantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown_Quantity.Location = new System.Drawing.Point(185, 38);
            this.numericUpDown_Quantity.Name = "numericUpDown_Quantity";
            this.numericUpDown_Quantity.Size = new System.Drawing.Size(98, 26);
            this.numericUpDown_Quantity.TabIndex = 3;
            this.numericUpDown_Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_Quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ECOLAB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 620);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.panel_Request);
            this.Controls.Add(this.panel_Response);
            this.Name = "ECOLAB";
            this.Text = "ECOLAB.IOT.EventHubSender";
            this.Load += new System.EventHandler(this.ECOLAB_Load);
            this.Resize += new System.EventHandler(this.ECOLAB_Resize);
            this.panel_Request.ResumeLayout(false);
            this.groupBox_Request.ResumeLayout(false);
            this.panel_EventHubConn.ResumeLayout(false);
            this.panel_EventHubConn.PerformLayout();
            this.panel_Response.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_Body.ResumeLayout(false);
            this.tabPage_Body.PerformLayout();
            this.tabPage_Pattern.ResumeLayout(false);
            this.panel_Pattern_Content.ResumeLayout(false);
            this.groupBox_Pattern2.ResumeLayout(false);
            this.groupBox_Pattern2.PerformLayout();
            this.groupBox_Pattern1.ResumeLayout(false);
            this.groupBox_Pattern1.PerformLayout();
            this.panel_Pattern_Head.ResumeLayout(false);
            this.panel_Pattern_Head.PerformLayout();
            this.tabPage_EventHubName.ResumeLayout(false);
            this.tabPage_EventHubName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Time)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MutiThread)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDow_SleepTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Quantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel_Request;
        private GroupBox groupBox_Request;
        private Panel panel_EventHubConn;
        private Button button_Send;
        private TextBox textBox_ConnectionString;
        private Label label_EventhubConn;
        private Splitter splitter1;
        private Panel panel_Response;
        private Label label_Response;
        private Splitter splitter2;
        private TabControl tabControl1;
        private TabPage tabPage_Pattern;
        private Panel panel_Pattern_Content;
        private GroupBox groupBox_Pattern2;
        private Label label_ThreadTime;
        private Label label_MutiTheard;
        private Label label_Time;
        private GroupBox groupBox_Pattern1;
        private Label label1;
        private Panel panel_Pattern_Head;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TabPage tabPage_EventHubName;
        private TextBox textBox_EventHubName;
        private Label label_EnventHubName;
        private TabPage tabPage_Body;
        private TextBox textBox_Body;
        private RichTextBox richTextBox_Log;
        private NumericUpDown numericUpDown_Time;
        private NumericUpDown numericUpDow_SleepTime;
        private NumericUpDown numericUpDown_MutiThread;
        private NumericUpDown numericUpDown_Quantity;
    }
}
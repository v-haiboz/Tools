namespace ECOLAB.IOT.EventHubReceiver
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_Listener = new System.Windows.Forms.Button();
            this.textBox_ConsumerGroup = new System.Windows.Forms.TextBox();
            this.textBox_EventHubName = new System.Windows.Forms.TextBox();
            this.richTextBox_ConnectionString = new System.Windows.Forms.RichTextBox();
            this.label_ConnectionString = new System.Windows.Forms.Label();
            this.label_ConsumerGroup = new System.Windows.Forms.Label();
            this.label_EventHubName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1096, 604);
            this.splitContainer1.SplitterDistance = 274;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_Listener);
            this.groupBox2.Controls.Add(this.textBox_ConsumerGroup);
            this.groupBox2.Controls.Add(this.textBox_EventHubName);
            this.groupBox2.Controls.Add(this.richTextBox_ConnectionString);
            this.groupBox2.Controls.Add(this.label_ConnectionString);
            this.groupBox2.Controls.Add(this.label_ConsumerGroup);
            this.groupBox2.Controls.Add(this.label_EventHubName);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1096, 274);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Event Hub配置：";
            // 
            // button_Listener
            // 
            this.button_Listener.BackColor = System.Drawing.Color.Green;
            this.button_Listener.Location = new System.Drawing.Point(883, 85);
            this.button_Listener.Name = "button_Listener";
            this.button_Listener.Size = new System.Drawing.Size(112, 58);
            this.button_Listener.TabIndex = 9;
            this.button_Listener.Text = "开始监听";
            this.button_Listener.UseVisualStyleBackColor = false;
            this.button_Listener.Click += new System.EventHandler(this.button_Listener_Click);
            // 
            // textBox_ConsumerGroup
            // 
            this.textBox_ConsumerGroup.Location = new System.Drawing.Point(203, 192);
            this.textBox_ConsumerGroup.Name = "textBox_ConsumerGroup";
            this.textBox_ConsumerGroup.Size = new System.Drawing.Size(292, 30);
            this.textBox_ConsumerGroup.TabIndex = 8;
            // 
            // textBox_EventHubName
            // 
            this.textBox_EventHubName.Location = new System.Drawing.Point(203, 146);
            this.textBox_EventHubName.Name = "textBox_EventHubName";
            this.textBox_EventHubName.Size = new System.Drawing.Size(292, 30);
            this.textBox_EventHubName.TabIndex = 7;
            // 
            // richTextBox_ConnectionString
            // 
            this.richTextBox_ConnectionString.BackColor = System.Drawing.Color.White;
            this.richTextBox_ConnectionString.Location = new System.Drawing.Point(203, 33);
            this.richTextBox_ConnectionString.Name = "richTextBox_ConnectionString";
            this.richTextBox_ConnectionString.Size = new System.Drawing.Size(631, 93);
            this.richTextBox_ConnectionString.TabIndex = 6;
            this.richTextBox_ConnectionString.Text = "";
            // 
            // label_ConnectionString
            // 
            this.label_ConnectionString.AutoSize = true;
            this.label_ConnectionString.Location = new System.Drawing.Point(30, 52);
            this.label_ConnectionString.Name = "label_ConnectionString";
            this.label_ConnectionString.Size = new System.Drawing.Size(167, 24);
            this.label_ConnectionString.TabIndex = 3;
            this.label_ConnectionString.Text = "Connection string:";
            // 
            // label_ConsumerGroup
            // 
            this.label_ConsumerGroup.AutoSize = true;
            this.label_ConsumerGroup.Location = new System.Drawing.Point(38, 191);
            this.label_ConsumerGroup.Name = "label_ConsumerGroup";
            this.label_ConsumerGroup.Size = new System.Drawing.Size(159, 24);
            this.label_ConsumerGroup.TabIndex = 5;
            this.label_ConsumerGroup.Text = "Consumer group:";
            // 
            // label_EventHubName
            // 
            this.label_EventHubName.AutoSize = true;
            this.label_EventHubName.Location = new System.Drawing.Point(118, 152);
            this.label_EventHubName.Name = "label_EventHubName";
            this.label_EventHubName.Size = new System.Drawing.Size(66, 24);
            this.label_EventHubName.TabIndex = 4;
            this.label_EventHubName.Text = "Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1096, 326);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "接收区：";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 26);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(1090, 297);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 604);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "ECOLAB.IOT.Receiver";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private GroupBox groupBox2;
        private Button button_Listener;
        private TextBox textBox_ConsumerGroup;
        private TextBox textBox_EventHubName;
        private RichTextBox richTextBox_ConnectionString;
        private Label label_ConnectionString;
        private Label label_ConsumerGroup;
        private Label label_EventHubName;
        private GroupBox groupBox1;
        private RichTextBox richTextBox1;
    }
}
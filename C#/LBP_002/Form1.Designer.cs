namespace LBP_002
{
    partial class panel1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(panel1));
            this.left_panel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.On_btn = new System.Windows.Forms.PictureBox();
            this.OFF_btn = new System.Windows.Forms.PictureBox();
            this.fized_v = new System.Windows.Forms.GroupBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Fixed_V = new System.Windows.Forms.GroupBox();
            this.m_PushGraph = new CustomUIControls.Graphing.C2DPushGraph();
            this.label22 = new System.Windows.Forms.Label();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.NFixed_V = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.amp_trackBar = new System.Windows.Forms.TrackBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.aGauge4 = new AGaugeApp.AGauge();
            this.Degree_label = new System.Windows.Forms.Label();
            this.Val_trackBar = new System.Windows.Forms.TrackBar();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.dezhurka_text = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.left_panel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.On_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OFF_btn)).BeginInit();
            this.fized_v.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.Fixed_V.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            this.NFixed_V.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amp_trackBar)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Val_trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // left_panel
            // 
            this.left_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.left_panel.Controls.Add(this.panel2);
            this.left_panel.Controls.Add(this.fized_v);
            this.left_panel.Controls.Add(this.groupBox2);
            this.left_panel.Controls.Add(this.groupBox1);
            this.left_panel.Location = new System.Drawing.Point(0, 0);
            this.left_panel.Name = "left_panel";
            this.left_panel.Size = new System.Drawing.Size(250, 706);
            this.left_panel.TabIndex = 0;
            this.left_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.left_panel_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(248, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(26, 708);
            this.panel2.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Font = new System.Drawing.Font("Matura MT Script Capitals", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(12, 508);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 80);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ОСВЕЩЕНИЕ";
            this.groupBox2.Visible = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(42, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 50);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.Location = new System.Drawing.Point(127, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.On_btn);
            this.groupBox1.Controls.Add(this.OFF_btn);
            this.groupBox1.Font = new System.Drawing.Font("Matura MT Script Capitals", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(12, 603);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 80);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ПИТАНИЕ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // On_btn
            // 
            this.On_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("On_btn.BackgroundImage")));
            this.On_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.On_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.On_btn.Location = new System.Drawing.Point(41, 22);
            this.On_btn.Name = "On_btn";
            this.On_btn.Size = new System.Drawing.Size(51, 50);
            this.On_btn.TabIndex = 3;
            this.On_btn.TabStop = false;
            this.On_btn.Click += new System.EventHandler(this.On_btn_Click);
            // 
            // OFF_btn
            // 
            this.OFF_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OFF_btn.BackgroundImage")));
            this.OFF_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OFF_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.OFF_btn.Location = new System.Drawing.Point(127, 22);
            this.OFF_btn.Name = "OFF_btn";
            this.OFF_btn.Size = new System.Drawing.Size(50, 50);
            this.OFF_btn.TabIndex = 4;
            this.OFF_btn.TabStop = false;
            this.OFF_btn.Click += new System.EventHandler(this.OFF_btn_Click);
            // 
            // fized_v
            // 
            this.fized_v.BackColor = System.Drawing.Color.Transparent;
            this.fized_v.Controls.Add(this.pictureBox10);
            this.fized_v.Controls.Add(this.pictureBox3);
            this.fized_v.Font = new System.Drawing.Font("Matura MT Script Capitals", 12F, System.Drawing.FontStyle.Bold);
            this.fized_v.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.fized_v.Location = new System.Drawing.Point(12, 424);
            this.fized_v.Name = "fized_v";
            this.fized_v.Size = new System.Drawing.Size(220, 80);
            this.fized_v.TabIndex = 25;
            this.fized_v.TabStop = false;
            this.fized_v.Text = "Фиксированные V+";
            this.fized_v.Visible = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(55, 28);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(37, 38);
            this.pictureBox10.TabIndex = 24;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Click += new System.EventHandler(this.pictureBox10_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(138, 28);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 38);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.DarkRed;
            this.label9.Location = new System.Drawing.Point(20, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 22);
            this.label9.TabIndex = 14;
            this.label9.Text = "5";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(38, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "4";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Fixed_V
            // 
            this.Fixed_V.BackColor = System.Drawing.Color.Transparent;
            this.Fixed_V.Controls.Add(this.label2);
            this.Fixed_V.Controls.Add(this.m_PushGraph);
            this.Fixed_V.Controls.Add(this.label22);
            this.Fixed_V.Controls.Add(this.trackBar3);
            this.Fixed_V.Controls.Add(this.label21);
            this.Fixed_V.Controls.Add(this.label20);
            this.Fixed_V.Controls.Add(this.label1);
            this.Fixed_V.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.Fixed_V.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Fixed_V.Location = new System.Drawing.Point(301, 424);
            this.Fixed_V.Name = "Fixed_V";
            this.Fixed_V.Size = new System.Drawing.Size(713, 259);
            this.Fixed_V.TabIndex = 7;
            this.Fixed_V.TabStop = false;
            this.Fixed_V.Text = "ФИКСИРОВАННЫЕ НАПРЯЖЕНИЯ";
            this.Fixed_V.Visible = false;
            this.Fixed_V.Enter += new System.EventHandler(this.Fixed_V_Enter);
            // 
            // m_PushGraph
            // 
            this.m_PushGraph.AutoAdjustPeek = false;
            this.m_PushGraph.BackColor = System.Drawing.Color.Black;
            this.m_PushGraph.GridColor = System.Drawing.Color.Green;
            this.m_PushGraph.GridSize = ((ushort)(20));
            this.m_PushGraph.HighQuality = true;
            this.m_PushGraph.LineInterval = ((ushort)(5));
            this.m_PushGraph.Location = new System.Drawing.Point(389, 68);
            this.m_PushGraph.MaxLabel = "5 Amp.";
            this.m_PushGraph.MaxPeekMagnitude = 100;
            this.m_PushGraph.MinLabel = "0 Amp.";
            this.m_PushGraph.MinPeekMagnitude = 0;
            this.m_PushGraph.Name = "m_PushGraph";
            this.m_PushGraph.ShowGrid = true;
            this.m_PushGraph.ShowLabels = true;
            this.m_PushGraph.Size = new System.Drawing.Size(251, 135);
            this.m_PushGraph.TabIndex = 7;
            this.m_PushGraph.Text = "m_PushGraph";
            this.m_PushGraph.TextColor = System.Drawing.Color.Yellow;
            this.m_PushGraph.Click += new System.EventHandler(this.c2DPushGraph1_Click);
            // 
            // label22
            // 
            this.label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label22.Font = new System.Drawing.Font("Algerian", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.LightGray;
            this.label22.Location = new System.Drawing.Point(222, 157);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(151, 46);
            this.label22.TabIndex = 28;
            this.label22.Text = "+24 V";
            this.label22.Click += new System.EventHandler(this.label22_Click);
            // 
            // trackBar3
            // 
            this.trackBar3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.trackBar3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.trackBar3.LargeChange = 10;
            this.trackBar3.Location = new System.Drawing.Point(662, 55);
            this.trackBar3.Maximum = 767;
            this.trackBar3.Minimum = 512;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar3.Size = new System.Drawing.Size(45, 170);
            this.trackBar3.TabIndex = 18;
            this.trackBar3.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar3.Value = 512;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // label21
            // 
            this.label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label21.Font = new System.Drawing.Font("Algerian", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.LightGray;
            this.label21.Location = new System.Drawing.Point(31, 157);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(151, 46);
            this.label21.TabIndex = 27;
            this.label21.Text = "+12 V";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // label20
            // 
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label20.Font = new System.Drawing.Font("Algerian", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.LightGray;
            this.label20.Location = new System.Drawing.Point(30, 68);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(151, 46);
            this.label20.TabIndex = 26;
            this.label20.Text = "+3.3 V";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Algerian", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(222, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 46);
            this.label1.TabIndex = 19;
            this.label1.Text = "+5.0 V";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(23, 140);
            this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(307, 148);
            this.zedGraphControl1.TabIndex = 0;
            this.zedGraphControl1.Load += new System.EventHandler(this.zedGraphControl1_Load);
            // 
            // NFixed_V
            // 
            this.NFixed_V.BackColor = System.Drawing.Color.Transparent;
            this.NFixed_V.Controls.Add(this.label17);
            this.NFixed_V.Controls.Add(this.amp_trackBar);
            this.NFixed_V.Controls.Add(this.groupBox3);
            this.NFixed_V.Controls.Add(this.Degree_label);
            this.NFixed_V.Controls.Add(this.Val_trackBar);
            this.NFixed_V.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.NFixed_V.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NFixed_V.Location = new System.Drawing.Point(301, 57);
            this.NFixed_V.Name = "NFixed_V";
            this.NFixed_V.Size = new System.Drawing.Size(774, 350);
            this.NFixed_V.TabIndex = 8;
            this.NFixed_V.TabStop = false;
            this.NFixed_V.Text = "НАПРЯЖЕНИЯ ОТ 0.5 - 21В";
            this.NFixed_V.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label17.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label17.Location = new System.Drawing.Point(660, 308);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 24);
            this.label17.TabIndex = 12;
            this.label17.Text = "АМПЕР";
            // 
            // amp_trackBar
            // 
            this.amp_trackBar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.amp_trackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.amp_trackBar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.amp_trackBar.LargeChange = 1;
            this.amp_trackBar.Location = new System.Drawing.Point(601, 26);
            this.amp_trackBar.Maximum = 255;
            this.amp_trackBar.Name = "amp_trackBar";
            this.amp_trackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.amp_trackBar.Size = new System.Drawing.Size(45, 272);
            this.amp_trackBar.TabIndex = 10;
            this.amp_trackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.amp_trackBar.Scroll += new System.EventHandler(this.amp_trackBar_Scroll);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button8);
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.zedGraphControl1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.aGauge4);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(30, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(534, 306);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Показатели";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label19
            // 
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label19.Font = new System.Drawing.Font("Algerian", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.Info;
            this.label19.Location = new System.Drawing.Point(342, 87);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(165, 46);
            this.label19.TabIndex = 18;
            this.label19.Text = "V: 0.65";
            // 
            // label18
            // 
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label18.Font = new System.Drawing.Font("Algerian", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.Info;
            this.label18.Location = new System.Drawing.Point(336, 20);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(171, 46);
            this.label18.TabIndex = 17;
            this.label18.Text = "A: 0.65";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label10.Location = new System.Drawing.Point(119, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Амперметр";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.ForestGreen;
            this.label8.Location = new System.Drawing.Point(194, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 24);
            this.label8.TabIndex = 13;
            this.label8.Text = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Goldenrod;
            this.label7.Location = new System.Drawing.Point(119, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "2";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Goldenrod;
            this.label6.Location = new System.Drawing.Point(65, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.ForestGreen;
            this.label4.Location = new System.Drawing.Point(267, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "0";
            // 
            // aGauge4
            // 
            this.aGauge4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.aGauge4.BaseArcColor = System.Drawing.SystemColors.InfoText;
            this.aGauge4.BaseArcRadius = 150;
            this.aGauge4.BaseArcStart = 215;
            this.aGauge4.BaseArcSweep = 110;
            this.aGauge4.BaseArcWidth = 2;
            this.aGauge4.Cap_Idx = ((byte)(1));
            this.aGauge4.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge4.CapPosition = new System.Drawing.Point(10, 10);
            this.aGauge4.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge4.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.aGauge4.CapText = "";
            this.aGauge4.Center = new System.Drawing.Point(150, 180);
            this.aGauge4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.aGauge4.Location = new System.Drawing.Point(19, 23);
            this.aGauge4.MaxValue = 1023F;
            this.aGauge4.MinValue = 0F;
            this.aGauge4.Name = "aGauge4";
            this.aGauge4.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Red;
            this.aGauge4.NeedleColor2 = System.Drawing.Color.White;
            this.aGauge4.NeedleRadius = 150;
            this.aGauge4.NeedleType = 1;
            this.aGauge4.NeedleWidth = 4;
            this.aGauge4.Range_Idx = ((byte)(1));
            this.aGauge4.RangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.aGauge4.RangeEnabled = true;
            this.aGauge4.RangeEndValue = 10F;
            this.aGauge4.RangeInnerRadius = 10;
            this.aGauge4.RangeOuterRadius = 40;
            this.aGauge4.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge4.RangesEnabled = new bool[] {
        false,
        true,
        false,
        false,
        false};
            this.aGauge4.RangesEndValue = new float[] {
        300F,
        10F,
        0F,
        0F,
        0F};
            this.aGauge4.RangesInnerRadius = new int[] {
        70,
        10,
        70,
        70,
        70};
            this.aGauge4.RangesOuterRadius = new int[] {
        80,
        40,
        80,
        80,
        80};
            this.aGauge4.RangesStartValue = new float[] {
        -100F,
        0F,
        0F,
        0F,
        0F};
            this.aGauge4.RangeStartValue = 0F;
            this.aGauge4.ScaleLinesInterColor = System.Drawing.Color.DimGray;
            this.aGauge4.ScaleLinesInterInnerRadius = 145;
            this.aGauge4.ScaleLinesInterOuterRadius = 150;
            this.aGauge4.ScaleLinesInterWidth = 1;
            this.aGauge4.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge4.ScaleLinesMajorInnerRadius = 140;
            this.aGauge4.ScaleLinesMajorOuterRadius = 150;
            this.aGauge4.ScaleLinesMajorStepValue = 100F;
            this.aGauge4.ScaleLinesMajorWidth = 2;
            this.aGauge4.ScaleLinesMinorColor = System.Drawing.Color.Maroon;
            this.aGauge4.ScaleLinesMinorInnerRadius = 145;
            this.aGauge4.ScaleLinesMinorNumOf = 1;
            this.aGauge4.ScaleLinesMinorOuterRadius = 150;
            this.aGauge4.ScaleLinesMinorWidth = 1;
            this.aGauge4.ScaleNumbersColor = System.Drawing.Color.Transparent;
            this.aGauge4.ScaleNumbersFormat = "";
            this.aGauge4.ScaleNumbersRadius = 162;
            this.aGauge4.ScaleNumbersRotation = 90;
            this.aGauge4.ScaleNumbersStartScaleLine = 1;
            this.aGauge4.ScaleNumbersStepScaleLines = 2;
            this.aGauge4.Size = new System.Drawing.Size(311, 110);
            this.aGauge4.TabIndex = 8;
            this.aGauge4.Text = "aGauge4";
            this.aGauge4.Value = 0F;
            this.aGauge4.ValueInRangeChanged += new AGaugeApp.AGauge.ValueInRangeChangedDelegate(this.aGauge4_ValueInRangeChanged);
            // 
            // Degree_label
            // 
            this.Degree_label.AutoSize = true;
            this.Degree_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Degree_label.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Degree_label.Location = new System.Drawing.Point(570, 308);
            this.Degree_label.Name = "Degree_label";
            this.Degree_label.Size = new System.Drawing.Size(76, 24);
            this.Degree_label.TabIndex = 5;
            this.Degree_label.Text = "ВОЛЬТ";
            this.Degree_label.Click += new System.EventHandler(this.Degree_label_Click);
            // 
            // Val_trackBar
            // 
            this.Val_trackBar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Val_trackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Val_trackBar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Val_trackBar.LargeChange = 1;
            this.Val_trackBar.Location = new System.Drawing.Point(687, 26);
            this.Val_trackBar.Maximum = 511;
            this.Val_trackBar.Minimum = 257;
            this.Val_trackBar.Name = "Val_trackBar";
            this.Val_trackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Val_trackBar.Size = new System.Drawing.Size(45, 272);
            this.Val_trackBar.TabIndex = 2;
            this.Val_trackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Val_trackBar.Value = 257;
            this.Val_trackBar.Scroll += new System.EventHandler(this.Val_trackBar_Scroll);
            // 
            // dezhurka_text
            // 
            this.dezhurka_text.AutoSize = true;
            this.dezhurka_text.BackColor = System.Drawing.Color.Transparent;
            this.dezhurka_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dezhurka_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.dezhurka_text.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.dezhurka_text.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dezhurka_text.Location = new System.Drawing.Point(571, 7);
            this.dezhurka_text.Name = "dezhurka_text";
            this.dezhurka_text.Size = new System.Drawing.Size(252, 31);
            this.dezhurka_text.TabIndex = 9;
            this.dezhurka_text.Text = "ДЕЖУРНЫЙ РЕЖИМ\r\n";
            this.dezhurka_text.Click += new System.EventHandler(this.dezhurka_text_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(248, 702);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1022, 10);
            this.panel3.TabIndex = 10;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(630, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "АМПЕР";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(423, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 30);
            this.button1.TabIndex = 19;
            this.button1.Text = "3.3V";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(342, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 30);
            this.button2.TabIndex = 20;
            this.button2.Text = "1.45V";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(342, 187);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(69, 30);
            this.button3.TabIndex = 21;
            this.button3.Text = "5.0V";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.ForeColor = System.Drawing.Color.Transparent;
            this.button4.Location = new System.Drawing.Point(423, 187);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(69, 30);
            this.button4.TabIndex = 22;
            this.button4.Text = "9.0V";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.ForeColor = System.Drawing.Color.Transparent;
            this.button5.Location = new System.Drawing.Point(342, 223);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(69, 30);
            this.button5.TabIndex = 23;
            this.button5.Text = "12.0V";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.ForeColor = System.Drawing.Color.Transparent;
            this.button6.Location = new System.Drawing.Point(423, 223);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(69, 30);
            this.button6.TabIndex = 24;
            this.button6.Text = "18.5V";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button7.ForeColor = System.Drawing.Color.Transparent;
            this.button7.Location = new System.Drawing.Point(342, 259);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(69, 30);
            this.button7.TabIndex = 25;
            this.button7.Text = "19.5V";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button8.ForeColor = System.Drawing.Color.Transparent;
            this.button8.Location = new System.Drawing.Point(423, 258);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(69, 30);
            this.button8.TabIndex = 26;
            this.button8.Text = "22.9V";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // panel1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1092, 704);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dezhurka_text);
            this.Controls.Add(this.NFixed_V);
            this.Controls.Add(this.Fixed_V);
            this.Controls.Add(this.left_panel);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.MaximizeBox = false;
            this.Name = "panel1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ЛАБОРАТОРНЫЙ БЛОК ПИТАНИЯ";
            this.Load += new System.EventHandler(this.panel1_Load);
            this.left_panel.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.On_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OFF_btn)).EndInit();
            this.fized_v.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.Fixed_V.ResumeLayout(false);
            this.Fixed_V.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            this.NFixed_V.ResumeLayout(false);
            this.NFixed_V.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amp_trackBar)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Val_trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel left_panel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox On_btn;
        private System.Windows.Forms.PictureBox OFF_btn;
        private System.Windows.Forms.GroupBox Fixed_V;
        private System.Windows.Forms.GroupBox NFixed_V;
        private System.Windows.Forms.Label Degree_label;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label dezhurka_text;
        private CustomUIControls.Graphing.C2DPushGraph m_PushGraph;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private AGaugeApp.AGauge aGauge4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TrackBar Val_trackBar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TrackBar amp_trackBar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.GroupBox fized_v;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}


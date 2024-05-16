namespace EdgeDetection
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.button_open_thr = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.label_resultOtsu = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox_value = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar_value = new System.Windows.Forms.TrackBar();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox_questionMark1 = new System.Windows.Forms.PictureBox();
            this.threshold_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.histogramPictureBox = new System.Windows.Forms.PictureBox();
            this.Get_histogram = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToTemplatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.effectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertToGreyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gaussianBlur3x3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gaussianBlur5x5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boxBlurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sharpImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sharpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unsharpMaskingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button3 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.labelR = new System.Windows.Forms.Label();
            this.trackBarB = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBarG = new System.Windows.Forms.TrackBar();
            this.trackBarR = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControlGlobal = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label31 = new System.Windows.Forms.Label();
            this.button16 = new System.Windows.Forms.Button();
            this.pictureBoxEyePrewitt = new System.Windows.Forms.PictureBox();
            this.button10 = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.pictureBoxEyeSobel55 = new System.Windows.Forms.PictureBox();
            this.label21 = new System.Windows.Forms.Label();
            this.pictureBoxEyeSobel33 = new System.Windows.Forms.PictureBox();
            this.button9 = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.pictureBoxEye5 = new System.Windows.Forms.PictureBox();
            this.button15 = new System.Windows.Forms.Button();
            this.label30 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.button14 = new System.Windows.Forms.Button();
            this.label29 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.pictureBoxEye4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxEye3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxEye2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxEye1 = new System.Windows.Forms.PictureBox();
            this.tabPage12 = new System.Windows.Forms.TabPage();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.trackBarBlur = new System.Windows.Forms.TrackBar();
            this.button6 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.button7 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.dToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPicture = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.tabControl.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_value)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_questionMark1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.histogramPictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarR)).BeginInit();
            this.tabControlGlobal.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEyePrewitt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEyeSobel55)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEyeSobel33)).BeginInit();
            this.tabPage10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEye5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEye4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEye3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEye2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEye1)).BeginInit();
            this.tabPage7.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlur)).BeginInit();
            this.tabPage9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose picture from templates:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button_open_thr
            // 
            this.button_open_thr.Location = new System.Drawing.Point(522, 59);
            this.button_open_thr.Name = "button_open_thr";
            this.button_open_thr.Size = new System.Drawing.Size(123, 23);
            this.button_open_thr.TabIndex = 10;
            this.button_open_thr.Text = "Hide tabcontrol";
            this.button_open_thr.UseVisualStyleBackColor = true;
            this.button_open_thr.Click += new System.EventHandler(this.button_open_rgb_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Location = new System.Drawing.Point(2, 2);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(394, 294);
            this.tabControl.TabIndex = 11;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button5);
            this.tabPage4.Controls.Add(this.label_resultOtsu);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.button4);
            this.tabPage4.Controls.Add(this.textBox_value);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.trackBar_value);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(386, 268);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Global ans otsu";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(250, 188);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(122, 19);
            this.button5.TabIndex = 13;
            this.button5.Text = "Show Diagram";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // label_resultOtsu
            // 
            this.label_resultOtsu.AutoSize = true;
            this.label_resultOtsu.Location = new System.Drawing.Point(24, 225);
            this.label_resultOtsu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_resultOtsu.Name = "label_resultOtsu";
            this.label_resultOtsu.Size = new System.Drawing.Size(63, 13);
            this.label_resultOtsu.TabIndex = 12;
            this.label_resultOtsu.Text = "Best value: ";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(16, 166);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(367, 20);
            this.label13.TabIndex = 11;
            this.label13.Text = "Find the optimal value for global thresholding. Optimizing the iner-class varianc" +
    "e. ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(21, 137);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 17);
            this.label12.TabIndex = 10;
            this.label12.Text = "Otsu thresholding:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(24, 188);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(69, 19);
            this.button4.TabIndex = 9;
            this.button4.Text = "Calculate";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_2);
            // 
            // textBox_value
            // 
            this.textBox_value.Enabled = false;
            this.textBox_value.Location = new System.Drawing.Point(92, 102);
            this.textBox_value.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_value.Name = "textBox_value";
            this.textBox_value.Size = new System.Drawing.Size(76, 20);
            this.textBox_value.TabIndex = 8;
            this.textBox_value.Text = "122";
            this.textBox_value.TextChanged += new System.EventHandler(this.textBox_value_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 104);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Current value: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(21, 11);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "Global thresholding:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(285, 76);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "255";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "0";
            // 
            // trackBar_value
            // 
            this.trackBar_value.Location = new System.Drawing.Point(38, 44);
            this.trackBar_value.Margin = new System.Windows.Forms.Padding(2);
            this.trackBar_value.Maximum = 255;
            this.trackBar_value.Name = "trackBar_value";
            this.trackBar_value.Size = new System.Drawing.Size(268, 45);
            this.trackBar_value.TabIndex = 1;
            this.trackBar_value.Value = 122;
            this.trackBar_value.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox_questionMark1);
            this.tabPage2.Controls.Add(this.threshold_btn);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(386, 268);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Adaptive threshold";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox_questionMark1
            // 
            this.pictureBox_questionMark1.Location = new System.Drawing.Point(340, 14);
            this.pictureBox_questionMark1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_questionMark1.Name = "pictureBox_questionMark1";
            this.pictureBox_questionMark1.Size = new System.Drawing.Size(21, 24);
            this.pictureBox_questionMark1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_questionMark1.TabIndex = 5;
            this.pictureBox_questionMark1.TabStop = false;
            // 
            // threshold_btn
            // 
            this.threshold_btn.Location = new System.Drawing.Point(100, 125);
            this.threshold_btn.Margin = new System.Windows.Forms.Padding(2);
            this.threshold_btn.Name = "threshold_btn";
            this.threshold_btn.Size = new System.Drawing.Size(56, 19);
            this.threshold_btn.TabIndex = 4;
            this.threshold_btn.Text = "apply";
            this.threshold_btn.UseVisualStyleBackColor = true;
            this.threshold_btn.Click += new System.EventHandler(this.threshold_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 88);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "b";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 50);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "a";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(100, 83);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(76, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 45);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.histogramPictureBox);
            this.tabPage3.Controls.Add(this.Get_histogram);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(386, 268);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "--old--";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // histogramPictureBox
            // 
            this.histogramPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.histogramPictureBox.Location = new System.Drawing.Point(23, 115);
            this.histogramPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.histogramPictureBox.Name = "histogramPictureBox";
            this.histogramPictureBox.Size = new System.Drawing.Size(239, 114);
            this.histogramPictureBox.TabIndex = 7;
            this.histogramPictureBox.TabStop = false;
            // 
            // Get_histogram
            // 
            this.Get_histogram.Location = new System.Drawing.Point(23, 88);
            this.Get_histogram.Margin = new System.Windows.Forms.Padding(2);
            this.Get_histogram.Name = "Get_histogram";
            this.Get_histogram.Size = new System.Drawing.Size(138, 22);
            this.Get_histogram.TabIndex = 6;
            this.Get_histogram.Text = "Get brightness histogram";
            this.Get_histogram.UseVisualStyleBackColor = true;
            this.Get_histogram.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(216, 67);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 19);
            this.button2.TabIndex = 5;
            this.button2.Text = "apply";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(18, 34);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(339, 51);
            this.label8.TabIndex = 1;
            this.label8.Text = "Between-class variance is a variable, which tells us how good is the separability" +
    " between the two classes of pixels. However, it’s not a separability measure, it" +
    "’s its parameter.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 10);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Maximizes between-class variance.";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.effectsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.windowToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1019, 33);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.saveToTemplatesToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // saveToTemplatesToolStripMenuItem
            // 
            this.saveToTemplatesToolStripMenuItem.Name = "saveToTemplatesToolStripMenuItem";
            this.saveToTemplatesToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.saveToTemplatesToolStripMenuItem.Text = "Save  to templates";
            this.saveToTemplatesToolStripMenuItem.Click += new System.EventHandler(this.saveToTemplatesToolStripMenuItem_Click);
            // 
            // effectsToolStripMenuItem
            // 
            this.effectsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.convertToGreyToolStripMenuItem,
            this.blurToolStripMenuItem,
            this.sharpImageToolStripMenuItem});
            this.effectsToolStripMenuItem.Name = "effectsToolStripMenuItem";
            this.effectsToolStripMenuItem.Size = new System.Drawing.Size(51, 29);
            this.effectsToolStripMenuItem.Text = "Photo";
            // 
            // convertToGreyToolStripMenuItem
            // 
            this.convertToGreyToolStripMenuItem.Name = "convertToGreyToolStripMenuItem";
            this.convertToGreyToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.convertToGreyToolStripMenuItem.Text = "Convert to grey";
            this.convertToGreyToolStripMenuItem.Click += new System.EventHandler(this.convertToGreyToolStripMenuItem_Click);
            // 
            // blurToolStripMenuItem
            // 
            this.blurToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gaussianBlur3x3ToolStripMenuItem,
            this.gaussianBlur5x5ToolStripMenuItem,
            this.boxBlurToolStripMenuItem});
            this.blurToolStripMenuItem.Name = "blurToolStripMenuItem";
            this.blurToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.blurToolStripMenuItem.Text = "Blur";
            // 
            // gaussianBlur3x3ToolStripMenuItem
            // 
            this.gaussianBlur3x3ToolStripMenuItem.Name = "gaussianBlur3x3ToolStripMenuItem";
            this.gaussianBlur3x3ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.gaussianBlur3x3ToolStripMenuItem.Text = "Gaussian Blur 3x3";
            this.gaussianBlur3x3ToolStripMenuItem.Click += new System.EventHandler(this.gaussianBlur3x3ToolStripMenuItem_Click);
            // 
            // gaussianBlur5x5ToolStripMenuItem
            // 
            this.gaussianBlur5x5ToolStripMenuItem.Name = "gaussianBlur5x5ToolStripMenuItem";
            this.gaussianBlur5x5ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.gaussianBlur5x5ToolStripMenuItem.Text = "Gaussian Blur 5x5";
            this.gaussianBlur5x5ToolStripMenuItem.Click += new System.EventHandler(this.gaussianBlur5x5ToolStripMenuItem_Click);
            // 
            // boxBlurToolStripMenuItem
            // 
            this.boxBlurToolStripMenuItem.Name = "boxBlurToolStripMenuItem";
            this.boxBlurToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.boxBlurToolStripMenuItem.Text = "Box Blur";
            this.boxBlurToolStripMenuItem.Click += new System.EventHandler(this.boxBlurToolStripMenuItem_Click);
            // 
            // sharpImageToolStripMenuItem
            // 
            this.sharpImageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sharpenToolStripMenuItem,
            this.unsharpMaskingToolStripMenuItem});
            this.sharpImageToolStripMenuItem.Name = "sharpImageToolStripMenuItem";
            this.sharpImageToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.sharpImageToolStripMenuItem.Text = "Sharp image";
            // 
            // sharpenToolStripMenuItem
            // 
            this.sharpenToolStripMenuItem.Name = "sharpenToolStripMenuItem";
            this.sharpenToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.sharpenToolStripMenuItem.Text = "Sharpen";
            this.sharpenToolStripMenuItem.Click += new System.EventHandler(this.sharpenToolStripMenuItem_Click);
            // 
            // unsharpMaskingToolStripMenuItem
            // 
            this.unsharpMaskingToolStripMenuItem.Name = "unsharpMaskingToolStripMenuItem";
            this.unsharpMaskingToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.unsharpMaskingToolStripMenuItem.Text = "Unsharp masking";
            this.unsharpMaskingToolStripMenuItem.Click += new System.EventHandler(this.unsharpMaskingToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 29);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.histogramToolStripMenuItem});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 29);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // histogramToolStripMenuItem
            // 
            this.histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            this.histogramToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.histogramToolStripMenuItem.Text = "Histogram";
            this.histogramToolStripMenuItem.Click += new System.EventHandler(this.histogramToolStripMenuItem_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(274, 184);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Return default";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "G";
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.Location = new System.Drawing.Point(18, 24);
            this.labelR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(15, 13);
            this.labelR.TabIndex = 3;
            this.labelR.Text = "R";
            // 
            // trackBarB
            // 
            this.trackBarB.Location = new System.Drawing.Point(35, 116);
            this.trackBarB.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarB.Maximum = 255;
            this.trackBarB.Name = "trackBarB";
            this.trackBarB.Size = new System.Drawing.Size(268, 45);
            this.trackBarB.TabIndex = 2;
            this.trackBarB.Scroll += new System.EventHandler(this.trackBarB_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "B";
            // 
            // trackBarG
            // 
            this.trackBarG.Location = new System.Drawing.Point(35, 66);
            this.trackBarG.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarG.Maximum = 255;
            this.trackBarG.Name = "trackBarG";
            this.trackBarG.Size = new System.Drawing.Size(268, 45);
            this.trackBarG.TabIndex = 1;
            this.trackBarG.Scroll += new System.EventHandler(this.trackBarG_Scroll);
            // 
            // trackBarR
            // 
            this.trackBarR.Location = new System.Drawing.Point(35, 15);
            this.trackBarR.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarR.Maximum = 255;
            this.trackBarR.Name = "trackBarR";
            this.trackBarR.Size = new System.Drawing.Size(268, 45);
            this.trackBarR.TabIndex = 0;
            this.trackBarR.Scroll += new System.EventHandler(this.trackBarR_Scroll);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(236, 174);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 19);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControlGlobal
            // 
            this.tabControlGlobal.Controls.Add(this.tabPage5);
            this.tabControlGlobal.Controls.Add(this.tabPage6);
            this.tabControlGlobal.Controls.Add(this.tabPage7);
            this.tabControlGlobal.Location = new System.Drawing.Point(15, 207);
            this.tabControlGlobal.Margin = new System.Windows.Forms.Padding(2);
            this.tabControlGlobal.Name = "tabControlGlobal";
            this.tabControlGlobal.SelectedIndex = 0;
            this.tabControlGlobal.Size = new System.Drawing.Size(405, 323);
            this.tabControlGlobal.TabIndex = 18;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.Silver;
            this.tabPage5.Controls.Add(this.tabControl);
            this.tabPage5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage5.Size = new System.Drawing.Size(397, 297);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "Thresholding";
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.Silver;
            this.tabPage6.Controls.Add(this.tabControl2);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage6.Size = new System.Drawing.Size(397, 297);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "Edge detection";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage10);
            this.tabControl2.Controls.Add(this.tabPage12);
            this.tabControl2.Controls.Add(this.tabPage11);
            this.tabControl2.Location = new System.Drawing.Point(1, 2);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(396, 297);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label31);
            this.tabPage1.Controls.Add(this.button16);
            this.tabPage1.Controls.Add(this.pictureBoxEyePrewitt);
            this.tabPage1.Controls.Add(this.button10);
            this.tabPage1.Controls.Add(this.label23);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.pictureBoxEyeSobel55);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.pictureBoxEyeSobel33);
            this.tabPage1.Controls.Add(this.button9);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.button8);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(388, 271);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sobel/Prewitt";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(20, 221);
            this.label31.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(117, 17);
            this.label31.TabIndex = 18;
            this.label31.Text = "Custom operator:";
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(136, 221);
            this.button16.Margin = new System.Windows.Forms.Padding(2);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 22);
            this.button16.TabIndex = 17;
            this.button16.Text = "button16";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // pictureBoxEyePrewitt
            // 
            this.pictureBoxEyePrewitt.InitialImage = global::EdgeDetection.Properties.Resources.eye;
            this.pictureBoxEyePrewitt.Location = new System.Drawing.Point(190, 144);
            this.pictureBoxEyePrewitt.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxEyePrewitt.Name = "pictureBoxEyePrewitt";
            this.pictureBoxEyePrewitt.Size = new System.Drawing.Size(21, 24);
            this.pictureBoxEyePrewitt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEyePrewitt.TabIndex = 16;
            this.pictureBoxEyePrewitt.TabStop = false;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(68, 150);
            this.button10.Margin = new System.Windows.Forms.Padding(2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(56, 19);
            this.button10.TabIndex = 15;
            this.button10.Text = "apply";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(37, 152);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(24, 13);
            this.label23.TabIndex = 14;
            this.label23.Text = "3x3";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(19, 123);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(54, 17);
            this.label22.TabIndex = 13;
            this.label22.Text = "Prewitt:";
            // 
            // pictureBoxEyeSobel55
            // 
            this.pictureBoxEyeSobel55.InitialImage = global::EdgeDetection.Properties.Resources.eye;
            this.pictureBoxEyeSobel55.Location = new System.Drawing.Point(190, 78);
            this.pictureBoxEyeSobel55.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxEyeSobel55.Name = "pictureBoxEyeSobel55";
            this.pictureBoxEyeSobel55.Size = new System.Drawing.Size(21, 24);
            this.pictureBoxEyeSobel55.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEyeSobel55.TabIndex = 12;
            this.pictureBoxEyeSobel55.TabStop = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(181, 19);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(42, 13);
            this.label21.TabIndex = 11;
            this.label21.Text = "Kernels";
            // 
            // pictureBoxEyeSobel33
            // 
            this.pictureBoxEyeSobel33.InitialImage = global::EdgeDetection.Properties.Resources.eye;
            this.pictureBoxEyeSobel33.Location = new System.Drawing.Point(190, 46);
            this.pictureBoxEyeSobel33.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxEyeSobel33.Name = "pictureBoxEyeSobel33";
            this.pictureBoxEyeSobel33.Size = new System.Drawing.Size(21, 24);
            this.pictureBoxEyeSobel33.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEyeSobel33.TabIndex = 10;
            this.pictureBoxEyeSobel33.TabStop = false;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(68, 84);
            this.button9.Margin = new System.Windows.Forms.Padding(2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(56, 19);
            this.button9.TabIndex = 9;
            this.button9.Text = "apply";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(37, 87);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(24, 13);
            this.label20.TabIndex = 8;
            this.label20.Text = "5x5";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(19, 15);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(48, 17);
            this.label19.TabIndex = 7;
            this.label19.Text = "Sobel:";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(68, 53);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(56, 19);
            this.button8.TabIndex = 1;
            this.button8.Text = "apply";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(37, 55);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(24, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "3x3";
            // 
            // tabPage10
            // 
            this.tabPage10.Controls.Add(this.pictureBoxEye5);
            this.tabPage10.Controls.Add(this.button15);
            this.tabPage10.Controls.Add(this.label30);
            this.tabPage10.Controls.Add(this.button11);
            this.tabPage10.Controls.Add(this.label24);
            this.tabPage10.Controls.Add(this.button14);
            this.tabPage10.Controls.Add(this.label29);
            this.tabPage10.Controls.Add(this.label27);
            this.tabPage10.Controls.Add(this.label25);
            this.tabPage10.Controls.Add(this.label26);
            this.tabPage10.Controls.Add(this.button12);
            this.tabPage10.Controls.Add(this.label28);
            this.tabPage10.Controls.Add(this.button13);
            this.tabPage10.Controls.Add(this.pictureBoxEye4);
            this.tabPage10.Controls.Add(this.pictureBoxEye3);
            this.tabPage10.Controls.Add(this.pictureBoxEye2);
            this.tabPage10.Controls.Add(this.pictureBoxEye1);
            this.tabPage10.Location = new System.Drawing.Point(4, 22);
            this.tabPage10.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage10.Size = new System.Drawing.Size(388, 271);
            this.tabPage10.TabIndex = 1;
            this.tabPage10.Text = "Different kernels";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // pictureBoxEye5
            // 
            this.pictureBoxEye5.InitialImage = global::EdgeDetection.Properties.Resources.eye;
            this.pictureBoxEye5.Location = new System.Drawing.Point(214, 214);
            this.pictureBoxEye5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxEye5.Name = "pictureBoxEye5";
            this.pictureBoxEye5.Size = new System.Drawing.Size(21, 24);
            this.pictureBoxEye5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEye5.TabIndex = 38;
            this.pictureBoxEye5.TabStop = false;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(136, 216);
            this.button15.Margin = new System.Windows.Forms.Padding(2);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(56, 19);
            this.button15.TabIndex = 37;
            this.button15.Text = "apply";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(14, 216);
            this.label30.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(64, 17);
            this.label30.TabIndex = 36;
            this.label30.Text = "Box Blur:";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(136, 184);
            this.button11.Margin = new System.Windows.Forms.Padding(2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(56, 19);
            this.button11.TabIndex = 33;
            this.button11.Text = "apply";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(53, 184);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(24, 13);
            this.label24.TabIndex = 32;
            this.label24.Text = "5x5";
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(136, 152);
            this.button14.Margin = new System.Windows.Forms.Padding(2);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(56, 19);
            this.button14.TabIndex = 31;
            this.button14.Text = "apply";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(53, 152);
            this.label29.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(24, 13);
            this.label29.TabIndex = 30;
            this.label29.Text = "3x3";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(10, 74);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(138, 17);
            this.label27.TabIndex = 29;
            this.label27.Text = "Unsharpen masking:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(10, 123);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(101, 17);
            this.label25.TabIndex = 25;
            this.label25.Text = "Gaussian Blur:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(206, 8);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(42, 13);
            this.label26.TabIndex = 23;
            this.label26.Text = "Kernels";
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(136, 74);
            this.button12.Margin = new System.Windows.Forms.Padding(2);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(56, 19);
            this.button12.TabIndex = 21;
            this.button12.Text = "apply";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(10, 44);
            this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(66, 17);
            this.label28.TabIndex = 19;
            this.label28.Text = "Sharpen:";
            this.label28.Click += new System.EventHandler(this.label28_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(136, 41);
            this.button13.Margin = new System.Windows.Forms.Padding(2);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(56, 19);
            this.button13.TabIndex = 18;
            this.button13.Text = "apply";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // pictureBoxEye4
            // 
            this.pictureBoxEye4.InitialImage = global::EdgeDetection.Properties.Resources.eye;
            this.pictureBoxEye4.Location = new System.Drawing.Point(214, 184);
            this.pictureBoxEye4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxEye4.Name = "pictureBoxEye4";
            this.pictureBoxEye4.Size = new System.Drawing.Size(21, 24);
            this.pictureBoxEye4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEye4.TabIndex = 35;
            this.pictureBoxEye4.TabStop = false;
            // 
            // pictureBoxEye3
            // 
            this.pictureBoxEye3.InitialImage = global::EdgeDetection.Properties.Resources.eye;
            this.pictureBoxEye3.Location = new System.Drawing.Point(214, 152);
            this.pictureBoxEye3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxEye3.Name = "pictureBoxEye3";
            this.pictureBoxEye3.Size = new System.Drawing.Size(21, 24);
            this.pictureBoxEye3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEye3.TabIndex = 34;
            this.pictureBoxEye3.TabStop = false;
            // 
            // pictureBoxEye2
            // 
            this.pictureBoxEye2.InitialImage = global::EdgeDetection.Properties.Resources.eye;
            this.pictureBoxEye2.Location = new System.Drawing.Point(214, 67);
            this.pictureBoxEye2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxEye2.Name = "pictureBoxEye2";
            this.pictureBoxEye2.Size = new System.Drawing.Size(21, 24);
            this.pictureBoxEye2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEye2.TabIndex = 24;
            this.pictureBoxEye2.TabStop = false;
            // 
            // pictureBoxEye1
            // 
            this.pictureBoxEye1.InitialImage = global::EdgeDetection.Properties.Resources.eye;
            this.pictureBoxEye1.Location = new System.Drawing.Point(214, 36);
            this.pictureBoxEye1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxEye1.Name = "pictureBoxEye1";
            this.pictureBoxEye1.Size = new System.Drawing.Size(21, 24);
            this.pictureBoxEye1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEye1.TabIndex = 22;
            this.pictureBoxEye1.TabStop = false;
            // 
            // tabPage12
            // 
            this.tabPage12.Location = new System.Drawing.Point(4, 22);
            this.tabPage12.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage12.Name = "tabPage12";
            this.tabPage12.Size = new System.Drawing.Size(388, 271);
            this.tabPage12.TabIndex = 3;
            this.tabPage12.Text = "Laplacian";
            this.tabPage12.UseVisualStyleBackColor = true;
            // 
            // tabPage11
            // 
            this.tabPage11.Location = new System.Drawing.Point(4, 22);
            this.tabPage11.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Size = new System.Drawing.Size(388, 271);
            this.tabPage11.TabIndex = 2;
            this.tabPage11.Text = "Canny edge det.";
            this.tabPage11.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.Color.Silver;
            this.tabPage7.Controls.Add(this.tabControl1);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(397, 297);
            this.tabPage7.TabIndex = 2;
            this.tabPage7.Text = "Preprocessing";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Controls.Add(this.tabPage9);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(394, 294);
            this.tabControl1.TabIndex = 19;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.trackBarBlur);
            this.tabPage8.Controls.Add(this.button6);
            this.tabPage8.Controls.Add(this.label16);
            this.tabPage8.Controls.Add(this.label15);
            this.tabPage8.Controls.Add(this.label14);
            this.tabPage8.Controls.Add(this.textBox3);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage8.Size = new System.Drawing.Size(386, 268);
            this.tabPage8.TabIndex = 0;
            this.tabPage8.Text = "Blur";
            this.tabPage8.UseVisualStyleBackColor = true;
            this.tabPage8.Click += new System.EventHandler(this.tabPage8_Click);
            // 
            // trackBarBlur
            // 
            this.trackBarBlur.Location = new System.Drawing.Point(209, 44);
            this.trackBarBlur.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarBlur.Name = "trackBarBlur";
            this.trackBarBlur.Size = new System.Drawing.Size(131, 45);
            this.trackBarBlur.TabIndex = 6;
            this.trackBarBlur.Scroll += new System.EventHandler(this.trackBar1_Scroll_1);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(19, 76);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(67, 27);
            this.button6.TabIndex = 5;
            this.button6.Text = "apply blur";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(16, 76);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 13);
            this.label16.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(19, 19);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 17);
            this.label15.TabIndex = 2;
            this.label15.Text = "Gaussian blur";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 46);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "blur strength (radial) :";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(118, 44);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(76, 20);
            this.textBox3.TabIndex = 0;
            this.textBox3.Text = "0";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.button7);
            this.tabPage9.Controls.Add(this.label17);
            this.tabPage9.Controls.Add(this.button1);
            this.tabPage9.Controls.Add(this.trackBarG);
            this.tabPage9.Controls.Add(this.label4);
            this.tabPage9.Controls.Add(this.trackBarB);
            this.tabPage9.Controls.Add(this.labelR);
            this.tabPage9.Controls.Add(this.trackBarR);
            this.tabPage9.Controls.Add(this.label3);
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage9.Size = new System.Drawing.Size(386, 268);
            this.tabPage9.TabIndex = 1;
            this.tabPage9.Text = "rgb";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(35, 232);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(56, 19);
            this.button7.TabIndex = 9;
            this.button7.Text = "Convert ";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(32, 206);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(138, 17);
            this.label17.TabIndex = 8;
            this.label17.Text = "Convert to greyscale";
            // 
            // dToolStripMenuItem
            // 
            this.dToolStripMenuItem.Name = "dToolStripMenuItem";
            this.dToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.dToolStripMenuItem.Text = "D";
            // 
            // mainPicture
            // 
            this.mainPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPicture.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.mainPicture.Location = new System.Drawing.Point(432, 92);
            this.mainPicture.Margin = new System.Windows.Forms.Padding(2);
            this.mainPicture.Name = "mainPicture";
            this.mainPicture.Size = new System.Drawing.Size(306, 438);
            this.mainPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainPicture.TabIndex = 3;
            this.mainPicture.TabStop = false;
            this.mainPicture.Click += new System.EventHandler(this.mainPicture_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox2.InitialImage = global::EdgeDetection.Properties.Resources.boat;
            this.pictureBox2.Location = new System.Drawing.Point(100, 92);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 87);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.InitialImage = global::EdgeDetection.Properties.Resources.flower;
            this.pictureBox1.Location = new System.Drawing.Point(27, 92);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 87);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox3.InitialImage = global::EdgeDetection.Properties.Resources.house;
            this.pictureBox3.Location = new System.Drawing.Point(173, 92);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(68, 87);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox4.InitialImage = global::EdgeDetection.Properties.Resources.book_page;
            this.pictureBox4.Location = new System.Drawing.Point(246, 92);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(68, 87);
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox5.InitialImage = global::EdgeDetection.Properties.Resources.portrait2;
            this.pictureBox5.Location = new System.Drawing.Point(319, 92);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(68, 87);
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 540);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.mainPicture);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControlGlobal);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_value)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_questionMark1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.histogramPictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarR)).EndInit();
            this.tabControlGlobal.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEyePrewitt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEyeSobel55)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEyeSobel33)).EndInit();
            this.tabPage10.ResumeLayout(false);
            this.tabPage10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEye5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEye4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEye3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEye2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEye1)).EndInit();
            this.tabPage7.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlur)).EndInit();
            this.tabPage9.ResumeLayout(false);
            this.tabPage9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_open_thr;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button threshold_btn;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Get_histogram;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToTemplatesToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar_value;
        private System.Windows.Forms.TextBox textBox_value;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar trackBarR;
        private System.Windows.Forms.TrackBar trackBarG;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBarB;
        private System.Windows.Forms.Label labelR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControlGlobal;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label_resultOtsu;
        private System.Windows.Forms.ToolStripMenuItem effectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertToGreyToolStripMenuItem;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dToolStripMenuItem;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TrackBar trackBarBlur;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TabPage tabPage11;
        private System.Windows.Forms.TabPage tabPage12;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.ToolStripMenuItem blurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gaussianBlur3x3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gaussianBlur5x5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boxBlurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sharpImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sharpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unsharpMaskingToolStripMenuItem;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.PictureBox pictureBox_questionMark1;
        private System.Windows.Forms.PictureBox histogramPictureBox;
        private System.Windows.Forms.PictureBox pictureBoxEyePrewitt;
        private System.Windows.Forms.PictureBox pictureBoxEyeSobel55;
        private System.Windows.Forms.PictureBox pictureBoxEyeSobel33;
        private System.Windows.Forms.PictureBox pictureBoxEye5;
        private System.Windows.Forms.PictureBox pictureBoxEye4;
        private System.Windows.Forms.PictureBox pictureBoxEye3;
        private System.Windows.Forms.PictureBox pictureBoxEye2;
        private System.Windows.Forms.PictureBox pictureBoxEye1;
        private System.Windows.Forms.PictureBox mainPicture;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}


namespace EdgeDetection
{
    partial class APIForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.ImportedPicture = new System.Windows.Forms.PictureBox();
            this.mainPicture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImportedPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Object detection";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ImportedPicture
            // 
            this.ImportedPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImportedPicture.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ImportedPicture.Location = new System.Drawing.Point(297, 268);
            this.ImportedPicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ImportedPicture.Name = "ImportedPicture";
            this.ImportedPicture.Size = new System.Drawing.Size(303, 335);
            this.ImportedPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImportedPicture.TabIndex = 5;
            this.ImportedPicture.TabStop = false;
            // 
            // mainPicture
            // 
            this.mainPicture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPicture.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.mainPicture.Location = new System.Drawing.Point(297, 61);
            this.mainPicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainPicture.Name = "mainPicture";
            this.mainPicture.Size = new System.Drawing.Size(303, 188);
            this.mainPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainPicture.TabIndex = 4;
            this.mainPicture.TabStop = false;
            this.mainPicture.Click += new System.EventHandler(this.mainPicture_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(62, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Info;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(34, 545);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(224, 42);
            this.button2.TabIndex = 7;
            this.button2.Text = "Save and return to main";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // APIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 614);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ImportedPicture);
            this.Controls.Add(this.mainPicture);
            this.Controls.Add(this.button1);
            this.Name = "APIForm";
            this.Text = "External libraries";
            this.Load += new System.EventHandler(this.APIForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImportedPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox mainPicture;
        private System.Windows.Forms.PictureBox ImportedPicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}
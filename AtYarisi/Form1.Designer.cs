namespace AtYarisi
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pnlSaha = new Panel();
            pbAt3 = new PictureBox();
            pbAt2 = new PictureBox();
            pbAt1 = new PictureBox();
            pbBitis = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label1 = new Label();
            btnBaslat = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            groupBox1 = new GroupBox();
            lblFark = new Label();
            label5 = new Label();
            lblOndekiAt = new Label();
            lblSpiker = new Label();
            pnlSaha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAt3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAt2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAt1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBitis).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSaha
            // 
            pnlSaha.BackColor = Color.ForestGreen;
            pnlSaha.Controls.Add(pbAt3);
            pnlSaha.Controls.Add(pbAt2);
            pnlSaha.Controls.Add(pbAt1);
            pnlSaha.Controls.Add(pbBitis);
            pnlSaha.Controls.Add(label3);
            pnlSaha.Controls.Add(label2);
            pnlSaha.Controls.Add(label4);
            pnlSaha.Controls.Add(label1);
            pnlSaha.Location = new Point(65, 41);
            pnlSaha.Name = "pnlSaha";
            pnlSaha.Size = new Size(621, 326);
            pnlSaha.TabIndex = 0;
            // 
            // pbAt3
            // 
            pbAt3.Image = Properties.Resources.at4;
            pbAt3.Location = new Point(3, 226);
            pbAt3.Name = "pbAt3";
            pbAt3.Size = new Size(128, 78);
            pbAt3.SizeMode = PictureBoxSizeMode.Zoom;
            pbAt3.TabIndex = 0;
            pbAt3.TabStop = false;
            pbAt3.Tag = "4";
            // 
            // pbAt2
            // 
            pbAt2.Image = Properties.Resources.at2;
            pbAt2.Location = new Point(3, 122);
            pbAt2.Name = "pbAt2";
            pbAt2.Size = new Size(128, 78);
            pbAt2.SizeMode = PictureBoxSizeMode.Zoom;
            pbAt2.TabIndex = 0;
            pbAt2.TabStop = false;
            pbAt2.Tag = "2";
            // 
            // pbAt1
            // 
            pbAt1.Image = Properties.Resources.at1;
            pbAt1.Location = new Point(3, 20);
            pbAt1.Name = "pbAt1";
            pbAt1.Size = new Size(128, 78);
            pbAt1.SizeMode = PictureBoxSizeMode.Zoom;
            pbAt1.TabIndex = 0;
            pbAt1.TabStop = false;
            pbAt1.Tag = "1";
            // 
            // pbBitis
            // 
            pbBitis.Image = Properties.Resources.pngwing_com__3_;
            pbBitis.Location = new Point(575, 0);
            pbBitis.Name = "pbBitis";
            pbBitis.Size = new Size(46, 326);
            pbBitis.TabIndex = 2;
            pbBitis.TabStop = false;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Location = new Point(0, 317);
            label3.Name = "label3";
            label3.Size = new Size(576, 10);
            label3.TabIndex = 1;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(1, 211);
            label2.Name = "label2";
            label2.Size = new Size(576, 10);
            label2.TabIndex = 1;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Location = new Point(0, -1);
            label4.Name = "label4";
            label4.Size = new Size(576, 10);
            label4.TabIndex = 1;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(0, 105);
            label1.Name = "label1";
            label1.Size = new Size(576, 10);
            label1.TabIndex = 1;
            // 
            // btnBaslat
            // 
            btnBaslat.Location = new Point(308, 424);
            btnBaslat.Name = "btnBaslat";
            btnBaslat.Size = new Size(131, 37);
            btnBaslat.TabIndex = 1;
            btnBaslat.Text = "Başlat";
            btnBaslat.UseVisualStyleBackColor = true;
            btnBaslat.Click += btnBaslat_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblFark);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(lblOndekiAt);
            groupBox1.Location = new Point(708, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(266, 100);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Öndeki At";
            // 
            // lblFark
            // 
            lblFark.AutoSize = true;
            lblFark.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblFark.Location = new Point(146, 51);
            lblFark.Name = "lblFark";
            lblFark.Size = new Size(0, 21);
            lblFark.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(3, 51);
            label5.Name = "label5";
            label5.Size = new Size(137, 21);
            label5.TabIndex = 0;
            label5.Text = "Varış Mesafesi = ";
            // 
            // lblOndekiAt
            // 
            lblOndekiAt.AutoSize = true;
            lblOndekiAt.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblOndekiAt.Location = new Point(3, 19);
            lblOndekiAt.Name = "lblOndekiAt";
            lblOndekiAt.Size = new Size(82, 21);
            lblOndekiAt.TabIndex = 0;
            lblOndekiAt.Text = "1 Nolu At";
            // 
            // lblSpiker
            // 
            lblSpiker.BackColor = SystemColors.ActiveCaption;
            lblSpiker.BorderStyle = BorderStyle.FixedSingle;
            lblSpiker.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSpiker.Location = new Point(65, 370);
            lblSpiker.Name = "lblSpiker";
            lblSpiker.Size = new Size(621, 51);
            lblSpiker.TabIndex = 3;
            lblSpiker.Text = "Atlar Yarışa Hazır!";
            lblSpiker.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 473);
            Controls.Add(lblSpiker);
            Controls.Add(groupBox1);
            Controls.Add(btnBaslat);
            Controls.Add(pnlSaha);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "At Yarışı";
            pnlSaha.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbAt3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAt2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAt1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBitis).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSaha;
        private PictureBox pbAt1;
        private PictureBox pbAt3;
        private PictureBox pbAt2;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private PictureBox pbBitis;
        private Button btnBaslat;
        private System.Windows.Forms.Timer timer1;
        private GroupBox groupBox1;
        private Label lblOndekiAt;
        private Label lblSpiker;
        private Label lblFark;
        private Label label5;
    }
}

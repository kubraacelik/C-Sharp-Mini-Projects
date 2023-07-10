
namespace Ülkeler_ve_Başkentleri_Oyunu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnA = new System.Windows.Forms.Button();
            this.BtnB = new System.Windows.Forms.Button();
            this.BtnC = new System.Windows.Forms.Button();
            this.BtnD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSoru = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblPuan = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LblSure = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(14, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(489, 299);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BtnA
            // 
            this.BtnA.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnA.Location = new System.Drawing.Point(14, 387);
            this.BtnA.Name = "BtnA";
            this.BtnA.Size = new System.Drawing.Size(200, 47);
            this.BtnA.TabIndex = 1;
            this.BtnA.Text = "cevap 1";
            this.BtnA.UseVisualStyleBackColor = true;
            this.BtnA.Click += new System.EventHandler(this.BtnA_Click);
            // 
            // BtnB
            // 
            this.BtnB.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnB.Location = new System.Drawing.Point(295, 387);
            this.BtnB.Name = "BtnB";
            this.BtnB.Size = new System.Drawing.Size(208, 47);
            this.BtnB.TabIndex = 2;
            this.BtnB.Text = "cevap 2";
            this.BtnB.UseVisualStyleBackColor = true;
            this.BtnB.Click += new System.EventHandler(this.BtnB_Click);
            // 
            // BtnC
            // 
            this.BtnC.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnC.Location = new System.Drawing.Point(12, 449);
            this.BtnC.Name = "BtnC";
            this.BtnC.Size = new System.Drawing.Size(202, 47);
            this.BtnC.TabIndex = 3;
            this.BtnC.Text = "cevap 3";
            this.BtnC.UseVisualStyleBackColor = true;
            this.BtnC.Click += new System.EventHandler(this.BtnC_Click);
            // 
            // BtnD
            // 
            this.BtnD.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnD.Location = new System.Drawing.Point(295, 449);
            this.BtnD.Name = "BtnD";
            this.BtnD.Size = new System.Drawing.Size(208, 47);
            this.BtnD.TabIndex = 4;
            this.BtnD.Text = "cevap 4";
            this.BtnD.UseVisualStyleBackColor = true;
            this.BtnD.Click += new System.EventHandler(this.BtnD_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(193, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ülke İsmi";
            // 
            // BtnSoru
            // 
            this.BtnSoru.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSoru.Location = new System.Drawing.Point(538, 69);
            this.BtnSoru.Name = "BtnSoru";
            this.BtnSoru.Size = new System.Drawing.Size(245, 61);
            this.BtnSoru.TabIndex = 6;
            this.BtnSoru.Text = "Başlat";
            this.BtnSoru.UseVisualStyleBackColor = true;
            this.BtnSoru.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(607, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 38);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(607, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 38);
            this.label3.TabIndex = 8;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(592, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 38);
            this.label4.TabIndex = 9;
            this.label4.Text = "Puan =";
            // 
            // LblPuan
            // 
            this.LblPuan.AutoSize = true;
            this.LblPuan.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblPuan.Location = new System.Drawing.Point(704, 146);
            this.LblPuan.Name = "LblPuan";
            this.LblPuan.Size = new System.Drawing.Size(33, 38);
            this.LblPuan.TabIndex = 10;
            this.LblPuan.Text = "0";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(439, 503);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(355, 42);
            this.axWindowsMediaPlayer1.TabIndex = 11;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LblSure
            // 
            this.LblSure.AutoSize = true;
            this.LblSure.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSure.Location = new System.Drawing.Point(733, 16);
            this.LblSure.Name = "LblSure";
            this.LblSure.Size = new System.Drawing.Size(49, 38);
            this.LblSure.TabIndex = 13;
            this.LblSure.Text = "60";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(542, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 38);
            this.label6.TabIndex = 12;
            this.label6.Text = "Kalan Süre =";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MediumOrchid;
            this.ClientSize = new System.Drawing.Size(806, 547);
            this.Controls.Add(this.LblSure);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.LblPuan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnSoru);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnD);
            this.Controls.Add(this.BtnC);
            this.Controls.Add(this.BtnB);
            this.Controls.Add(this.BtnA);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnA;
        private System.Windows.Forms.Button BtnB;
        private System.Windows.Forms.Button BtnC;
        private System.Windows.Forms.Button BtnD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSoru;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblPuan;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LblSure;
        private System.Windows.Forms.Label label6;
    }
}


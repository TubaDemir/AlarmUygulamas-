namespace Alarm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAlarmMetni = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnAlarmKur = new System.Windows.Forms.Button();
            this.btnAlarmDurdur = new System.Windows.Forms.Button();
            this.tmrSaat = new System.Windows.Forms.Timer(this.components);
            this.tmrZamanKontrolu = new System.Windows.Forms.Timer(this.components);
            this.tmrAlarmIsleri = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Alarm.Properties.Resources.gong;
            this.pictureBox1.Location = new System.Drawing.Point(337, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 124);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tarih : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Saat : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Alarm Metni : ";
            // 
            // txtAlarmMetni
            // 
            this.txtAlarmMetni.Location = new System.Drawing.Point(100, 58);
            this.txtAlarmMetni.Multiline = true;
            this.txtAlarmMetni.Name = "txtAlarmMetni";
            this.txtAlarmMetni.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAlarmMetni.Size = new System.Drawing.Size(200, 72);
            this.txtAlarmMetni.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(100, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // btnAlarmKur
            // 
            this.btnAlarmKur.BackgroundImage = global::Alarm.Properties.Resources.alarmOn;
            this.btnAlarmKur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAlarmKur.Location = new System.Drawing.Point(335, 136);
            this.btnAlarmKur.Name = "btnAlarmKur";
            this.btnAlarmKur.Size = new System.Drawing.Size(41, 36);
            this.btnAlarmKur.TabIndex = 7;
            this.btnAlarmKur.UseVisualStyleBackColor = true;
            this.btnAlarmKur.Click += new System.EventHandler(this.btnAlarmKur_Click);
            // 
            // btnAlarmDurdur
            // 
            this.btnAlarmDurdur.BackgroundImage = global::Alarm.Properties.Resources.alarmOff;
            this.btnAlarmDurdur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAlarmDurdur.Location = new System.Drawing.Point(382, 136);
            this.btnAlarmDurdur.Name = "btnAlarmDurdur";
            this.btnAlarmDurdur.Size = new System.Drawing.Size(41, 36);
            this.btnAlarmDurdur.TabIndex = 8;
            this.btnAlarmDurdur.UseVisualStyleBackColor = true;
            this.btnAlarmDurdur.Click += new System.EventHandler(this.btnAlarmDurdur_Click);
            // 
            // tmrSaat
            // 
            this.tmrSaat.Enabled = true;
            this.tmrSaat.Interval = 1000;
            this.tmrSaat.Tick += new System.EventHandler(this.tmrSaat_Tick);
            // 
            // tmrZamanKontrolu
            // 
            this.tmrZamanKontrolu.Interval = 1000;
            this.tmrZamanKontrolu.Tick += new System.EventHandler(this.tmrZamanKontrolu_Tick);
            // 
            // tmrAlarmIsleri
            // 
            this.tmrAlarmIsleri.Interval = 1000;
            this.tmrAlarmIsleri.Tick += new System.EventHandler(this.tmrAlarmIsleri_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(100, 32);
            this.maskedTextBox1.Mask = "00:00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(200, 20);
            this.maskedTextBox1.TabIndex = 9;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 189);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.btnAlarmDurdur);
            this.Controls.Add(this.btnAlarmKur);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtAlarmMetni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAlarmMetni;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnAlarmKur;
        private System.Windows.Forms.Button btnAlarmDurdur;
        private System.Windows.Forms.Timer tmrSaat;
        private System.Windows.Forms.Timer tmrZamanKontrolu;
        private System.Windows.Forms.Timer tmrAlarmIsleri;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}


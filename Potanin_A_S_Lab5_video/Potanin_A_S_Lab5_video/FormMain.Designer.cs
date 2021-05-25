namespace Potanin_A_S_Lab5_video
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBoxCapture = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonPlay = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPause = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonStop = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OnInversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OffInversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OnVoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OffVoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.toolStrip1);
            this.tabPage1.Controls.Add(this.menuStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Видео";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(786, 369);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripComboBoxCapture,
            this.toolStripSeparator1,
            this.toolStripButtonPlay,
            this.toolStripButtonPause,
            this.toolStripButtonStop});
            this.toolStrip1.Location = new System.Drawing.Point(3, 27);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(786, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(48, 22);
            this.toolStripLabel1.Text = "Камера";
            // 
            // toolStripComboBoxCapture
            // 
            this.toolStripComboBoxCapture.Name = "toolStripComboBoxCapture";
            this.toolStripComboBoxCapture.Size = new System.Drawing.Size(121, 25);
            this.toolStripComboBoxCapture.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxCapture_SelectedIndexChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonPlay
            // 
            this.toolStripButtonPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonPlay.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPlay.Image")));
            this.toolStripButtonPlay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPlay.Name = "toolStripButtonPlay";
            this.toolStripButtonPlay.Size = new System.Drawing.Size(64, 22);
            this.toolStripButtonPlay.Text = "Смотреть";
            this.toolStripButtonPlay.Click += new System.EventHandler(this.toolStripButtonPlay_Click);
            // 
            // toolStripButtonPause
            // 
            this.toolStripButtonPause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonPause.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPause.Image")));
            this.toolStripButtonPause.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPause.Name = "toolStripButtonPause";
            this.toolStripButtonPause.Size = new System.Drawing.Size(43, 22);
            this.toolStripButtonPause.Text = "Пауза";
            this.toolStripButtonPause.Click += new System.EventHandler(this.toolStripButtonPause_Click);
            // 
            // toolStripButtonStop
            // 
            this.toolStripButtonStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonStop.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonStop.Image")));
            this.toolStripButtonStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStop.Name = "toolStripButtonStop";
            this.toolStripButtonStop.Size = new System.Drawing.Size(38, 22);
            this.toolStripButtonStop.Text = "Стоп";
            this.toolStripButtonStop.Click += new System.EventHandler(this.toolStripButtonStop_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.InversToolStripMenuItem,
            this.VoiceToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(786, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.ExitToolStripMenuItem.Text = "Выход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // InversToolStripMenuItem
            // 
            this.InversToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OnInversToolStripMenuItem,
            this.OffInversToolStripMenuItem});
            this.InversToolStripMenuItem.Name = "InversToolStripMenuItem";
            this.InversToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.InversToolStripMenuItem.Text = "Инверсия";
            // 
            // OnInversToolStripMenuItem
            // 
            this.OnInversToolStripMenuItem.Name = "OnInversToolStripMenuItem";
            this.OnInversToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.OnInversToolStripMenuItem.Text = "Вкл";
            this.OnInversToolStripMenuItem.Click += new System.EventHandler(this.OnInversToolStripMenuItem_Click);
            // 
            // OffInversToolStripMenuItem
            // 
            this.OffInversToolStripMenuItem.Name = "OffInversToolStripMenuItem";
            this.OffInversToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.OffInversToolStripMenuItem.Text = "Выкл";
            this.OffInversToolStripMenuItem.Click += new System.EventHandler(this.OffInversToolStripMenuItem_Click);
            // 
            // VoiceToolStripMenuItem
            // 
            this.VoiceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OnVoiceToolStripMenuItem,
            this.OffVoiceToolStripMenuItem});
            this.VoiceToolStripMenuItem.Name = "VoiceToolStripMenuItem";
            this.VoiceToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.VoiceToolStripMenuItem.Text = "Звук";
            // 
            // OnVoiceToolStripMenuItem
            // 
            this.OnVoiceToolStripMenuItem.Name = "OnVoiceToolStripMenuItem";
            this.OnVoiceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.OnVoiceToolStripMenuItem.Text = "Вкл";
            this.OnVoiceToolStripMenuItem.Click += new System.EventHandler(this.OnVoiceToolStripMenuItem_Click);
            // 
            // OffVoiceToolStripMenuItem
            // 
            this.OffVoiceToolStripMenuItem.Name = "OffVoiceToolStripMenuItem";
            this.OffVoiceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.OffVoiceToolStripMenuItem.Text = "Выкл";
            this.OffVoiceToolStripMenuItem.Click += new System.EventHandler(this.OffVoiceToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Захват видео/аудио";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxCapture;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonPlay;
        private System.Windows.Forms.ToolStripButton toolStripButtonPause;
        private System.Windows.Forms.ToolStripButton toolStripButtonStop;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OnInversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OffInversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OnVoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OffVoiceToolStripMenuItem;
    }
}


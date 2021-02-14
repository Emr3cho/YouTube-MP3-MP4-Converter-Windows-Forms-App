
namespace Downloader___mp3_mp4
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.URL_input = new System.Windows.Forms.TextBox();
            this.URL_text = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Label();
            this.format = new System.Windows.Forms.Label();
            this.MP3_Button = new System.Windows.Forms.RadioButton();
            this.MP4_Button = new System.Windows.Forms.RadioButton();
            this.download_Button = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Label();
            this.status_display = new System.Windows.Forms.Label();
            this.saveIn_Text = new System.Windows.Forms.Label();
            this.videoSaveWay = new System.Windows.Forms.Button();
            this.buttonActivateManyVersion = new System.Windows.Forms.Button();
            this.add_Button = new System.Windows.Forms.Button();
            this.deleteLastElement_Button = new System.Windows.Forms.Button();
            this.downloadAddedElements_Button = new System.Windows.Forms.Button();
            this.lastAddedSongName = new System.Windows.Forms.Label();
            this.buttonActivateOneVersion = new System.Windows.Forms.Button();
            this.downloading_Text = new System.Windows.Forms.Label();
            this.willDownload_Text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // URL_input
            // 
            this.URL_input.Location = new System.Drawing.Point(163, 54);
            this.URL_input.Name = "URL_input";
            this.URL_input.Size = new System.Drawing.Size(440, 20);
            this.URL_input.TabIndex = 0;
            // 
            // URL_text
            // 
            this.URL_text.AutoSize = true;
            this.URL_text.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.URL_text.Location = new System.Drawing.Point(4, 53);
            this.URL_text.Name = "URL_text";
            this.URL_text.Size = new System.Drawing.Size(154, 21);
            this.URL_text.TabIndex = 1;
            this.URL_text.Text = "Линк към видеото:\r\n";
            // 
            // header
            // 
            this.header.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.header.Location = new System.Drawing.Point(2, 23);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(610, 21);
            this.header.TabIndex = 2;
            this.header.Text = "YouTube MP3/MP4 Downloader By Emr3\r\n";
            this.header.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // format
            // 
            this.format.AutoSize = true;
            this.format.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.format.Location = new System.Drawing.Point(4, 87);
            this.format.Name = "format";
            this.format.Size = new System.Drawing.Size(73, 21);
            this.format.TabIndex = 3;
            this.format.Text = "Формат:";
            // 
            // MP3_Button
            // 
            this.MP3_Button.AutoSize = true;
            this.MP3_Button.Checked = true;
            this.MP3_Button.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MP3_Button.Location = new System.Drawing.Point(83, 89);
            this.MP3_Button.Name = "MP3_Button";
            this.MP3_Button.Size = new System.Drawing.Size(54, 21);
            this.MP3_Button.TabIndex = 4;
            this.MP3_Button.TabStop = true;
            this.MP3_Button.Text = "MP3";
            this.MP3_Button.UseVisualStyleBackColor = true;
            // 
            // MP4_Button
            // 
            this.MP4_Button.AutoSize = true;
            this.MP4_Button.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MP4_Button.Location = new System.Drawing.Point(143, 89);
            this.MP4_Button.Name = "MP4_Button";
            this.MP4_Button.Size = new System.Drawing.Size(54, 21);
            this.MP4_Button.TabIndex = 5;
            this.MP4_Button.Text = "MP4";
            this.MP4_Button.UseVisualStyleBackColor = true;
            // 
            // download_Button
            // 
            this.download_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.download_Button.Enabled = false;
            this.download_Button.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.download_Button.Image = ((System.Drawing.Image)(resources.GetObject("download_Button.Image")));
            this.download_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.download_Button.Location = new System.Drawing.Point(203, 80);
            this.download_Button.Name = "download_Button";
            this.download_Button.Size = new System.Drawing.Size(400, 70);
            this.download_Button.TabIndex = 6;
            this.download_Button.Text = "Изтегли";
            this.download_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.download_Button.UseVisualStyleBackColor = true;
            this.download_Button.Click += new System.EventHandler(this.download_Button_Click);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Yu Gothic UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.status.Location = new System.Drawing.Point(4, 118);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(65, 23);
            this.status.TabIndex = 7;
            this.status.Text = "Статус:";
            // 
            // status_display
            // 
            this.status_display.AutoSize = true;
            this.status_display.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.status_display.Location = new System.Drawing.Point(67, 117);
            this.status_display.Name = "status_display";
            this.status_display.Size = new System.Drawing.Size(20, 25);
            this.status_display.TabIndex = 8;
            this.status_display.Text = "-";
            this.status_display.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // saveIn_Text
            // 
            this.saveIn_Text.AutoSize = true;
            this.saveIn_Text.Font = new System.Drawing.Font("Yu Gothic UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveIn_Text.Location = new System.Drawing.Point(2, 155);
            this.saveIn_Text.Name = "saveIn_Text";
            this.saveIn_Text.Size = new System.Drawing.Size(90, 23);
            this.saveIn_Text.TabIndex = 10;
            this.saveIn_Text.Text = "Запиши в:";
            // 
            // videoSaveWay
            // 
            this.videoSaveWay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.videoSaveWay.Location = new System.Drawing.Point(96, 155);
            this.videoSaveWay.Name = "videoSaveWay";
            this.videoSaveWay.Size = new System.Drawing.Size(507, 23);
            this.videoSaveWay.TabIndex = 11;
            this.videoSaveWay.Text = "Кликнете тук, за да изберете къде да запишете!";
            this.videoSaveWay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.videoSaveWay.UseVisualStyleBackColor = true;
            this.videoSaveWay.Click += new System.EventHandler(this.videoSaveWay_Click);
            // 
            // buttonActivateManyVersion
            // 
            this.buttonActivateManyVersion.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonActivateManyVersion.Location = new System.Drawing.Point(8, 199);
            this.buttonActivateManyVersion.Name = "buttonActivateManyVersion";
            this.buttonActivateManyVersion.Size = new System.Drawing.Size(595, 57);
            this.buttonActivateManyVersion.TabIndex = 12;
            this.buttonActivateManyVersion.Text = "Активирай опция инсталиране на много елементи наведнъж";
            this.buttonActivateManyVersion.UseVisualStyleBackColor = true;
            this.buttonActivateManyVersion.Click += new System.EventHandler(this.buttonActivateSecondElements_Click);
            // 
            // add_Button
            // 
            this.add_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.add_Button.Font = new System.Drawing.Font("Yu Gothic UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_Button.Image = ((System.Drawing.Image)(resources.GetObject("add_Button.Image")));
            this.add_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.add_Button.Location = new System.Drawing.Point(284, 80);
            this.add_Button.Name = "add_Button";
            this.add_Button.Size = new System.Drawing.Size(319, 51);
            this.add_Button.TabIndex = 13;
            this.add_Button.Text = "Добави";
            this.add_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.add_Button.UseVisualStyleBackColor = true;
            this.add_Button.Visible = false;
            this.add_Button.Click += new System.EventHandler(this.add_Button_Click);
            // 
            // deleteLastElement_Button
            // 
            this.deleteLastElement_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.deleteLastElement_Button.Enabled = false;
            this.deleteLastElement_Button.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteLastElement_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteLastElement_Button.Location = new System.Drawing.Point(203, 80);
            this.deleteLastElement_Button.Name = "deleteLastElement_Button";
            this.deleteLastElement_Button.Size = new System.Drawing.Size(81, 51);
            this.deleteLastElement_Button.TabIndex = 14;
            this.deleteLastElement_Button.Text = "Изтрий последният елемент\r\n";
            this.deleteLastElement_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteLastElement_Button.UseVisualStyleBackColor = true;
            this.deleteLastElement_Button.Visible = false;
            this.deleteLastElement_Button.Click += new System.EventHandler(this.deleteLastElement_Button_Click);
            // 
            // downloadAddedElements_Button
            // 
            this.downloadAddedElements_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.downloadAddedElements_Button.Enabled = false;
            this.downloadAddedElements_Button.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.downloadAddedElements_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.downloadAddedElements_Button.Location = new System.Drawing.Point(203, 131);
            this.downloadAddedElements_Button.Name = "downloadAddedElements_Button";
            this.downloadAddedElements_Button.Size = new System.Drawing.Size(400, 26);
            this.downloadAddedElements_Button.TabIndex = 15;
            this.downloadAddedElements_Button.Text = "Изтегли добавените елементи";
            this.downloadAddedElements_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.downloadAddedElements_Button.UseVisualStyleBackColor = true;
            this.downloadAddedElements_Button.Visible = false;
            this.downloadAddedElements_Button.Click += new System.EventHandler(this.downloadAddedElements_Button_Click);
            // 
            // lastAddedSongName
            // 
            this.lastAddedSongName.AutoSize = true;
            this.lastAddedSongName.Font = new System.Drawing.Font("Yu Gothic UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastAddedSongName.Location = new System.Drawing.Point(4, 160);
            this.lastAddedSongName.Name = "lastAddedSongName";
            this.lastAddedSongName.Size = new System.Drawing.Size(191, 23);
            this.lastAddedSongName.TabIndex = 16;
            this.lastAddedSongName.Text = "Последен елемент: ---\r\n";
            this.lastAddedSongName.Visible = false;
            // 
            // buttonActivateOneVersion
            // 
            this.buttonActivateOneVersion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonActivateOneVersion.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonActivateOneVersion.Location = new System.Drawing.Point(9, 32);
            this.buttonActivateOneVersion.Name = "buttonActivateOneVersion";
            this.buttonActivateOneVersion.Size = new System.Drawing.Size(155, 23);
            this.buttonActivateOneVersion.TabIndex = 17;
            this.buttonActivateOneVersion.Text = "Режим едно по едно";
            this.buttonActivateOneVersion.UseVisualStyleBackColor = true;
            this.buttonActivateOneVersion.Visible = false;
            this.buttonActivateOneVersion.Click += new System.EventHandler(this.buttonActivateFirstElements_Click);
            // 
            // downloading_Text
            // 
            this.downloading_Text.AutoSize = true;
            this.downloading_Text.Font = new System.Drawing.Font("Yu Gothic UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.downloading_Text.Location = new System.Drawing.Point(4, 185);
            this.downloading_Text.Name = "downloading_Text";
            this.downloading_Text.Size = new System.Drawing.Size(125, 23);
            this.downloading_Text.TabIndex = 18;
            this.downloading_Text.Text = "Изтегля се: ---\r\n";
            this.downloading_Text.Visible = false;
            // 
            // willDownload_Text
            // 
            this.willDownload_Text.AutoSize = true;
            this.willDownload_Text.Font = new System.Drawing.Font("Yu Gothic UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.willDownload_Text.Location = new System.Drawing.Point(4, 212);
            this.willDownload_Text.Name = "willDownload_Text";
            this.willDownload_Text.Size = new System.Drawing.Size(154, 23);
            this.willDownload_Text.TabIndex = 19;
            this.willDownload_Text.Text = "Ще се изтегли: ---\r\n";
            this.willDownload_Text.Visible = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 279);
            this.Controls.Add(this.buttonActivateOneVersion);
            this.Controls.Add(this.buttonActivateManyVersion);
            this.Controls.Add(this.videoSaveWay);
            this.Controls.Add(this.saveIn_Text);
            this.Controls.Add(this.status_display);
            this.Controls.Add(this.status);
            this.Controls.Add(this.download_Button);
            this.Controls.Add(this.MP4_Button);
            this.Controls.Add(this.MP3_Button);
            this.Controls.Add(this.format);
            this.Controls.Add(this.header);
            this.Controls.Add(this.URL_text);
            this.Controls.Add(this.URL_input);
            this.Controls.Add(this.add_Button);
            this.Controls.Add(this.deleteLastElement_Button);
            this.Controls.Add(this.downloadAddedElements_Button);
            this.Controls.Add(this.lastAddedSongName);
            this.Controls.Add(this.willDownload_Text);
            this.Controls.Add(this.downloading_Text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Видео/музика конвертър";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox URL_input;
        private System.Windows.Forms.Label URL_text;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label format;
        private System.Windows.Forms.RadioButton MP3_Button;
        private System.Windows.Forms.RadioButton MP4_Button;
        private System.Windows.Forms.Button download_Button;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label status_display;
        private System.Windows.Forms.Label saveIn_Text;
        private System.Windows.Forms.Button videoSaveWay;
        private System.Windows.Forms.Button buttonActivateManyVersion;
        private System.Windows.Forms.Button add_Button;
        private System.Windows.Forms.Button deleteLastElement_Button;
        private System.Windows.Forms.Button downloadAddedElements_Button;
        private System.Windows.Forms.Label lastAddedSongName;
        private System.Windows.Forms.Button buttonActivateOneVersion;
        private System.Windows.Forms.Label downloading_Text;
        private System.Windows.Forms.Label willDownload_Text;
    }
}


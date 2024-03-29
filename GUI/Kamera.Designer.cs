﻿namespace GUI
{
    partial class Kamera
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
            this.panelVideoPreview = new System.Windows.Forms.Panel();
            this.btnPreview = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lstVideoDevices = new System.Windows.Forms.ListBox();
            this.lstAudioDevices = new System.Windows.Forms.ListBox();
            this.lblVideoDeviceSelectedForPreview = new System.Windows.Forms.Label();
            this.lblAudioDeviceSelectedForPreview = new System.Windows.Forms.Label();
            this.btnGrabImage = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelVideoPreview
            // 
            this.panelVideoPreview.Location = new System.Drawing.Point(374, 12);
            this.panelVideoPreview.Name = "panelVideoPreview";
            this.panelVideoPreview.Size = new System.Drawing.Size(320, 240);
            this.panelVideoPreview.TabIndex = 0;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(16, 240);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(94, 32);
            this.btnPreview.TabIndex = 1;
            this.btnPreview.Text = "Prikaz";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 510);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1028, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // lstVideoDevices
            // 
            this.lstVideoDevices.FormattingEnabled = true;
            this.lstVideoDevices.Location = new System.Drawing.Point(16, 12);
            this.lstVideoDevices.Name = "lstVideoDevices";
            this.lstVideoDevices.Size = new System.Drawing.Size(338, 108);
            this.lstVideoDevices.TabIndex = 3;
            // 
            // lstAudioDevices
            // 
            this.lstAudioDevices.FormattingEnabled = true;
            this.lstAudioDevices.Location = new System.Drawing.Point(16, 126);
            this.lstAudioDevices.Name = "lstAudioDevices";
            this.lstAudioDevices.Size = new System.Drawing.Size(338, 108);
            this.lstAudioDevices.TabIndex = 4;
            // 
            // lblVideoDeviceSelectedForPreview
            // 
            this.lblVideoDeviceSelectedForPreview.AutoSize = true;
            this.lblVideoDeviceSelectedForPreview.Location = new System.Drawing.Point(16, 318);
            this.lblVideoDeviceSelectedForPreview.Name = "lblVideoDeviceSelectedForPreview";
            this.lblVideoDeviceSelectedForPreview.Size = new System.Drawing.Size(173, 13);
            this.lblVideoDeviceSelectedForPreview.TabIndex = 6;
            this.lblVideoDeviceSelectedForPreview.Text = "lblVideoDeviceSelectedForPreview";
            // 
            // lblAudioDeviceSelectedForPreview
            // 
            this.lblAudioDeviceSelectedForPreview.AutoSize = true;
            this.lblAudioDeviceSelectedForPreview.Location = new System.Drawing.Point(16, 342);
            this.lblAudioDeviceSelectedForPreview.Name = "lblAudioDeviceSelectedForPreview";
            this.lblAudioDeviceSelectedForPreview.Size = new System.Drawing.Size(173, 13);
            this.lblAudioDeviceSelectedForPreview.TabIndex = 7;
            this.lblAudioDeviceSelectedForPreview.Text = "lblAudioDeviceSelectedForPreview";
            // 
            // btnGrabImage
            // 
            this.btnGrabImage.Enabled = false;
            this.btnGrabImage.Location = new System.Drawing.Point(250, 240);
            this.btnGrabImage.Name = "btnGrabImage";
            this.btnGrabImage.Size = new System.Drawing.Size(94, 32);
            this.btnGrabImage.TabIndex = 8;
            this.btnGrabImage.Text = "Uslikaj";
            this.btnGrabImage.UseVisualStyleBackColor = true;
            this.btnGrabImage.Click += new System.EventHandler(this.cmdGrabImage_Click);
            // 
            // Kamera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 532);
            this.Controls.Add(this.btnGrabImage);
            this.Controls.Add(this.lblAudioDeviceSelectedForPreview);
            this.Controls.Add(this.lblVideoDeviceSelectedForPreview);
            this.Controls.Add(this.lstAudioDevices);
            this.Controls.Add(this.lstVideoDevices);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.panelVideoPreview);
            this.Name = "Kamera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Kamera_FormClosing);
            this.Load += new System.EventHandler(this.Kamera_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelVideoPreview;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ListBox lstVideoDevices;
        private System.Windows.Forms.ListBox lstAudioDevices;
        private System.Windows.Forms.Label lblVideoDeviceSelectedForPreview;
        private System.Windows.Forms.Label lblAudioDeviceSelectedForPreview;
        private System.Windows.Forms.Button btnGrabImage;
    }
}


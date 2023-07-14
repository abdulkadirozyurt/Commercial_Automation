
namespace Ticari_Otomasyon
{
    partial class FormMail
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
            this.label1 = new System.Windows.Forms.Label();
            this.textEdit_email = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_subject = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox_mailContent = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.simpleButton_send = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_email.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_subject.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mail Adresi";
            // 
            // textEdit_email
            // 
            this.textEdit_email.Location = new System.Drawing.Point(244, 226);
            this.textEdit_email.Name = "textEdit_email";
            this.textEdit_email.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEdit_email.Properties.Appearance.Options.UseFont = true;
            this.textEdit_email.Size = new System.Drawing.Size(202, 26);
            this.textEdit_email.TabIndex = 1;
            // 
            // textEdit_subject
            // 
            this.textEdit_subject.Location = new System.Drawing.Point(244, 258);
            this.textEdit_subject.Name = "textEdit_subject";
            this.textEdit_subject.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEdit_subject.Properties.Appearance.Options.UseFont = true;
            this.textEdit_subject.Size = new System.Drawing.Size(202, 26);
            this.textEdit_subject.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Konu";
            // 
            // richTextBox_mailContent
            // 
            this.richTextBox_mailContent.Location = new System.Drawing.Point(244, 290);
            this.richTextBox_mailContent.Name = "richTextBox_mailContent";
            this.richTextBox_mailContent.Size = new System.Drawing.Size(202, 120);
            this.richTextBox_mailContent.TabIndex = 4;
            this.richTextBox_mailContent.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mesaj";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureEdit1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 162);
            this.panel1.TabIndex = 6;
            // 
            // simpleButton_send
            // 
            this.simpleButton_send.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton_send.Appearance.Options.UseFont = true;
            this.simpleButton_send.Location = new System.Drawing.Point(371, 425);
            this.simpleButton_send.Name = "simpleButton_send";
            this.simpleButton_send.Size = new System.Drawing.Size(75, 23);
            this.simpleButton_send.TabIndex = 7;
            this.simpleButton_send.Text = "GÖNDER";
            this.simpleButton_send.Click += new System.EventHandler(this.simpleButton_send_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::Ticari_Otomasyon.Properties.Resources._360_F_298733817_4721ndxzrFXWfFw3ra7vpQ3rM9Jph22c;
            this.pictureEdit1.Location = new System.Drawing.Point(0, 0);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(560, 162);
            this.pictureEdit1.TabIndex = 0;
            // 
            // FormMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 536);
            this.Controls.Add(this.simpleButton_send);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox_mailContent);
            this.Controls.Add(this.textEdit_subject);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textEdit_email);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FormMail";
            this.Text = "FormMail";
            this.Load += new System.EventHandler(this.FormMail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_email.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_subject.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit textEdit_email;
        private DevExpress.XtraEditors.TextEdit textEdit_subject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox_mailContent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton_send;
    }
}
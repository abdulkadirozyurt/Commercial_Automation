
namespace Ticari_Otomasyon
{
    partial class FormEmployees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmployees));
            this.comboBoxEdit_district = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboBoxEdit_city = new DevExpress.XtraEditors.ComboBoxEdit();
            this.maskedTextBox_identityNumber = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_phoneNumber1 = new System.Windows.Forms.MaskedTextBox();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_position = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton_delete = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_update = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_save = new DevExpress.XtraEditors.SimpleButton();
            this.richTextBox_Address = new System.Windows.Forms.RichTextBox();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_lastName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_email = new DevExpress.XtraEditors.TextEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_firstName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_id = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton_clean = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit_district.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit_city.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_position.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_lastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_email.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_firstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxEdit_district
            // 
            this.comboBoxEdit_district.Location = new System.Drawing.Point(98, 250);
            this.comboBoxEdit_district.Name = "comboBoxEdit_district";
            this.comboBoxEdit_district.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxEdit_district.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEdit_district.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit_district.Size = new System.Drawing.Size(117, 24);
            this.comboBoxEdit_district.TabIndex = 8;
            // 
            // comboBoxEdit_city
            // 
            this.comboBoxEdit_city.Location = new System.Drawing.Point(98, 220);
            this.comboBoxEdit_city.Name = "comboBoxEdit_city";
            this.comboBoxEdit_city.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxEdit_city.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEdit_city.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit_city.Properties.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdit_city_Properties_SelectedIndexChanged);
            this.comboBoxEdit_city.Size = new System.Drawing.Size(117, 24);
            this.comboBoxEdit_city.TabIndex = 7;
            // 
            // maskedTextBox_identityNumber
            // 
            this.maskedTextBox_identityNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextBox_identityNumber.Location = new System.Drawing.Point(98, 157);
            this.maskedTextBox_identityNumber.Mask = "00000000000";
            this.maskedTextBox_identityNumber.Name = "maskedTextBox_identityNumber";
            this.maskedTextBox_identityNumber.Size = new System.Drawing.Size(117, 24);
            this.maskedTextBox_identityNumber.TabIndex = 5;
            this.maskedTextBox_identityNumber.ValidatingType = typeof(int);
            // 
            // maskedTextBox_phoneNumber1
            // 
            this.maskedTextBox_phoneNumber1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextBox_phoneNumber1.Location = new System.Drawing.Point(98, 127);
            this.maskedTextBox_phoneNumber1.Mask = "(999) 000-0000";
            this.maskedTextBox_phoneNumber1.Name = "maskedTextBox_phoneNumber1";
            this.maskedTextBox_phoneNumber1.Size = new System.Drawing.Size(117, 24);
            this.maskedTextBox_phoneNumber1.TabIndex = 3;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(36, 283);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(56, 18);
            this.labelControl11.TabIndex = 24;
            this.labelControl11.Text = "Pozisyon";
            // 
            // textEdit_position
            // 
            this.textEdit_position.Location = new System.Drawing.Point(98, 280);
            this.textEdit_position.Name = "textEdit_position";
            this.textEdit_position.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEdit_position.Properties.Appearance.Options.UseFont = true;
            this.textEdit_position.Size = new System.Drawing.Size(117, 24);
            this.textEdit_position.TabIndex = 9;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(69, 253);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(23, 18);
            this.labelControl8.TabIndex = 22;
            this.labelControl8.Text = "İlçe";
            // 
            // simpleButton_delete
            // 
            this.simpleButton_delete.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton_delete.Appearance.Options.UseFont = true;
            this.simpleButton_delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton_delete.ImageOptions.Image")));
            this.simpleButton_delete.Location = new System.Drawing.Point(126, 417);
            this.simpleButton_delete.Name = "simpleButton_delete";
            this.simpleButton_delete.Size = new System.Drawing.Size(95, 36);
            this.simpleButton_delete.TabIndex = 12;
            this.simpleButton_delete.Text = "Sil";
            this.simpleButton_delete.Click += new System.EventHandler(this.simpleButton_delete_Click);
            // 
            // simpleButton_update
            // 
            this.simpleButton_update.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton_update.Appearance.Options.UseFont = true;
            this.simpleButton_update.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton_update.ImageOptions.Image")));
            this.simpleButton_update.Location = new System.Drawing.Point(11, 459);
            this.simpleButton_update.Name = "simpleButton_update";
            this.simpleButton_update.Size = new System.Drawing.Size(95, 36);
            this.simpleButton_update.TabIndex = 13;
            this.simpleButton_update.Text = "Güncelle";
            this.simpleButton_update.Click += new System.EventHandler(this.simpleButton_update_Click);
            // 
            // simpleButton_save
            // 
            this.simpleButton_save.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton_save.Appearance.Options.UseFont = true;
            this.simpleButton_save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton_save.ImageOptions.Image")));
            this.simpleButton_save.Location = new System.Drawing.Point(11, 417);
            this.simpleButton_save.Name = "simpleButton_save";
            this.simpleButton_save.Size = new System.Drawing.Size(95, 36);
            this.simpleButton_save.TabIndex = 11;
            this.simpleButton_save.Text = "Kaydet";
            this.simpleButton_save.Click += new System.EventHandler(this.simpleButton_save_Click);
            // 
            // richTextBox_Address
            // 
            this.richTextBox_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox_Address.Location = new System.Drawing.Point(98, 310);
            this.richTextBox_Address.Name = "richTextBox_Address";
            this.richTextBox_Address.Size = new System.Drawing.Size(117, 96);
            this.richTextBox_Address.TabIndex = 10;
            this.richTextBox_Address.Text = "";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(35, 130);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(57, 18);
            this.labelControl10.TabIndex = 18;
            this.labelControl10.Text = "Telefon1";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(52, 99);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(40, 18);
            this.labelControl9.TabIndex = 16;
            this.labelControl9.Text = "Soyad";
            // 
            // textEdit_lastName
            // 
            this.textEdit_lastName.Location = new System.Drawing.Point(98, 96);
            this.textEdit_lastName.Name = "textEdit_lastName";
            this.textEdit_lastName.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEdit_lastName.Properties.Appearance.Options.UseFont = true;
            this.textEdit_lastName.Size = new System.Drawing.Size(117, 24);
            this.textEdit_lastName.TabIndex = 2;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(55, 309);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(37, 18);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "Adres";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(61, 223);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(31, 18);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "Şehir";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(55, 190);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(37, 18);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "E-Mail";
            // 
            // textEdit_email
            // 
            this.textEdit_email.Location = new System.Drawing.Point(98, 187);
            this.textEdit_email.Name = "textEdit_email";
            this.textEdit_email.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEdit_email.Properties.Appearance.Options.UseFont = true;
            this.textEdit_email.Size = new System.Drawing.Size(117, 24);
            this.textEdit_email.TabIndex = 6;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1665, 1041);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(34, 160);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(58, 18);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Kimlik No";
            // 
            // textEdit_firstName
            // 
            this.textEdit_firstName.Location = new System.Drawing.Point(98, 65);
            this.textEdit_firstName.Name = "textEdit_firstName";
            this.textEdit_firstName.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEdit_firstName.Properties.Appearance.Options.UseFont = true;
            this.textEdit_firstName.Size = new System.Drawing.Size(117, 24);
            this.textEdit_firstName.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(75, 68);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(17, 18);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Ad\r\n";
            // 
            // textEdit_id
            // 
            this.textEdit_id.Location = new System.Drawing.Point(98, 34);
            this.textEdit_id.Name = "textEdit_id";
            this.textEdit_id.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEdit_id.Properties.Appearance.Options.UseFont = true;
            this.textEdit_id.Size = new System.Drawing.Size(117, 24);
            this.textEdit_id.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(78, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(14, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Id";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleButton_clean);
            this.groupControl1.Controls.Add(this.comboBoxEdit_district);
            this.groupControl1.Controls.Add(this.comboBoxEdit_city);
            this.groupControl1.Controls.Add(this.maskedTextBox_identityNumber);
            this.groupControl1.Controls.Add(this.maskedTextBox_phoneNumber1);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.textEdit_position);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.simpleButton_delete);
            this.groupControl1.Controls.Add(this.simpleButton_update);
            this.groupControl1.Controls.Add(this.simpleButton_save);
            this.groupControl1.Controls.Add(this.richTextBox_Address);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.textEdit_lastName);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.textEdit_email);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.textEdit_firstName);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.textEdit_id);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl1.Location = new System.Drawing.Point(1671, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(233, 1041);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "groupControl1";
            // 
            // simpleButton_clean
            // 
            this.simpleButton_clean.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton_clean.Appearance.Options.UseFont = true;
            this.simpleButton_clean.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton_clean.ImageOptions.Image")));
            this.simpleButton_clean.Location = new System.Drawing.Point(126, 459);
            this.simpleButton_clean.Name = "simpleButton_clean";
            this.simpleButton_clean.Size = new System.Drawing.Size(95, 36);
            this.simpleButton_clean.TabIndex = 25;
            this.simpleButton_clean.Text = "Temizle";
            this.simpleButton_clean.Click += new System.EventHandler(this.simpleButton_clean_Click);
            // 
            // FormEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FormEmployees";
            this.Text = "FormEmployees";
            this.Load += new System.EventHandler(this.FormEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit_district.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit_city.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_position.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_lastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_email.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_firstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit_district;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit_city;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_identityNumber;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_phoneNumber1;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit textEdit_position;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SimpleButton simpleButton_delete;
        private DevExpress.XtraEditors.SimpleButton simpleButton_update;
        private DevExpress.XtraEditors.SimpleButton simpleButton_save;
        private System.Windows.Forms.RichTextBox richTextBox_Address;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit textEdit_lastName;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit textEdit_email;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textEdit_firstName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEdit_id;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton_clean;
    }
}
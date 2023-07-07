
namespace Ticari_Otomasyon
{
    partial class FormProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProducts));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton_delete = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_update = new DevExpress.XtraEditors.SimpleButton();
            this.maskedTextBox_year = new System.Windows.Forms.MaskedTextBox();
            this.simpleButton_save = new DevExpress.XtraEditors.SimpleButton();
            this.richTextBox_details = new System.Windows.Forms.RichTextBox();
            this.numericUpDown_amount = new System.Windows.Forms.NumericUpDown();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_brand = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_model = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_salePrice = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_purchasePrice = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_name = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_id = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_amount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_brand.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_model.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_salePrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_purchasePrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_id.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1665, 1041);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleButton_delete);
            this.groupControl1.Controls.Add(this.simpleButton_update);
            this.groupControl1.Controls.Add(this.maskedTextBox_year);
            this.groupControl1.Controls.Add(this.simpleButton_save);
            this.groupControl1.Controls.Add(this.richTextBox_details);
            this.groupControl1.Controls.Add(this.numericUpDown_amount);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.textEdit_brand);
            this.groupControl1.Controls.Add(this.textEdit_model);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.textEdit_salePrice);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.textEdit_purchasePrice);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.textEdit_name);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.textEdit_id);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl1.Location = new System.Drawing.Point(1671, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(233, 1041);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "groupControl1";
            // 
            // simpleButton_delete
            // 
            this.simpleButton_delete.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton_delete.Appearance.Options.UseFont = true;
            this.simpleButton_delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton_delete.ImageOptions.Image")));
            this.simpleButton_delete.Location = new System.Drawing.Point(98, 444);
            this.simpleButton_delete.Name = "simpleButton_delete";
            this.simpleButton_delete.Size = new System.Drawing.Size(95, 36);
            this.simpleButton_delete.TabIndex = 20;
            this.simpleButton_delete.Text = "Sil";
            this.simpleButton_delete.Click += new System.EventHandler(this.simpleButton_delete_Click);
            // 
            // simpleButton_update
            // 
            this.simpleButton_update.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton_update.Appearance.Options.UseFont = true;
            this.simpleButton_update.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton_update.ImageOptions.Image")));
            this.simpleButton_update.Location = new System.Drawing.Point(98, 486);
            this.simpleButton_update.Name = "simpleButton_update";
            this.simpleButton_update.Size = new System.Drawing.Size(95, 36);
            this.simpleButton_update.TabIndex = 19;
            this.simpleButton_update.Text = "Güncelle";
            this.simpleButton_update.Click += new System.EventHandler(this.simpleButton_update_Click);
            // 
            // maskedTextBox_year
            // 
            this.maskedTextBox_year.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextBox_year.Location = new System.Drawing.Point(98, 156);
            this.maskedTextBox_year.Mask = "0000";
            this.maskedTextBox_year.Name = "maskedTextBox_year";
            this.maskedTextBox_year.Size = new System.Drawing.Size(117, 26);
            this.maskedTextBox_year.TabIndex = 4;
            this.maskedTextBox_year.ValidatingType = typeof(int);
            // 
            // simpleButton_save
            // 
            this.simpleButton_save.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton_save.Appearance.Options.UseFont = true;
            this.simpleButton_save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton_save.ImageOptions.Image")));
            this.simpleButton_save.Location = new System.Drawing.Point(98, 402);
            this.simpleButton_save.Name = "simpleButton_save";
            this.simpleButton_save.Size = new System.Drawing.Size(95, 36);
            this.simpleButton_save.TabIndex = 9;
            this.simpleButton_save.Text = "Kaydet";
            this.simpleButton_save.Click += new System.EventHandler(this.simpleButton_save_Click);
            // 
            // richTextBox_details
            // 
            this.richTextBox_details.Location = new System.Drawing.Point(98, 286);
            this.richTextBox_details.Name = "richTextBox_details";
            this.richTextBox_details.Size = new System.Drawing.Size(117, 96);
            this.richTextBox_details.TabIndex = 8;
            this.richTextBox_details.Text = "";
            // 
            // numericUpDown_amount
            // 
            this.numericUpDown_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDown_amount.Location = new System.Drawing.Point(98, 188);
            this.numericUpDown_amount.Name = "numericUpDown_amount";
            this.numericUpDown_amount.Size = new System.Drawing.Size(120, 24);
            this.numericUpDown_amount.TabIndex = 5;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(35, 130);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(38, 18);
            this.labelControl10.TabIndex = 18;
            this.labelControl10.Text = "Model";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(33, 99);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(40, 18);
            this.labelControl9.TabIndex = 16;
            this.labelControl9.Text = "Marka";
            // 
            // textEdit_brand
            // 
            this.textEdit_brand.Location = new System.Drawing.Point(98, 96);
            this.textEdit_brand.Name = "textEdit_brand";
            this.textEdit_brand.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEdit_brand.Properties.Appearance.Options.UseFont = true;
            this.textEdit_brand.Size = new System.Drawing.Size(117, 24);
            this.textEdit_brand.TabIndex = 2;
            // 
            // textEdit_model
            // 
            this.textEdit_model.Location = new System.Drawing.Point(98, 127);
            this.textEdit_model.Name = "textEdit_model";
            this.textEdit_model.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEdit_model.Properties.Appearance.Options.UseFont = true;
            this.textEdit_model.Size = new System.Drawing.Size(117, 24);
            this.textEdit_model.TabIndex = 3;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(34, 285);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(39, 18);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "Detay";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(5, 254);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(68, 18);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "Satış Fiyatı";
            // 
            // textEdit_salePrice
            // 
            this.textEdit_salePrice.Location = new System.Drawing.Point(98, 251);
            this.textEdit_salePrice.Name = "textEdit_salePrice";
            this.textEdit_salePrice.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEdit_salePrice.Properties.Appearance.Options.UseFont = true;
            this.textEdit_salePrice.Size = new System.Drawing.Size(117, 24);
            this.textEdit_salePrice.TabIndex = 7;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(15, 223);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(58, 18);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Alış Fiyatı";
            // 
            // textEdit_purchasePrice
            // 
            this.textEdit_purchasePrice.Location = new System.Drawing.Point(98, 220);
            this.textEdit_purchasePrice.Name = "textEdit_purchasePrice";
            this.textEdit_purchasePrice.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEdit_purchasePrice.Properties.Appearance.Options.UseFont = true;
            this.textEdit_purchasePrice.Size = new System.Drawing.Size(117, 24);
            this.textEdit_purchasePrice.TabIndex = 6;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(43, 192);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(30, 18);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Adet";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(59, 161);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(14, 18);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Yıl";
            // 
            // textEdit_name
            // 
            this.textEdit_name.Location = new System.Drawing.Point(98, 65);
            this.textEdit_name.Name = "textEdit_name";
            this.textEdit_name.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEdit_name.Properties.Appearance.Options.UseFont = true;
            this.textEdit_name.Size = new System.Drawing.Size(117, 24);
            this.textEdit_name.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(56, 68);
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
            this.labelControl1.Location = new System.Drawing.Point(59, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(14, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Id";
            // 
            // FormProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FormProducts";
            this.Text = "ÜRÜNLER";
            this.Load += new System.EventHandler(this.FormProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_amount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_brand.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_model.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_salePrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_purchasePrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_id.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.NumericUpDown numericUpDown_amount;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit textEdit_brand;
        private DevExpress.XtraEditors.TextEdit textEdit_model;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit textEdit_salePrice;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit textEdit_purchasePrice;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textEdit_name;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEdit_id;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton_save;
        private System.Windows.Forms.RichTextBox richTextBox_details;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_year;
        private DevExpress.XtraEditors.SimpleButton simpleButton_delete;
        private DevExpress.XtraEditors.SimpleButton simpleButton_update;
    }
}
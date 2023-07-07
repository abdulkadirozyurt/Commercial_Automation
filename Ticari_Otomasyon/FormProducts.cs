using DevExpress.XtraGrid;
using DevExpress.XtraRichEdit.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticari_Otomasyon
{
    public partial class FormProducts : Form
    {
        public FormProducts()
        {
            InitializeComponent();
        }

        MsSqlConnection connection = new MsSqlConnection();

        void ListProducts()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Urunler", connection.ConnectSql());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void FormProducts_Load(object sender, EventArgs e)
        {
            ListProducts();
        }

        private void simpleButton_save_Click(object sender, EventArgs e)
        {
            #region VerileriKaydetme

            SqlCommand command = new SqlCommand("insert into Urunler (UrunAdi,Marka,Model,Yil,Adet,AlisFiyati,SatisFiyati,Aciklama) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", connection.ConnectSql());

            command.Parameters.AddWithValue("@p1", textEdit_name.Text);
            command.Parameters.AddWithValue("@p2", textEdit_brand.Text);
            command.Parameters.AddWithValue("@p3", textEdit_model.Text);
            command.Parameters.AddWithValue("@p4", maskedTextBox_year.Text);
            command.Parameters.AddWithValue("@p5", numericUpDown_amount.Value.ToString());
            command.Parameters.AddWithValue("@p6", decimal.Parse(textEdit_purchasePrice.Text));
            command.Parameters.AddWithValue("@p7", decimal.Parse(textEdit_salePrice.Text));
            command.Parameters.AddWithValue("@p8", richTextBox_details.Text);

            command.ExecuteNonQuery();
            connection.ConnectSql().Close();

            MessageBox.Show("Ürün Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ListProducts();

            #endregion




        }

        private void simpleButton_delete_Click(object sender, EventArgs e)
        {
            SqlCommand deleteCommand = new SqlCommand("delete from Urunler where Id=@p1", connection.ConnectSql());

            deleteCommand.Parameters.AddWithValue("@p1", textEdit_id.Text);

            deleteCommand.ExecuteNonQuery();

            connection.ConnectSql().Close();

            MessageBox.Show("Ürün Silindi");

            ListProducts();

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            textEdit_id.Text = dr["Id"].ToString();
            textEdit_name.Text = dr["UrunAdi"].ToString();
            textEdit_brand.Text = dr["Marka"].ToString();
            textEdit_model.Text = dr["Model"].ToString();
            maskedTextBox_year.Text = dr["Yil"].ToString();
            numericUpDown_amount.Value = int.Parse(dr["Adet"].ToString());
            textEdit_purchasePrice.Text = dr["AlisFiyati"].ToString();
            textEdit_salePrice.Text = dr["SatisFiyati"].ToString();
            richTextBox_details.Text = dr["Aciklama"].ToString();

        }

        private void simpleButton_update_Click(object sender, EventArgs e)
        {
            SqlCommand updateCommand = new SqlCommand("update Urunler set UrunAdi=@p1,Marka=@p1,Model=@p3,Yil=@p4,Adet=@p5,AlisFiyati=@p6,SatisFiyati=@p7,Aciklama=@p8 where Id=@p9", connection.ConnectSql());

            updateCommand.Parameters.AddWithValue("@p1", textEdit_name.Text);
            updateCommand.Parameters.AddWithValue("@p2", textEdit_brand.Text);
            updateCommand.Parameters.AddWithValue("@p3", textEdit_model.Text);
            updateCommand.Parameters.AddWithValue("@p4", maskedTextBox_year.Text);
            updateCommand.Parameters.AddWithValue("@p5", int.Parse(numericUpDown_amount.Value.ToString()));
            updateCommand.Parameters.AddWithValue("@p6", decimal.Parse(textEdit_purchasePrice.Text));
            updateCommand.Parameters.AddWithValue("@p7", decimal.Parse(textEdit_salePrice.Text));
            updateCommand.Parameters.AddWithValue("@p8", richTextBox_details.Text);
            updateCommand.Parameters.AddWithValue("@p9", int.Parse(textEdit_id.Text));

            updateCommand.ExecuteNonQuery();

            connection.ConnectSql().Close();

            MessageBox.Show("Ürün Başarıyla Güncellendi");

            ListProducts();




        }
    }
}

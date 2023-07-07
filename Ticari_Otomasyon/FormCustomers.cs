using DevExpress.XtraRichEdit.Layout;
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
    public partial class FormCustomers : Form
    {
        public FormCustomers()
        {
            InitializeComponent();
        }
        MsSqlConnection connection = new MsSqlConnection();



        void ListCustomers()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Musteriler", connection.ConnectSql());
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }

        void ListCities()
        {
            SqlCommand command = new SqlCommand("select SehirAdi from Sehirler", connection.ConnectSql());
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                comboBoxEdit_city.Properties.Items.Add(dr[0]);
            }
            connection.ConnectSql().Close();

        }

        void ListDistricts()
        {
            SqlCommand command = new SqlCommand("select IlceAdi from Ilceler", connection.ConnectSql());
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                comboBoxEdit_district.Properties.Items.Add(dr[0]);
            }
            connection.ConnectSql().Close();


        }


        private void FormCustomers_Load(object sender, EventArgs e)
        {
            ListCustomers();

            ListCities();
            ListDistricts();

        }

        private void comboBoxEdit_city_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxEdit_district.Properties.Items.Clear();
            comboBoxEdit_district.Text = "";


            SqlCommand command = new SqlCommand("select IlceAdi from Ilceler where SehirId=@p1 order by IlceAdi asc ", connection.ConnectSql());
            command.Parameters.AddWithValue("@p1", comboBoxEdit_city.SelectedIndex + 1);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                comboBoxEdit_district.Properties.Items.Add(dr[0]);
            }
            connection.ConnectSql().Close();


        }

        private void simpleButton_save_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into Musteriler (Ad,Soyad,Telefon1,Telefon2,KimlikNo,Email,Sehir,Ilce,Adres,VergiDairesi) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", connection.ConnectSql());

            command.Parameters.AddWithValue("@p1", textEdit_firstName.Text);
            command.Parameters.AddWithValue("@p2", textEdit_lastName.Text);
            command.Parameters.AddWithValue("@p3", maskedTextBox_phoneNumber1.Text);
            command.Parameters.AddWithValue("@p4", maskedTextBox_phoneNumber2.Text);
            command.Parameters.AddWithValue("@p5", maskedTextBox_identityNumber.Text);
            command.Parameters.AddWithValue("@p6", textEdit_email.Text);
            command.Parameters.AddWithValue("@p7", comboBoxEdit_city.Text);
            command.Parameters.AddWithValue("@p8", comboBoxEdit_district.Text);
            command.Parameters.AddWithValue("@p9", richTextBox_Address.Text);
            command.Parameters.AddWithValue("@p10", textEdit_taxAdministration.Text);
            command.Parameters.AddWithValue("@p11", textEdit_id.Text);

            command.ExecuteNonQuery();
            connection.ConnectSql().Close();

            MessageBox.Show("Müşteri Başarıyla Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ListCustomers();



        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            textEdit_id.Text = dr["Id"].ToString();
            textEdit_firstName.Text = dr["Ad"].ToString();
            textEdit_lastName.Text = dr["Soyad"].ToString();
            maskedTextBox_phoneNumber1.Text = dr["Telefon1"].ToString();
            maskedTextBox_phoneNumber2.Text = dr["Telefon2"].ToString();
            maskedTextBox_identityNumber.Text = dr["KimlikNo"].ToString();
            textEdit_email.Text = dr["Email"].ToString();
            comboBoxEdit_city.Text = dr["Sehir"].ToString();
            comboBoxEdit_district.Text = dr["Ilce"].ToString();
            textEdit_taxAdministration.Text = dr["VergiDairesi"].ToString();
            richTextBox_Address.Text = dr["Adres"].ToString();


        }

        private void simpleButton_delete_Click(object sender, EventArgs e)
        {


            DialogResult dr= MessageBox.Show("İlgili Müşteri Silinecek. Onaylıyor Musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                SqlCommand deleteCommand = new SqlCommand("delete from Musteriler where Id=@p1", connection.ConnectSql());
                deleteCommand.Parameters.AddWithValue("@p1", textEdit_id.Text);

                deleteCommand.ExecuteNonQuery();
                connection.ConnectSql().Close();

                MessageBox.Show("Müşteri Başarıyla Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ListCustomers();
            }
            else
            {
                ListCustomers();
            }


        }

        private void simpleButton_update_Click(object sender, EventArgs e)
        {
            DialogResult dr=MessageBox.Show("İlgili Müşteri Güncellenecek. Onaylıyor Musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                SqlCommand updateCommand = new SqlCommand("update Musteriler set Ad=@p1,Soyad=@p2,Telefon1=@p3,Telefon2=@p4,KimlikNo=@p5,Email=@p6,Sehir=@p7,Ilce=@p8,Adres=@p9,VergiDairesi=@p10 where Id=@p11", connection.ConnectSql());

                updateCommand.Parameters.AddWithValue("@p1", textEdit_firstName.Text);
                updateCommand.Parameters.AddWithValue("@p2", textEdit_lastName.Text);
                updateCommand.Parameters.AddWithValue("@p3", maskedTextBox_phoneNumber1.Text);
                updateCommand.Parameters.AddWithValue("@p4", maskedTextBox_phoneNumber2.Text);
                updateCommand.Parameters.AddWithValue("@p5", maskedTextBox_identityNumber.Text);
                updateCommand.Parameters.AddWithValue("@p6", textEdit_email.Text);
                updateCommand.Parameters.AddWithValue("@p7", comboBoxEdit_city.Text);
                updateCommand.Parameters.AddWithValue("@p8", comboBoxEdit_district.Text);
                updateCommand.Parameters.AddWithValue("@p9", richTextBox_Address.Text);
                updateCommand.Parameters.AddWithValue("@p10", textEdit_taxAdministration.Text);
                updateCommand.Parameters.AddWithValue("@p11", textEdit_id.Text);

                updateCommand.ExecuteNonQuery();

                connection.ConnectSql().Close();

                MessageBox.Show("Müşteri Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ListCustomers();
            }






            ListCustomers();
        }
    }
}

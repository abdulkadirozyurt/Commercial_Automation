using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ticari_Otomasyon
{
    public partial class FormCompanies : Form
    {
        public FormCompanies()
        {
            InitializeComponent();
        }

        MsSqlConnection connection = new MsSqlConnection();

        void ListCompanies()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Firmalar", connection.ConnectSql());
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

        void CariKodAciklamalar()
        {
            SqlCommand command = new SqlCommand("select * from Kodlar", connection.ConnectSql());
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                richTextBox_specialCode1.Text = dr[0].ToString();
                richTextBox_specialCode2.Text = dr[1].ToString();
                richTextBox_specialCode3.Text = dr[2].ToString();
            }
            connection.ConnectSql().Close();
        }

        private void FormCompanies_Load(object sender, EventArgs e)
        {
            ListCompanies();
            ListCities();
            ListDistricts();
            CariKodAciklamalar();
            Clean();

        }

        void Clean()
        {
            textEdit_id.Text = "";
            textEdit_companyTitle.Text = "";
            textEdit1_authorizedEmployee.Text = "";
            textEdit_position.Text = "";
            maskedTextBox_AuthorizedEmployeeIdentityNumber.Text = "";
            textEdit_companySector.Text = "";
            maskedTextBox_phoneNumber1.Text = "";
            maskedTextBox_phoneNumber2.Text = "";
            maskedTextBox_phoneNumber3.Text = "";
            textEdit_email.Text = "";
            maskedTextBox_faxNumber.Text = "";
            comboBoxEdit_city.Text = "";
            comboBoxEdit_district.Text = "";
            textEdit_taxAdministration.Text = "";
            richTextBox_Address.Text = "";
            textEdit_specialCode1.Text = "";
            textEdit_specialCode2.Text = "";
            textEdit_specialCode3.Text = "";
            textEdit_companyTitle.Focus();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                textEdit_id.Text = dr["Id"].ToString();
                textEdit_companyTitle.Text = dr["Unvan"].ToString();
                textEdit1_authorizedEmployee.Text = dr["FirmaYetkilisi"].ToString();
                textEdit_position.Text = dr["FirmaYetkilisiPozisyonu"].ToString();
                maskedTextBox_AuthorizedEmployeeIdentityNumber.Text = dr["YetkiliKimlikNo"].ToString();
                textEdit_companySector.Text = dr["Sektor"].ToString();
                maskedTextBox_phoneNumber1.Text = dr["Telefon1"].ToString();
                maskedTextBox_phoneNumber2.Text = dr["Telefon2"].ToString();
                maskedTextBox_phoneNumber3.Text = dr["Telefon3"].ToString();
                textEdit_email.Text = dr["Email"].ToString();
                maskedTextBox_faxNumber.Text = dr["Fax"].ToString();
                comboBoxEdit_city.Text = dr["Sehir"].ToString();
                comboBoxEdit_district.Text = dr["Ilce"].ToString();
                textEdit_taxAdministration.Text = dr["VergiDairesi"].ToString();
                richTextBox_Address.Text = dr["Adres"].ToString();
                textEdit_specialCode1.Text = dr["OzelKod1"].ToString();
                textEdit_specialCode2.Text = dr["OzelKod2"].ToString();
                textEdit_specialCode3.Text = dr["OzelKod3"].ToString();
            }



        }

        private void simpleButton_save_Click(object sender, EventArgs e)
        {
            SqlCommand addCommand = new SqlCommand("insert into Firmalar (Unvan,FirmaYetkilisi,FirmaYetkilisiPozisyonu,YetkiliKimlikNo,Sektor,Telefon1,Telefon2,Telefon3,Email,Fax,Sehir,Ilce,VergiDairesi,Adres,OzelKod1,OzelKod2,OzelKod3) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17)", connection.ConnectSql());

            addCommand.Parameters.AddWithValue("@p1", textEdit_companyTitle.Text);
            addCommand.Parameters.AddWithValue("@p2", textEdit1_authorizedEmployee.Text);
            addCommand.Parameters.AddWithValue("@p3", textEdit_position.Text);
            addCommand.Parameters.AddWithValue("@p4", maskedTextBox_AuthorizedEmployeeIdentityNumber.Text.ToString());
            addCommand.Parameters.AddWithValue("@p5", labelControl_companySector.Text);
            addCommand.Parameters.AddWithValue("@p6", maskedTextBox_phoneNumber1.Text);
            addCommand.Parameters.AddWithValue("@p7", maskedTextBox_phoneNumber2.Text);
            addCommand.Parameters.AddWithValue("@p8", maskedTextBox_phoneNumber3.Text);
            addCommand.Parameters.AddWithValue("@p9", textEdit_email.Text);
            addCommand.Parameters.AddWithValue("@p10", maskedTextBox_faxNumber.Text);
            addCommand.Parameters.AddWithValue("@p11", comboBoxEdit_city.Text);
            addCommand.Parameters.AddWithValue("@p12", comboBoxEdit_district.Text);
            addCommand.Parameters.AddWithValue("@p13", textEdit_taxAdministration.Text);
            addCommand.Parameters.AddWithValue("@p14", richTextBox_Address.Text);
            addCommand.Parameters.AddWithValue("@p15", richTextBox_specialCode1.Text);
            addCommand.Parameters.AddWithValue("@p16", richTextBox_specialCode2.Text);
            addCommand.Parameters.AddWithValue("@p17", richTextBox_specialCode3.Text);

            addCommand.ExecuteNonQuery();
            connection.ConnectSql().Close();
            MessageBox.Show("Firma Başarıyla Eklendi");
            ListCompanies();
            Clean();


        }

        private void simpleButton_delete_Click(object sender, EventArgs e)
        {
            SqlCommand deleteCommand = new SqlCommand("delete from Firmalar where Id=@p1", connection.ConnectSql());
            deleteCommand.Parameters.AddWithValue("@p1", textEdit_id.Text);
            deleteCommand.ExecuteNonQuery();
            connection.ConnectSql().Close();
            MessageBox.Show("Firma Başarıyla Silindi");
            ListCompanies();
            Clean();

        }

        private void simpleButton_update_Click(object sender, EventArgs e)
        {
            SqlCommand updateCommand = new SqlCommand("update Firmalar set Unvan=@p1,FirmaYetkilisi=@p2,FirmaYetkilisiPozisyonu=@p3,YetkiliKimlikNo=@p4,Sektor=@p5,Telefon1=@p6,Telefon2=@p7,Telefon3=@p8,Email=@p9,Fax=@p10,Sehir=@p11,Ilce=@p12,VergiDairesi=@p13,Adres=@p14,OzelKod1=@p15,OzelKod2=@p16,OzelKod3=@p17 where Id=@p18", connection.ConnectSql());
            updateCommand.Parameters.AddWithValue("@p1", textEdit_companyTitle.Text);
            updateCommand.Parameters.AddWithValue("@p2", textEdit1_authorizedEmployee.Text);
            updateCommand.Parameters.AddWithValue("@p3", textEdit_position.Text);
            updateCommand.Parameters.AddWithValue("@p4", maskedTextBox_AuthorizedEmployeeIdentityNumber.Text);
            updateCommand.Parameters.AddWithValue("@p5", textEdit_companySector.Text);
            updateCommand.Parameters.AddWithValue("@p6", maskedTextBox_phoneNumber1.Text);
            updateCommand.Parameters.AddWithValue("@p7", maskedTextBox_phoneNumber2.Text);
            updateCommand.Parameters.AddWithValue("@p8", maskedTextBox_phoneNumber3.Text);
            updateCommand.Parameters.AddWithValue("@p9", textEdit_email.Text);
            updateCommand.Parameters.AddWithValue("@p10", maskedTextBox_faxNumber.Text);
            updateCommand.Parameters.AddWithValue("@p11", comboBoxEdit_city.Text);
            updateCommand.Parameters.AddWithValue("@p12", comboBoxEdit_district.Text);
            updateCommand.Parameters.AddWithValue("@p13", textEdit_taxAdministration.Text);
            updateCommand.Parameters.AddWithValue("@p14", richTextBox_Address.Text);
            updateCommand.Parameters.AddWithValue("@p15", textEdit_specialCode1.Text);
            updateCommand.Parameters.AddWithValue("@p16", textEdit_specialCode2.Text);
            updateCommand.Parameters.AddWithValue("@p17", textEdit_specialCode3.Text);
            updateCommand.Parameters.AddWithValue("@p18", textEdit_id.Text);

            updateCommand.ExecuteNonQuery();
            connection.ConnectSql().Close();
            MessageBox.Show("Firma Güncellendi");
            ListCompanies();
            Clean();

        }

        private void comboBoxEdit_city_Properties_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxEdit_district.Properties.Items.Clear();
            comboBoxEdit_district.Text = "";

            SqlCommand command = new SqlCommand("select IlceAdi from Ilceler where SehirId=@p1 order by IlceAdi asc", connection.ConnectSql());
            command.Parameters.AddWithValue("@p1", comboBoxEdit_city.SelectedIndex + 1);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                comboBoxEdit_district.Properties.Items.Add(dr[0]);
            }
            connection.ConnectSql().Close();
        }

        private void simpleButton_clean_Click(object sender, EventArgs e)
        {
            Clean();
        }
    }
}

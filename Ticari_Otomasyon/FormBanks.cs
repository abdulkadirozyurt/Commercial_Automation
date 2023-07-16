using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ticari_Otomasyon
{
    public partial class FormBanks : Form
    {
        public FormBanks()
        {
            InitializeComponent();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
        MsSqlConnection connection = new MsSqlConnection();

        void ListCompanies()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select Id,Unvan from Firmalar", connection.ConnectSql());
            da.Fill(dt);
            lookUpEdit_companyName.Properties.NullText = "Firma Seçiniz";
            lookUpEdit_companyName.Properties.ValueMember = "Id";
            lookUpEdit_companyName.Properties.DisplayMember = "Unvan";
            lookUpEdit_companyName.Properties.DataSource = dt;
        }
        void ListBanks()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("exec ListBanksInformations", connection.ConnectSql());
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }
        void ListCities()
        {
            SqlCommand listCitiesCommand = new SqlCommand("select SehirAdi from Sehirler", connection.ConnectSql());
            SqlDataReader dr = listCitiesCommand.ExecuteReader();
            while (dr.Read())
            {
                comboBoxEdit_city.Properties.Items.Add(dr[0]);
            }
            connection.ConnectSql().Close();
        }

        void ListDistricts()
        {
            SqlCommand listDistrictsCommand = new SqlCommand("select IlceAdi from Ilceler", connection.ConnectSql());
            SqlDataReader dr = listDistrictsCommand.ExecuteReader();
            while (dr.Read())
            {
                comboBoxEdit_district.Properties.Items.Add(dr[0]);
            }
            connection.ConnectSql().Close();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            textEdit_id.Text = dr["Id"].ToString();
            textEdit_bankName.Text = dr["BankaAdi"].ToString();
            comboBoxEdit_city.Text = dr["Sehir"].ToString();
            comboBoxEdit_district.Text = dr["Ilce"].ToString();
            textEdit_bankOfficeName.Text = dr["BankaSube"].ToString();
            maskedTextBox_ibanNo.Text = dr["Iban"].ToString();
            textEdit_accountNo.Text = dr["HesapNo"].ToString();
            textEdit_authorizedEmployee.Text = dr["YetkiliKisi"].ToString();
            maskedTextBox_phoneNumber1.Text = dr["Telefon"].ToString();
            maskedTextBox_date.Text = dr["Tarih"].ToString();
            textEdit_accountType.Text = dr["HesapTuru"].ToString();



        }

        private void FormBanks_Load(object sender, EventArgs e)
        {
            ListBanks();
            ListCities();
            ListDistricts();
            ListCompanies();
            Clean();
        }
        void Clean()
        {
            textEdit_id.Text = "";
            textEdit_bankName.Text = "";
            comboBoxEdit_city.Text = "";
            comboBoxEdit_district.Text = "";
            textEdit_bankOfficeName.Text = "";
            maskedTextBox_ibanNo.Text = "";
            textEdit_accountNo.Text = "";
            textEdit_authorizedEmployee.Text = "";
            maskedTextBox_phoneNumber1.Text = "";
            maskedTextBox_date.Text = "";
            textEdit_accountType.Text = "";
            lookUpEdit_companyName.Text = "";
        }

        private void simpleButton_save_Click(object sender, EventArgs e)
        {
            SqlCommand addCommand = new SqlCommand("insert into Bankalar (BankaAdi,Sehir,Ilce,BankaSube,Iban,HesapNo,YetkiliKisi,Telefon,Tarih,HesapTuru,FirmaId) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", connection.ConnectSql());
            addCommand.Parameters.AddWithValue("@p1", textEdit_bankName.Text);
            addCommand.Parameters.AddWithValue("@p2", comboBoxEdit_city.Text);
            addCommand.Parameters.AddWithValue("@p3", comboBoxEdit_district.Text);
            addCommand.Parameters.AddWithValue("@p4", textEdit_bankOfficeName.Text);
            addCommand.Parameters.AddWithValue("@p5", maskedTextBox_ibanNo.Text);
            addCommand.Parameters.AddWithValue("@p6", textEdit_accountNo.Text);
            addCommand.Parameters.AddWithValue("@p7", textEdit_authorizedEmployee.Text);
            addCommand.Parameters.AddWithValue("@p8", maskedTextBox_phoneNumber1.Text);
            addCommand.Parameters.AddWithValue("@p9", maskedTextBox_date.Text);
            addCommand.Parameters.AddWithValue("@p10", textEdit_accountType.Text);
            addCommand.Parameters.AddWithValue("@p11", lookUpEdit_companyName.EditValue);
            addCommand.ExecuteNonQuery();
            connection.ConnectSql().Close();
            MessageBox.Show("Banka Başarıyla Eklendi");
            ListBanks();
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
                comboBoxEdit_district.Properties.Items.Add(dr[0].ToString());
            }
            connection.ConnectSql().Close();
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton_delete_Click(object sender, EventArgs e)
        {
            SqlCommand deleteCommand = new SqlCommand("delete from Bankalar where Id=@p1", connection.ConnectSql());
            deleteCommand.Parameters.AddWithValue("@p1",textEdit_id.Text);
            deleteCommand.ExecuteNonQuery();
            connection.ConnectSql().Close();
            MessageBox.Show("Başarıyla Silindi");
            ListBanks();

            Clean();
        }

        private void simpleButton_clean_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void simpleButton_update_Click(object sender, EventArgs e)
        {
            SqlCommand updateCommand = new SqlCommand("update Bankalar set BankaAdi=@p1,Sehir=@p2,Ilce=@p3,BankaSube=@p4,Iban=@p5,HesapNo=@p6,YetkiliKisi=@p7,Telefon=@p8,Tarih=@p9,HesapTuru=@p10,FirmaId=@p11 where Id=@p12 ",connection.ConnectSql());

            updateCommand.Parameters.AddWithValue("@p1", textEdit_bankName.Text);
            updateCommand.Parameters.AddWithValue("@p2", comboBoxEdit_city.Text);
            updateCommand.Parameters.AddWithValue("@p3", comboBoxEdit_district.Text);
            updateCommand.Parameters.AddWithValue("@p4", textEdit_bankOfficeName.Text);
            updateCommand.Parameters.AddWithValue("@p5", maskedTextBox_ibanNo.Text);
            updateCommand.Parameters.AddWithValue("@p6", textEdit_accountNo.Text);
            updateCommand.Parameters.AddWithValue("@p7", textEdit_authorizedEmployee.Text);
            updateCommand.Parameters.AddWithValue("@p8", maskedTextBox_phoneNumber1.Text);
            updateCommand.Parameters.AddWithValue("@p9", maskedTextBox_date.Text);
            updateCommand.Parameters.AddWithValue("@p10", textEdit_accountType.Text);
            updateCommand.Parameters.AddWithValue("@p11", lookUpEdit_companyName.EditValue);
            updateCommand.Parameters.AddWithValue("@p12", textEdit_id.Text);

            updateCommand.ExecuteNonQuery();
            connection.ConnectSql().Close();
            MessageBox.Show("Başarıyla Güncellendi");
            ListBanks();
            Clean();
        }
    }
}

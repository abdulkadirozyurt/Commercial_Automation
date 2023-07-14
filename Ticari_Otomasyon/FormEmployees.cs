using DevExpress.XtraSpellChecker.Parser;
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
    public partial class FormEmployees : Form
    {
        public FormEmployees()
        {
            InitializeComponent();
        }

        MsSqlConnection connection = new MsSqlConnection();

        void ListEmployees()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Personeller", connection.ConnectSql());
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }

        public void ListCities()
        {
            SqlCommand command = new SqlCommand("select SehirAdi from Sehirler", connection.ConnectSql());
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                comboBoxEdit_city.Properties.Items.Add(dr[0]);
            }
            connection.ConnectSql().Close();
        }

        public void ListDistricts()
        {
            SqlCommand command = new SqlCommand("select IlceAdi from Ilceler", connection.ConnectSql());
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                comboBoxEdit_district.Properties.Items.Add(dr[0]);
            }
            connection.ConnectSql().Close();
        }

        void Clean()
        {
            textEdit_id.Text = "";
            textEdit_firstName.Text = "";
            textEdit_lastName.Text = "";
            maskedTextBox_phoneNumber1.Text = "";
            maskedTextBox_identityNumber.Text = "";
            textEdit_email.Text = "";
            comboBoxEdit_city.Text = "";
            comboBoxEdit_district.Text = "";
            textEdit_position.Text = "";
            richTextBox_Address.Text = "";
        }

        private void FormEmployees_Load(object sender, EventArgs e)
        {
            ListEmployees();
            ListCities();
            ListDistricts();
            Clean();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                textEdit_id.Text = dr["Id"].ToString();
                textEdit_firstName.Text = dr["Ad"].ToString();
                textEdit_lastName.Text = dr["Soyad"].ToString();
                maskedTextBox_phoneNumber1.Text = dr["Telefon"].ToString();
                maskedTextBox_identityNumber.Text = dr["KimlikNo"].ToString();
                textEdit_email.Text = dr["Email"].ToString();
                comboBoxEdit_city.Text = dr["Sehir"].ToString();
                comboBoxEdit_district.Text = dr["Ilce"].ToString();
                textEdit_position.Text = dr["Pozisyon"].ToString();
                richTextBox_Address.Text = dr["Adres"].ToString();
            }
        }

        private void simpleButton_save_Click(object sender, EventArgs e)
        {
            SqlCommand addCommand = new SqlCommand("insert into Personeller (Ad,Soyad,Telefon,KimlikNo,Email,Sehir,Ilce,Pozisyon,Adres) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", connection.ConnectSql());

            addCommand.Parameters.AddWithValue("@p1", textEdit_firstName.Text);
            addCommand.Parameters.AddWithValue("@p2", textEdit_lastName.Text);
            addCommand.Parameters.AddWithValue("@p3", maskedTextBox_phoneNumber1.Text);
            addCommand.Parameters.AddWithValue("@p4", maskedTextBox_identityNumber.Text);
            addCommand.Parameters.AddWithValue("@p5", textEdit_email.Text);
            addCommand.Parameters.AddWithValue("@p6", comboBoxEdit_city.Text);
            addCommand.Parameters.AddWithValue("@p7", comboBoxEdit_district.Text);
            addCommand.Parameters.AddWithValue("@p8", textEdit_position.Text);
            addCommand.Parameters.AddWithValue("@p9", richTextBox_Address.Text);

            addCommand.ExecuteNonQuery();
            connection.ConnectSql().Close();
            MessageBox.Show("Personel Başarıyla Eklendi.");
            ListEmployees();
            Clean();




        }

        private void comboBoxEdit_city_Properties_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxEdit_district.Properties.Items.Clear();
            comboBoxEdit_district.Text = "";

            SqlCommand readCommand = new SqlCommand("select IlceAdi from Ilceler where SehirId=@p1", connection.ConnectSql());
            readCommand.Parameters.AddWithValue("@p1", comboBoxEdit_city.SelectedIndex + 1);
            SqlDataReader dr = readCommand.ExecuteReader();
            while (dr.Read())
            {
                comboBoxEdit_district.Properties.Items.Add(dr[0].ToString());
            }
            connection.ConnectSql().Close();

        }

        private void simpleButton_clean_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void simpleButton_delete_Click(object sender, EventArgs e)
        {
            SqlCommand deleteCommand = new SqlCommand("delete from Personeller where Id=@p1", connection.ConnectSql());

            deleteCommand.Parameters.AddWithValue("@p1", textEdit_id.Text);


            deleteCommand.ExecuteNonQuery();
            connection.ConnectSql().Close();
            MessageBox.Show("Personel Başarıyla Silindi.");
            ListEmployees();
            Clean();
        }

        private void simpleButton_update_Click(object sender, EventArgs e)
        {
            SqlCommand updateCommand = new SqlCommand("update Personeller set Ad=@p1,Soyad=@p2,Telefon=@p3,KimlikNo=@p4,Email=@p5,Sehir=@p6,Ilce=@p7,Pozisyon=@p8,Adres=@p9 where Id=@p10", connection.ConnectSql());

            updateCommand.Parameters.AddWithValue("@p1", textEdit_firstName.Text);
            updateCommand.Parameters.AddWithValue("@p2", textEdit_lastName.Text);
            updateCommand.Parameters.AddWithValue("@p3", maskedTextBox_phoneNumber1.Text);
            updateCommand.Parameters.AddWithValue("@p4", maskedTextBox_identityNumber.Text);
            updateCommand.Parameters.AddWithValue("@p5", textEdit_email.Text);
            updateCommand.Parameters.AddWithValue("@p6", comboBoxEdit_city.Text);
            updateCommand.Parameters.AddWithValue("@p7", comboBoxEdit_district.Text);
            updateCommand.Parameters.AddWithValue("@p8", textEdit_position.Text);
            updateCommand.Parameters.AddWithValue("@p9", richTextBox_Address.Text);
            updateCommand.Parameters.AddWithValue("@p10", textEdit_id.Text);

            updateCommand.ExecuteNonQuery();
            connection.ConnectSql().Close();

            MessageBox.Show("Personel Başarıyla güncellendi");
            ListEmployees();
            Clean();
        }
    }
}

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
    public partial class FormOutgoings : Form
    {
        public FormOutgoings()
        {
            InitializeComponent();
        }
        MsSqlConnection connection = new MsSqlConnection();

        private void comboBoxEdit_city_Properties_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void ListOutgoings()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select Id,Ay,Yil as 'Yıl',Elektrik,Su,Dogalgaz as 'Doğalgaz', Internet as 'İnternet', Maaslar as 'Personel Maaşları',Ekstra,Notlar from Giderler", connection.ConnectSql());
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }
        void Clean()
        {
            textEdit_id.Text = "";
            comboBoxEdit_months.Text = "";
            comboBoxEdit_years.Text = "";
            textEdit_water.Text = "";
            textEdit_electric.Text = "";
            textEdit_naturalGas.Text = "";
            textEdit_internet.Text = "";
            textEdit_salaries.Text = "";
            textEdit_ekstras.Text = "";
            richTextBox_notes.Text = "";
        }
        private void FormOutgoings_Load(object sender, EventArgs e)
        {
            ListOutgoings();
            Clean();
        }

        private void simpleButton_save_Click(object sender, EventArgs e)
        {
            SqlCommand addCommand = new SqlCommand("insert into Giderler (Ay,Yil,Elektrik,Su,Dogalgaz,Internet,Maaslar,Ekstra,Notlar) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", connection.ConnectSql()); ;
            addCommand.Parameters.AddWithValue("@p1", comboBoxEdit_months.Text);
            addCommand.Parameters.AddWithValue("@p2", comboBoxEdit_years.Text);
            addCommand.Parameters.AddWithValue("@p3", decimal.Parse(textEdit_electric.Text));
            addCommand.Parameters.AddWithValue("@p4", decimal.Parse(textEdit_water.Text));
            addCommand.Parameters.AddWithValue("@p5", decimal.Parse(textEdit_naturalGas.Text));
            addCommand.Parameters.AddWithValue("@p6", decimal.Parse(textEdit_internet.Text));
            addCommand.Parameters.AddWithValue("@p7", decimal.Parse(textEdit_salaries.Text));
            addCommand.Parameters.AddWithValue("@p8", decimal.Parse (textEdit_ekstras.Text));
            addCommand.Parameters.AddWithValue("@p9", richTextBox_notes.Text);
            addCommand.ExecuteNonQuery();
            connection.ConnectSql().Close();
            MessageBox.Show("Başarıyla Eklendi");
            ListOutgoings();
            Clean();



        }

        void GetDatasFromGridToTools(DataRow dr)
        {
            if (dr != null)
            {
                textEdit_id.Text = dr["Id"].ToString();
                comboBoxEdit_months.Text = dr["Ay"].ToString();
                comboBoxEdit_years.Text = dr["Yıl"].ToString();
                textEdit_water.Text = dr["Su"].ToString();
                textEdit_electric.Text = dr["Elektrik"].ToString();
                textEdit_naturalGas.Text = dr["Doğalgaz"].ToString();
                textEdit_internet.Text = dr["İnternet"].ToString();
                textEdit_salaries.Text = dr["Personel Maaşları"].ToString();
                textEdit_ekstras.Text = dr["Ekstra"].ToString();
                richTextBox_notes.Text = dr["Notlar"].ToString();

            }
        }

        private void simpleButton_delete_Click(object sender, EventArgs e)
        {
            SqlCommand deleteCommand = new SqlCommand("delete from Giderler where Id=@p1", connection.ConnectSql());
            deleteCommand.Parameters.AddWithValue("@p1", int.Parse(textEdit_id.Text));
            deleteCommand.ExecuteNonQuery();
            connection.ConnectSql().Close();
            MessageBox.Show("Başarıyla Silindi");
            ListOutgoings();
            Clean();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            GetDatasFromGridToTools(dr);
        }

        private void simpleButton_clean_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void simpleButton_update_Click(object sender, EventArgs e)
        {
            SqlCommand updateCommand = new SqlCommand("update Giderler set Ay=@p1,Yil=@p2,Elektrik=@p3,Su=@p4,Dogalgaz=@p5,Internet=@p6,Maaslar=@p7,Ekstra=@p8,Notlar=@p9 where Id=@p10",connection.ConnectSql());

            updateCommand.Parameters.AddWithValue("@p1", comboBoxEdit_months.Text);
            updateCommand.Parameters.AddWithValue("@p2", comboBoxEdit_years.Text);
            updateCommand.Parameters.AddWithValue("@p3", decimal.Parse(textEdit_electric.Text));
            updateCommand.Parameters.AddWithValue("@p4", decimal.Parse(textEdit_water.Text));
            updateCommand.Parameters.AddWithValue("@p5", decimal.Parse(textEdit_naturalGas.Text));
            updateCommand.Parameters.AddWithValue("@p6", decimal.Parse(textEdit_internet.Text));
            updateCommand.Parameters.AddWithValue("@p7", decimal.Parse(textEdit_salaries.Text));
            updateCommand.Parameters.AddWithValue("@p8", decimal.Parse(textEdit_ekstras.Text));
            updateCommand.Parameters.AddWithValue("@p9", richTextBox_notes.Text);
            updateCommand.Parameters.AddWithValue("@p10", textEdit_id.Text);
            updateCommand.ExecuteNonQuery();
            connection.ConnectSql().Close();
            MessageBox.Show("Başarıyla Güncellendi.");
            ListOutgoings();
            Clean();
            

        }
    }
}

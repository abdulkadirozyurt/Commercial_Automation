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
    public partial class FormContacts : Form
    {
        public FormContacts()
        {
            InitializeComponent();
        }

        MsSqlConnection connection = new MsSqlConnection();

        void ListCustomers()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select Ad,Soyad,Telefon1,Telefon2,Email from Musteriler ", connection.ConnectSql()); ;
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        
        void ListCompanies()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select Unvan,FirmaYetkilisi,Telefon1,Telefon2,Telefon3,Email,Fax from Firmalar ", connection.ConnectSql()); ;
            da.Fill(dt);
            gridControl2.DataSource = dt;
        }

        private void FormContacts_Load(object sender, EventArgs e)
        {
            ListCustomers();

            ListCompanies();


        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FormMail formMail = new FormMail();
            DataRow dataRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dataRow!=null)
            {
                formMail.mail = dataRow["Email"].ToString();
                formMail.Show();
            }
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            FormMail formMail = new FormMail();
            DataRow dataRow = gridView2.GetDataRow(gridView2.FocusedRowHandle);
            if (dataRow!=null)
            {
                formMail.mail = dataRow["Email"].ToString();
                formMail.Show();
            }
        }
    }
}

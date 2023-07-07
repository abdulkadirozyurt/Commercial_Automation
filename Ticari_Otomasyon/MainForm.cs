using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticari_Otomasyon
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        FormProducts formProducts;
        private void barButtonItem_Products_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (formProducts == null)
            {
                formProducts = new FormProducts();
                formProducts.MdiParent = this;
                formProducts.Show();
            }


        }

        FormCustomers formCustomers;
        private void barButtonItem_Customers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {           
            if (formCustomers == null)
            {
                formCustomers = new FormCustomers();
                formCustomers.MdiParent = this;
                formCustomers.Show();
            }

        }
    }
}

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
        FormCompanies formCompanies;
        private void barButtonItem_Companies_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (formCompanies == null)
            {
                formCompanies = new FormCompanies();
                formCompanies.MdiParent = this;
                formCompanies.Show();

            }
        }

        FormEmployees formEmployees;
        private void barButtonItem_Employees_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (formEmployees == null)
            {
                formEmployees = new FormEmployees();
                formEmployees.MdiParent = this;
                formEmployees.Show();
            }
        }

        FormContacts formContacts;
        private void barButtonItem_Contacts_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (formContacts==null)
            {
                formContacts = new FormContacts();
                formContacts.MdiParent = this;
                formContacts.Show();
            }
        }
        FormOutgoings formOutgoings;
        private void barButtonItem_Outgoings_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (formOutgoings==null)
            {
                formOutgoings = new FormOutgoings();
                formOutgoings.MdiParent = this;
                formOutgoings.Show();
            }
        }
    }
}

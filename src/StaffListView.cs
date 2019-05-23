using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIS
{
    public partial class StaffListView : Form
    {
        public StaffListView()
        {
            InitializeComponent();
            LoadViewItems();

        }

        private void button3_Click( object sender, EventArgs e )
        {

        }

        private void LoadViewItems()
        {
            CustomerGridView.DataSource = Database.CustomerList;
            foreach (Customer c in Database.CustomerList)
            {
                customerBindingSource.Add( c );
            }
        }

        private void CustomerButton_Click( object sender, EventArgs e )
        {
            CustomerListView form = new CustomerListView();
            this.Hide();
            form.Show();
        }

        private void DealerOptButton_Click( object sender, EventArgs e )
        {
            DealerOptionsListView form = new DealerOptionsListView();
            this.Hide();
            form.Show();
        }

        private void InvoiceButton_Click( object sender, EventArgs e )
        {
            InvoiceListView form = new InvoiceListView();
            this.Hide();
            form.Show();
        }

        private void button2_Click( object sender, EventArgs e )
        {
            VehicleListView form = new VehicleListView();
            this.Hide();
            form.Show();
        }
    }
}

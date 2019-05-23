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
    public partial class CustomerListView : Form
    {
        public CustomerListView()
        {
            InitializeComponent();
            LoadViewItems();

        }

        private void SaveButton_Click( object sender, EventArgs e )
        {
            AddCustomer form = new AddCustomer();
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                Database.SaveCustomerList( FilePath.CustomerListPath );
                
                LoadViewItems();
               
            }
        }

        private void LoadViewItems()
        {
            var source = new BindingSource();
            source.DataSource = Database.CustomerList;
            CustomerGridView.DataSource = source;
           
            CustomerGridView.Update();
            CustomerGridView.Refresh();
        }

        private void button2_Click( object sender, EventArgs e )
        {
            this.Hide();
            VehicleListView window = new VehicleListView();
            window.Show();
            

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

        private void StaffButton_Click( object sender, EventArgs e )
        {
            StaffListView form = new StaffListView();
            this.Hide();
            form.Show();
        }

        private void CustomerGridView_CellDoubleClick( object sender, DataGridViewCellEventArgs e )
        {
            // get object from data grid view
            Customer selected = (Customer)CustomerGridView.CurrentRow.DataBoundItem;

            EditCustomer form = new EditCustomer( ref selected );

            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
               
                Database.SaveCustomerList( FilePath.CustomerListPath );

                LoadViewItems();
            }

            
        }

        private void DeleteButton_Click( object sender, EventArgs e )

        {
            AreYouSure d = new AreYouSure();

            d.ShowDialog();

            if (d.DialogResult == DialogResult.OK)
            {
                Customer selected = (Customer)CustomerGridView.CurrentRow.DataBoundItem;

                Database.CustomerList.Remove( selected );
                Database.SaveCustomerList( FilePath.CustomerListPath );

                LoadViewItems();
            }
           

        }
    }
}

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
    // form provides view of customer list for management staffs 
    public partial class CustomerListView : Form
    {
        public CustomerListView()
        {
            InitializeComponent();
            LoadViewItems();
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

        // actually this is add Button 
        private void SaveButton_Click( object sender, EventArgs e )
        {
            AddCustomer form = new AddCustomer();
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {   
                // save current state of customer list to database
                Database.SaveCustomerList();
                // reload data grid view
                LoadViewItems();
            }
        }

        // double-click on selected row to see details and edit
        private void CustomerGridView_CellDoubleClick( object sender, DataGridViewCellEventArgs e )
        {
            // get object from data grid view
            Customer selected = (Customer)CustomerGridView.CurrentRow.DataBoundItem;

            if (selected != null)
            {
                EditCustomer form = new EditCustomer( ref selected );

                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK)
                {
                    // save current state of customer list to database
                    Database.SaveCustomerList();

                    LoadViewItems();
                }
            }
            else
            {
                MessageBox.Show( "No Data chosen!" );
            }         
        }

        // deleted selected customer
        private void DeleteButton_Click( object sender, EventArgs e )
        {
            AreYouSure d = new AreYouSure();

            d.ShowDialog();

            if (d.DialogResult == DialogResult.OK)
            {
                Customer selected = (Customer)CustomerGridView.CurrentRow.DataBoundItem;
                // remove selected customer from customer list (customer collection)
                Database.CustomerList.Remove( selected );
                // save current state of customer list to database
                Database.SaveCustomerList();

                LoadViewItems();
            }
        }
    }
}

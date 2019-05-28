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
    // form provide view of invoice list for management staff
    public partial class InvoiceListView : Form
    {
        public InvoiceListView()
        {
            InitializeComponent();
            LoadViewItems();
        }

        // This is add button
        private void button3_Click( object sender, EventArgs e )
        {
            AddInvoice form = new AddInvoice();
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                 Database.SaveInvoiceList();
                 LoadViewItems();
            }
        }

        private void LoadViewItems()
        {
            // create binding source
            var source = new BindingSource();

            // bind global vehicle list to source, so whenever vehicle list changes, the source will change
            source.DataSource = Database.InvoiceList;

            // set grid's datasource to be source, so grid updates whenever source changes without needing to restart program
            InvoiceGridView.DataSource = source;

            InvoiceGridView.Update();
            InvoiceGridView.Refresh();
        }

      /*  private void TitleLabel_Click( object sender, EventArgs e )
        {

        }*/

        private void CustomerButton_Click( object sender, EventArgs e )
        {
            CustomerListView form = new CustomerListView();
            this.Hide();
            form.Show();
        }

        // vehicle button click
        private void button2_Click( object sender, EventArgs e )
        {
            VehicleListView form = new VehicleListView();
            this.Hide();
            form.Show();
        }

        private void DealerOptButton_Click( object sender, EventArgs e )
        {
            DealerOptionsListView form = new DealerOptionsListView();
            this.Hide();
            form.Show();
        }

        private void StaffButton_Click( object sender, EventArgs e )
        {
            StaffListView form = new StaffListView();
            this.Hide();
            form.Show();
        }

        // double click cell to see invoice's detail and to edit it 
        private void InvoiceGridView_CellDoubleClick( object sender, DataGridViewCellEventArgs e )
        {
            Invoice selected = (Invoice)InvoiceGridView.CurrentRow.DataBoundItem;
            if (selected != null) // cannot read details of empty row
            {
                EditInvoice form = new EditInvoice( ref selected );
                form.ShowDialog();

                if (form.DialogResult == DialogResult.OK)
                {
                    selected.PurchasedVehicle.IsSold = true;
                    Database.SaveVehicleList();
                    Database.SaveInvoiceList();
                    LoadViewItems();
                }
            }
            else
            {
                MessageBox.Show( "No data selected!" );
            }
        }

        private void DeleteButton_Click( object sender, EventArgs e )
        {
            AreYouSure d = new AreYouSure();
            d.ShowDialog();

            if (d.DialogResult == DialogResult.OK)
            {
                Invoice selected = (Invoice)InvoiceGridView.CurrentRow.DataBoundItem;
                if (selected != null)
                {
                    // only not paid invoice is able to be deleted
                    if (selected.IsPaid == false)
                    {
                        // remove not paid invoice from invoice list
                        Database.InvoiceList.Remove( selected );
                        // save current invoice list to database
                        Database.SaveInvoiceList();
                        // reload data grid view of invoice list
                        LoadViewItems();
                        MessageBox.Show( "Invoice deleted!" );
                    }
                    else
                    {
                        MessageBox.Show( "Cannot delete paid invoice!" );
                    }
                }
                else
                {
                    MessageBox.Show( "No data selected for deleting!" );
                }
            }
        }
    }
}

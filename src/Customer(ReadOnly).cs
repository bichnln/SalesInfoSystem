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
    // form provides views of customer list for salesperson
    public partial class Customer_ReadOnly_ : Form
    {
        public Customer selected;
        public Customer_ReadOnly_()
        {
            InitializeComponent();
            LoadViewItems();
            this.DialogResult = DialogResult.None;
        }

        private void LoadViewItems()
        {
            var source = new BindingSource();
            source.DataSource = Database.CustomerList;
            CustomerGridView.DataSource = source;

            CustomerGridView.Update();
            CustomerGridView.Refresh();
        }

        // add new customer
        private void AddButton_Click( object sender, EventArgs e )
        {
            AddCustomer form = new AddCustomer();
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                Database.SaveCustomerList();
                LoadViewItems();
            }
        }

        // edit selected record
        private void CustomerGridView_CellDoubleClick( object sender, DataGridViewCellEventArgs e )
        {
            selected = (Customer)CustomerGridView.CurrentRow.DataBoundItem;
            EditCustomer form = new EditCustomer( ref selected );

            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                // save current state of customer list to database
                Database.SaveCustomerList();
                // reload datagrid view of customer list
                LoadViewItems();
            }
        }
    }
}

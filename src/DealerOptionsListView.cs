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
    public partial class DealerOptionsListView : Form
    {
        public DealerOptionsListView()
        {
            InitializeComponent();
            LoadViewItems();

        }

        private void button3_Click( object sender, EventArgs e )
        {
            AddDealerOption form = new AddDealerOption();
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                Database.SaveDealerOptions();
                LoadViewItems();
            }
        }

        private void LoadViewItems()
        {
            var source = new BindingSource();
            source.DataSource = Database.OptionList;
            OptionGridView.DataSource = source;

            OptionGridView.Update();
            OptionGridView.Refresh();
        }

        private void CustomerButton_Click( object sender, EventArgs e )
        {
            CustomerListView form = new CustomerListView();
            this.Hide();
            form.Show();

        }

        private void button2_Click( object sender, EventArgs e )
        {
            VehicleListView form = new VehicleListView();
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

        private void DeleteButton_Click( object sender, EventArgs e )
        {
            AreYouSure d = new AreYouSure();

            d.ShowDialog();

            if (d.DialogResult == DialogResult.OK)
            {
                DealerOption selected = (DealerOption)OptionGridView.CurrentRow.DataBoundItem;

                Database.OptionList.Remove( selected );
                Database.SaveDealerOptions();

                LoadViewItems();
            }
        }

        private void OptionGridView_CellDoubleClick( object sender, DataGridViewCellEventArgs e )
        {
            // get object from data grid view
            DealerOption selected = (DealerOption)OptionGridView.CurrentRow.DataBoundItem;

            EditDealerOption form = new EditDealerOption( ref selected );

            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {

                Database.SaveCustomerList( FilePath.CustomerListPath );

                LoadViewItems();
            }
        }
    }
}

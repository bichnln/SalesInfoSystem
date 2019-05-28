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
    // form provides read-only view of invoice list for salesperson
    public partial class InvoiceReadOnly : Form
    {
        public InvoiceReadOnly()
        {
            InitializeComponent();
            LoadViewItems();
        }
        private void LoadViewItems()
        {
            var source = new BindingSource();
            source.DataSource = Database.InvoiceList;
            InvoiceGridView.DataSource = source;

            InvoiceGridView.Update();
            InvoiceGridView.Refresh();
        }

        // if user double-click on one cell
        private void CustomerGridView_CellDoubleClick( object sender, DataGridViewCellEventArgs e )
        {
            Invoice selected = (Invoice)InvoiceGridView.CurrentRow.DataBoundItem;

            if (selected != null)
            {
                InvoiceSummary form = new InvoiceSummary(ref selected);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show( "No data chosen!" );
            }
        }
    }
}

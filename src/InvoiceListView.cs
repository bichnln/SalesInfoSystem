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
    public partial class InvoiceListView : Form
    {
        public InvoiceListView()
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
    }
}

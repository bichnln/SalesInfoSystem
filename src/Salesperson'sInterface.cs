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
    // homescreen of salesperson
    public partial class Salesperson_sInterface : Form
    {
        public Salesperson_sInterface()
        {
            InitializeComponent();
        }
        // add invoice button
        private void button3_Click( object sender, EventArgs e )
        {
            AddInvoice form = new AddInvoice();
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                Database.SaveInvoiceList();
                MessageBox.Show( "Invoice added!" );
            }
        }

        private void CustomerButton_Click( object sender, EventArgs e )
        {
            Customer_ReadOnly_ form = new Customer_ReadOnly_();
            form.ShowDialog();
        }

        // Vehicle button       
        private void button2_Click( object sender, EventArgs e )
        {
            VehicleReadOnly form = new VehicleReadOnly();
            form.ShowDialog();
        }

        // DealerOption button
        private void DealerOptButton_Click( object sender, EventArgs e )
        {
            DealerOptionReadOnly form = new DealerOptionReadOnly();
            form.ShowDialog();
        }

        private void InvoiceButton_Click( object sender, EventArgs e )
        {
            InvoiceReadOnly form = new InvoiceReadOnly();
            form.ShowDialog();
        }
    }
}

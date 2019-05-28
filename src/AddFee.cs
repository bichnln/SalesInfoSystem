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
    // forms for adding fee to invoice
    public partial class AddFee : Form
    {
        public Fee createdFee;
        public AddFee()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.None;
        }

        private void SaveButton_Click_1( object sender, EventArgs e )
        {
            string name = NameTB.Text;
            string price = PriceTB.Text;

            string msg = "";

            msg += Validation.EmptyCheck( name, NameLabel.Text );
            msg += Validation.PriceCheck( price, PriceLabel.Text );

            if (msg != "")
            {
                MessageBox.Show( msg );
            }
            else
            {
                // create the fee and assign it to the public fee of the form
                createdFee = new Fee( name, price );

                MessageBox.Show( createdFee.Name + " fee is added!" );
                this.DialogResult = DialogResult.OK;
            }
        }

        private void CancelButton_Click( object sender, EventArgs e )
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}

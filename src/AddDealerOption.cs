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
    // form for adding new dealer-installed options to database
    public partial class AddDealerOption : Form
    {
        public AddDealerOption()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.None;
        }

        private void SaveButton_Click( object sender, EventArgs e )
        {
            string code = CodeTB.Text;
            string desc = DescriptionTB.Text;
            string price = PriceTB.Text;

            string msg = "";

            // validate input
            msg += Validation.EmptyCheck( code, CodeLabel.Text );
            msg += Validation.EmptyCheck( desc, DescriptionLabel.Text );
            msg += Validation.PriceCheck( price, PriceLabel.Text );

            if (msg != "")
            {
                MessageBox.Show( msg );
            }
            else
            {
                // add dealer option to database if all inputs are valid
                DealerOption opt = new DealerOption( code, desc, price );
                // save created option to option list 
                Database.OptionList.Add( opt );

                MessageBox.Show( "Dealer option added successfully!" );
                this.DialogResult = DialogResult.OK;
            }
        }

        private void CancelButton_Click( object sender, EventArgs e )
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}

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
    // forms for editting selected dealer-installed option
    public partial class EditDealerOption : Form
    {
        public DealerOption selected;
        public EditDealerOption( ref DealerOption o )
        {
            InitializeComponent();
            selected = o;

            CodeTB.Text = selected.Code;
            DescriptionTB.Text = selected.Description;
            PriceTB.Text = selected.Price.ToString();

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
                selected.Code = code;
                selected.Description = desc;
                selected.Price = Convert.ToDouble( price );

                MessageBox.Show( "Dealer option's updated!" );
                this.DialogResult = DialogResult.OK;
            }
        }

        private void CancelButton_Click( object sender, EventArgs e )
        {
            this.DialogResult = DialogResult.Cancel;
        }

    }
}

﻿using System;
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
    public partial class AddDealerOption : Form
    {
        public AddDealerOption()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged( object sender, EventArgs e )
        {

        }

        private void SaveButton_Click( object sender, EventArgs e )
        {
            string code = CodeTB.Text;
            string desc = DescriptionTB.Text;
            string price = PriceTB.Text;

            string msg = "";

            this.DialogResult = DialogResult.None;

            msg += Validation.EmptyCheck( code, CodeLabel.Text );
            msg += Validation.EmptyCheck( desc, DescriptionLabel.Text );
            msg += Validation.EmptyCheck( price, PriceLabel.Text );

            if (msg != "")
            {
                MessageBox.Show( msg );
            }
            else
            {
                DealerOption opt = new DealerOption( code, desc, price );
                Database.OptionList.Add( opt );
                MessageBox.Show( "Dealer option added successfully!" );
                this.DialogResult = DialogResult.OK;
            }

        }

        private void CancelButton_Click( object sender, EventArgs e )
        {
            this.Close();
        }
    }
}

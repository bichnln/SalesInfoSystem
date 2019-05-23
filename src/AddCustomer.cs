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
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void FirstnameTB_TextChanged( object sender, EventArgs e )
        {

        }

        
        private void CancelButton_Click( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;
        }

        private void SaveButton_Click( object sender, EventArgs e )
        {
            string firstName = FirstnameTB.Text;
            string lastName = LastnameTB.Text;
            string address = AddressTB.Text;
            string phoneNumber = PhoneTB.Text;

            string msg = "";

            DialogResult = DialogResult.None;

            // check if input is valid
            msg += Validation.EmptyCheck( firstName, "First Name" );
            msg += Validation.EmptyCheck( lastName, "Last Name" );
            msg += Validation.EmptyCheck( address, "Address " );
            msg += Validation.PhoneNumberCheck( phoneNumber );

            if (msg != "")
            {
                MessageBox.Show( msg );
            }
            else
            {
                Customer c = new Customer( firstName, lastName, address, phoneNumber );
                Database.CustomerList.Add( c );
                


                MessageBox.Show( "New customer added!" );
                DialogResult = DialogResult.OK;
            }

        }
    }
}

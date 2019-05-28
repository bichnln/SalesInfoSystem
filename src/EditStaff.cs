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
    // form for editting information of staff
    public partial class EditStaff : Form
    {
        public Human selected;
        public EditStaff(ref Human s)
        {
            InitializeComponent();
            DialogResult = DialogResult.None;
            selected = s;

            RoleComboBox.Items.Add( s.Role );

            FormTitleLabel.Text = (s.LastName + "'s Details");
            FirstnameTB.Text = selected.FirstName;
            LastnameTB.Text = selected.LastName;
            AddressTB.Text = selected.Address;
            PhoneTB.Text = selected.PhoneNumber;
        }

        private void SaveButton_Click_1( object sender, EventArgs e )
        {
            string firstName = FirstnameTB.Text;
            string lastName = LastnameTB.Text;
            string address = AddressTB.Text;
            string phoneNumber = PhoneTB.Text;

            string msg = "";

            // check if input is valid
            msg += Validation.EmptyCheck( firstName, FirstnameLabel.Text );
            msg += Validation.EmptyCheck( lastName, LastnameLabel.Text );
            msg += Validation.EmptyCheck( address, AddressLabel.Text );
            msg += Validation.PhoneNumberCheck( phoneNumber );

            if (msg != "")
            {
                MessageBox.Show( msg );
            }
            else
            {
                selected.FirstName = firstName;
                selected.LastName = lastName;
                selected.Address = address;
                selected.PhoneNumber = phoneNumber;

                this.DialogResult = DialogResult.OK;
            }
        }

        private void CancelButton_Click( object sender, EventArgs e )
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}

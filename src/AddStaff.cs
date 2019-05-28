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
    // form for adding new staff
    public partial class AddStaff : Form
    {
        public AddStaff()
        {
            InitializeComponent();
            DialogResult = DialogResult.None;
            RoleComboBox.Items.Add( "Salesperson" );
            RoleComboBox.Items.Add( "Management Staff" );
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

            if (msg != "" || RoleComboBox.SelectedItem == null)
            {
                MessageBox.Show( msg );
            }
            else
            {
                StaffFactory factory;
                Human staff;

                var selected = RoleComboBox.GetItemText( RoleComboBox.SelectedItem );

                if (selected == "Salesperson")
                {
                    factory = new SalespersonFactory( firstName, lastName, address, phoneNumber );
                    staff = factory.GetStaff();
                    Database.StaffList.Add( staff ); 
                }

                else if (selected == "Management Staff")
                {
                    factory = new ManagementStaffFactory( firstName, lastName, address, phoneNumber );

                    staff = factory.GetStaff();
                    // add staff to staff list
                    Database.StaffList.Add( staff );
                }

                MessageBox.Show( Database.StaffList[2].FullName + " created!" );
                DialogResult = DialogResult.OK;
            }
        }

        private void CancelButton_Click( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}

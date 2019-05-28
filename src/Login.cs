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
    // form prompts user to login to proceed 
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.None;
        }

        private void LoginButton_Click( object sender, EventArgs e )
        {
            string account = AccountTB.Text;
            string password = PasswordTB.Text;

            string msg = "";

            msg += Validation.EmptyCheck( account, AccountLabel.Text );
            msg += Validation.EmptyCheck( password, PasswordLabel.Text );

            if (msg != "")
            {
                MessageBox.Show( msg );
            }
            else
            {
                int index = Database.StaffList.FindIndex( s => s.Account == account );

                // if entered account and passoword  are valid
                if ((index >= 0) && (Database.StaffList[index].Password == password))
                {
                    // system behaves based on the role of the staff logging in to the system
                    if (Database.StaffList[index].Role == "Management Staff")
                    {
                        CustomerListView form = new CustomerListView();
                        form.Show();
                    }
                    else if (Database.StaffList[index].Role == "Salesperson")
                    {
                        Salesperson_sInterface form = new Salesperson_sInterface();
                        form.Show();
                    }

                    CurrentSession.Account = Database.StaffList[index];
                    MessageBox.Show( "Hi " + CurrentSession.Account.FullName );
                    this.Hide();
                }
                else
                {
                    MessageBox.Show( "Account not available or wrong password!" );
                }
            }
        }
    }
}

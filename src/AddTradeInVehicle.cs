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
    public partial class AddTradeInVehicle : Form
    {
        public AddTradeInVehicle()
        {
            InitializeComponent();
        }

        private void FirstnameTB_TextChanged( object sender, EventArgs e )
        {

        }

        private void SaveButton_Click( object sender, EventArgs e )
        {
            string firstName = NameTB.Text;
            string lastName = ModelTB.Text;
            string address = ManuTB.Text;
            string phoneNumber = YearTB.Text;

            Customer c = new Customer( firstName, lastName, address, phoneNumber );

            Database.CustomerList.Add( c );

            MessageBox.Show( Database.CustomerList[3].FullName );
        }

        private void YearLabel_Click( object sender, EventArgs e )
        {

        }
    }
}

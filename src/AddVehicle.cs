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
    public partial class AddVehicle : Form
    {
        public AddVehicle()
        {
            InitializeComponent();
        }

       

        private void SaveButton_Click( object sender, EventArgs e )
        {
            
                

            
        }

        private void YearLabel_Click( object sender, EventArgs e )
        {

        }

        private void FormTitleLabel_Click( object sender, EventArgs e )
        {

        }

        private void SaveButton_Click_1( object sender, EventArgs e )
        {
            string name = NameTB.Text;
            string model = ModelTB.Text;
            string year = YearTB.Text;
            string manu = ManuTB.Text;
            string cost = BaseCostTB.Text;

            string msg = "";

            DialogResult = DialogResult.None;

            // check if input is valid
            msg += Validation.EmptyCheck( name, "Name" );
            msg += Validation.EmptyCheck( model, "Model" );
            msg += Validation.EmptyCheck( year, "Year" );
            msg += Validation.EmptyCheck( cost, "Base Cost" );
            msg += Validation.EmptyCheck( manu, "Manufacturer" );

            if (msg != "")
            {
                MessageBox.Show( msg );
                
            }
            else
            {
                NewVehicle v = new NewVehicle( name, model, year, cost, manu );
                Database.VehicleList.Add( v );
                MessageBox.Show( "New customer added!" );
                DialogResult = DialogResult.OK;
            }
        }

        private void CancelButton_Click( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;
            
        }
    }
}

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
            DialogResult = DialogResult.None;
        }

        private void SaveButton_Click_1( object sender, EventArgs e )
        {
            string name = NameTB.Text;
            string model = ModelTB.Text;
            string year = YearTB.Text;
            string make = MakeTB.Text;

            string msg = "";

            // check if input is valid
            msg += Validation.EmptyCheck( name, NameLabel.Text );
            msg += Validation.EmptyCheck( model, ModelLabel.Text );
            msg += Validation.YearCheck( year);
            msg += Validation.EmptyCheck( make, MakeLabel.Text );

            if (msg != "")
            {
                MessageBox.Show( msg );
            }
            else
            {
                TradeInVehicle v = new TradeInVehicle( name, model, year, make );
                // add v to vehicle list
                Database.VehicleList.Add( v );
                MessageBox.Show( "Trade-in vehicle added!" );
                DialogResult = DialogResult.OK;
            }
        }
    }
}

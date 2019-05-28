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
    public partial class EditTradeInVehicle : Form
    {
        public TradeInVehicle selectedV;
        public EditTradeInVehicle(ref TradeInVehicle v)
        {
            InitializeComponent();
            DialogResult = DialogResult.None;

            selectedV = v;

            NameTB.Text = selectedV.Name;
            YearTB.Text = selectedV.Year;
            ModelTB.Text = selectedV.Model;
            MakeTB.Text = selectedV.Make;
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
            msg += Validation.YearCheck( year );
            msg += Validation.EmptyCheck( make, MakeLabel.Text );

            if (selectedV.IsSold == false)
            {
                if (msg != "")
                {
                    MessageBox.Show( msg );
                }
                else
                {
                    selectedV.Name = name;
                    selectedV.Model = model;
                    selectedV.Year = year;
                    selectedV.Make = make;

                    MessageBox.Show( "Vehicle is edited!" );
                    this.DialogResult = DialogResult.OK;
                }
            }
            else
            {
                MessageBox.Show( "Cannot edit sold vehicle!" );
                this.DialogResult = DialogResult.Cancel;
            }
            
        }

        private void CancelButton_Click( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}

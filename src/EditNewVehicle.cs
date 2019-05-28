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
    // form for editting selected vehicle's details of NewVehicle
    public partial class EditNewVehicle : Form
    {
        public NewVehicle selected;
        public EditNewVehicle(ref NewVehicle v)
        {
            InitializeComponent();
            selected = v;

            this.DialogResult = DialogResult.None;

            NameTB.Text = selected.Name;
            ModelTB.Text = selected.Model;
            YearTB.Text = selected.Year;
            ManuTB.Text = selected.Manufacturer;
            BaseCostTB.Text = selected.BaseCost.ToString();   
        }

        private void SaveButton_Click_1( object sender, EventArgs e )
        {
            string name = NameTB.Text;
            string model = ModelTB.Text;
            string year = YearTB.Text;
            string manu = ManuTB.Text;
            string cost = BaseCostTB.Text;

            string msg = "";

            // check if input is valid
            msg += Validation.EmptyCheck( name, NameLabel.Text );
            msg += Validation.EmptyCheck( model, ModelLabel.Text );
            msg += Validation.YearCheck( year);
            msg += Validation.EmptyCheck( manu, ManuLabel.Text );
            msg += Validation.PriceCheck( cost, BaseCostLabel.Text );

            if (selected.IsSold == false)
            {
                if (msg != "")
                {
                    MessageBox.Show( msg );
                }
                else
                {
                    selected.Name = name;
                    selected.Model = model;
                    selected.Year = year;
                    selected.Manufacturer = manu;
                    selected.BaseCost = Convert.ToDouble( cost );

                    MessageBox.Show( "Vehicle is edited!" );
                    this.DialogResult = DialogResult.OK;
                }
            }
            else
            {
                MessageBox.Show( "Cannot edit sold vehicle" );
                this.DialogResult = DialogResult.Cancel;
            }
           
        }

        private void CancelButton_Click( object sender, EventArgs e )
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}

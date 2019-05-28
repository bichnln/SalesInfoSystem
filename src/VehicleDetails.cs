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
    // form display selected vehicle's details
    public partial class VehicleDetails : Form
    {
        public VehicleDetails(ref Vehicle v)
        {
            InitializeComponent();
            FormTitleLabel.Text = v.Name + "'s Details";

            NameTB.Text = v.Name;
            ModelTB.Text = v.Model;
            YearTB.Text = v.Year;

            if (v.VehicleType == "New Vehicle")
            {
                NewVehicle temp = (NewVehicle)v;
                BaseCostTB.Text = temp.BaseCost.ToString();
                ManuTB.Text = temp.Manufacturer;
            }
            else
            {
                TradeInVehicle temp = (TradeInVehicle)v;
                MakeTB.Text = temp.Make;
            }
        }
    }
}

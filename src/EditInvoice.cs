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
    // form for editting selected invoice
    public partial class EditInvoice : Form
    {
        private Invoice invoice = new Invoice();
        public EditInvoice(ref Invoice i)
        {
            InitializeComponent();
            invoice = i;

            this.DialogResult = DialogResult.None;

            // display details of Invoice i
            CustomerTB.Text = invoice.CustomerName;
            PVNameTB.Text = invoice.PurchasedVehicle.Name;
            PVModelTB.Text = invoice.PurchasedVehicle.Model;
            PVYearTB.Text = invoice.PurchasedVehicle.Year;
            NPriceTB.Text = invoice.NegotiatedPrice.ToString();
            SalespersonTB.Text = invoice.SPerson.FullName;
            FinalPriceTB.Text = invoice.TotalPayment.ToString();

            if (invoice.PurchasedVehicle.VehicleType == "New Vehicle")
            {
                NewVehicle v = (NewVehicle)invoice.PurchasedVehicle;
                PVBaseCostTB.Text = v.BaseCost.ToString();
                PVManuTB.Text = v.Manufacturer;
            }
            else if (invoice.PurchasedVehicle.VehicleType == "Trade-in Vehicle")
            {
                TradeInVehicle v = (TradeInVehicle)invoice.PurchasedVehicle;
                PVMakeTB.Text = v.Make;
            }

            if (invoice.TradedVehicle != null)
            {
                TradeVCB.Checked = true;
                TVNameTB.Text = invoice.TradedVehicle.Name;
                TVModelTB.Text = invoice.TradedVehicle.Model;
                TVYearTB.Text = invoice.TradedVehicle.Year;
                TVMakeTB.Text = invoice.TradedVehicle.Make;
                AllowanceTB.Text = invoice.TradeInAllowance.ToString();
            }

            SumOptionTB.Text = invoice.TotalDealerOptionPrice.ToString();
            TotalFeesTB.Text = invoice.TotalFees.ToString();

            // reload data grid view of invoice.OptList and invoice.FeeList
            LoadOptionListItems();
            LoadFeeListItems();

        }

        private void CustomerBrowseButton_Click( object sender, EventArgs e )
        {
            Customer_ReadOnly_ form = new Customer_ReadOnly_();
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                invoice.Cust = form.selected;
                CustomerTB.Text = invoice.Cust.FullName;
            }
        }

        // actually a check-as-paid button
        private void SaveButton_Click_1( object sender, EventArgs e )
        {
            AreYouSure d = new AreYouSure();
            d.ShowDialog();
            if (d.DialogResult == DialogResult.OK)
            {
                if (invoice.IsPaid == false )
                {
                    if (invoice.TradedVehicle != null)
                    {
                        Database.VehicleList.Add( invoice.TradedVehicle );
                    }
                    invoice.IsPaid = true;

                    // find vehicle in list and change its status of being sold to true
                    Database.VehicleList.Find( v => v.SerialNumber == invoice.PurchasedVehicle.SerialNumber ).IsSold = true;

                    // save current vehicle list
                    Database.SaveVehicleList();

                    MessageBox.Show( "Invoice is marked as paid!" );
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show( "Invoice has already been paid!" );
                }
            }
        }

        private void LoadOptionListItems()
        {
            var source = new BindingSource();
            source.DataSource = invoice.OptList;
            OptionGridView.DataSource = source;

            OptionGridView.Update();
            OptionGridView.Refresh();
        }

        private void LoadFeeListItems()
        {
            var source = new BindingSource();

            source.DataSource = invoice.FeeList;
            FeeGridView.DataSource = source;

            FeeGridView.Update();
            FeeGridView.Refresh();
        }

        private void CancelButton_Click_1( object sender, EventArgs e )
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void SaveButton_Click_2( object sender, EventArgs e )
        {
            this.DialogResult = DialogResult.Yes;
        }
    }
}

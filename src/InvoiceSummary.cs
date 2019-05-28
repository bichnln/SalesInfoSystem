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
    // form summarised all details of selected invoice
    public partial class InvoiceSummary : Form
    {
        private Invoice invoice = new Invoice();
        public InvoiceSummary( ref Invoice i )
        {
            InitializeComponent();
            invoice = i;

            this.DialogResult = DialogResult.None;

            CustomerTB.Text = invoice.CustomerName;
            PVNameTB.Text = invoice.PurchasedVehicle.Name;
            PVModelTB.Text = invoice.PurchasedVehicle.Model;
            PVYearTB.Text = invoice.PurchasedVehicle.Year;

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
            }

            NPriceTB.Text = invoice.NegotiatedPrice.ToString();
            SumOptionTB.Text = invoice.TotalDealerOptionPrice.ToString();
            TotalFeesTB.Text = invoice.TotalFees.ToString();

            LoadOptionListItems();
            LoadFeeListItems();
        }

      /*  private void CustomerBrowseButton_Click( object sender, EventArgs e )
        {
            Customer_ReadOnly_ form = new Customer_ReadOnly_();
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                invoice.Cust = form.selected;
                CustomerTB.Text = invoice.Cust.FullName;
            }
        }*/

       /* private void TVModelLabel_Click( object sender, EventArgs e )
        {

        }

        private void SaveButton_Click_1( object sender, EventArgs e )
        {

        }
        */
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

       /* private void EditInvoice_Load( object sender, EventArgs e )
        {

        }*/

        private void CancelButton_Click( object sender, EventArgs e )
        {
            this.DialogResult = DialogResult.Cancel;
        }

        /*private void SumOptionTB_TextChanged( object sender, EventArgs e )
        {

        }*/

       /* private void CheckAsPaid_Click( object sender, EventArgs e )
        {
            AreYouSure d = new AreYouSure();
            d.ShowDialog();
            if (d.DialogResult == DialogResult.OK)
            {
                if (invoice.TradedVehicle != null)
                {
                    Database.VehicleList.Add( invoice.TradedVehicle );
                }

                invoice.IsPaid = true;

                // find vehicle in list and change its status of being sold to true
                Database.VehicleList.Find( v => v.SerialNumber == invoice.PurchasedVehicle.SerialNumber ).IsSold = true;
                Database.SaveInvoiceList();
                Database.SaveVehicleList();
                this.DialogResult = DialogResult.OK;
            }
        }*/
    }
}

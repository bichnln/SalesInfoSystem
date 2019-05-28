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
    // form for add new invoice
    public partial class AddInvoice : Form
    {
        private Invoice invoice = new Invoice();
        public AddInvoice()
        {
            InitializeComponent();

            LoadOptionListItems();

            // 'cause the invoice only get Salesperson object type for the property SPerson, cast the Human-typed account of current session to be salesperson and assign it to invoice.SPerson
            invoice.SPerson = (Salesperson)CurrentSession.Account;

            // set textbox of salesperson to be invoice's SPerson fullname
            SalespersonTB.Text = invoice.SPerson.FullName;
        }
        // browse the customer list
        private void CustomerBrowseButton_Click( object sender, EventArgs e )
        {
            Customer_ReadOnly_ form = new Customer_ReadOnly_();

            form.ShowDialog();

            invoice.Cust = form.selected;
            CustomerTB.Text = invoice.Cust.FullName;
        }

        private void PVBrowseButton_Click( object sender, EventArgs e )
        {
            VehicleReadOnly form = new VehicleReadOnly();

            form.ShowDialog();

            // set the purchased vehicle of invoice to be the selected record of VehicleReadOnly form
            invoice.PurchasedVehicle = form.Selected;

            // display purchased vehicle's details in the text box
            PVNameTB.Text = invoice.PurchasedVehicle.Name;
            PVModelTB.Text = invoice.PurchasedVehicle.Model;
            PVYearTB.Text = invoice.PurchasedVehicle.Year;

            // display information of purchased vehicle based on its type
            if (form.Selected.VehicleType == "Trade-in Vehicle")
            {
                TradeInVehicle temp = (TradeInVehicle)invoice.PurchasedVehicle;
                PVMakeTB.Text = temp.Make;
            }
            else if (form.Selected.VehicleType == "New Vehicle")
            {
                NewVehicle temp = (NewVehicle)invoice.PurchasedVehicle;
                PVBaseCostTB.Text = temp.BaseCost.ToString();
                PVManuTB.Text = temp.Manufacturer;
                
            }
        }

        // add dealer-installed options to invoice
        private void AddOptionButton_Click( object sender, EventArgs e )
        {
            DealerOptionReadOnly form = new DealerOptionReadOnly();

            form.ShowDialog();

            string code = form.Selected.Code;
            string desc = form.Selected.Description;
            double price = form.Selected.Price;

            DealerOption opt = new DealerOption( code, desc, price.ToString() );

            // add options to invoice's list of options
            invoice.OptList.Add( opt );
            // reload the data grid view of options
            LoadOptionListItems();
        }

        private void LoadOptionListItems()
        {
            // bind invoice.OptList to datasource of datagridview DealerOptList
            var source = new BindingSource();
            source.DataSource = invoice.OptList;
            DealerOptList.DataSource = source;

            // reload datagridview DealerOptList
            DealerOptList.Update();
            DealerOptList.Refresh();
        }

        // add fees to invoice
        private void AddFeesButton_Click( object sender, EventArgs e )
        {
            AddFee form = new AddFee();
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                // add created fee to invoice if the DialogResult of creating fee form is OK
                invoice.FeeList.Add( form.createdFee );
                // reload data grid view of invoice's list of fees
                LoadFeeListItems();
            }
        }

        private void LoadFeeListItems()
        {
            // bind invoice.FeeList to data grid view of invoice's fee list FeeListView
            var source = new BindingSource();
            source.DataSource = invoice.FeeList;
            FeeListView.DataSource = source;

            // reload data grid view FeeListView
            FeeListView.Update();
            FeeListView.Refresh();
        }

        private void TradeVCB_CheckedChanged( object sender, EventArgs e )
        {
            // unable to add trade vehicle's info if the box is not checked
            if (!(TradeVCB.Checked == true))
            {
                invoice.TradedVehicle = null;
                TVNameTB.ReadOnly = true;
                TVMakeTB.ReadOnly = true;
                TVYearTB.ReadOnly = true;
                TVModelTB.ReadOnly = true;
            }
            else // allow data added to traded vehicle's section if the check box is checked
            {
                TVNameTB.ReadOnly = false;
                TVMakeTB.ReadOnly = false;
                TVYearTB.ReadOnly = false;
                TVModelTB.ReadOnly = false;
            }
        }
        // "Save" button click
        private void SaveButton_Click_1( object sender, EventArgs e )
        {
            string msg = "";
            string nPrice = NPriceTB.Text;
            string tAllowance = TAllowanceTB.Text;

            // check if invoice has customer / customer has been added to invoice
            if (invoice.Cust == null)
            {
                msg += "Customer is not selected!\n";
            }

            // check if a vehicle has been selected to sell to customer
            if (invoice.PurchasedVehicle == null)
            {
                msg += "Purchased Vehicle is not selected!\n";
            }

            // check if the negotiation price has been added, and if it is valid
            msg += Validation.PriceCheck( nPrice, NPriceTB.Text );

            // if option of trading vehicle is chosen, a vehicle must be chosen and trading allowance must be added
            if (TradeVCB.Checked == true)
            {
                msg += Validation.EmptyCheck( TVNameTB.Text, TVNameLabel.Text );
                msg += Validation.EmptyCheck( TVModelTB.Text, TVModelLabel.Text );
                msg += Validation.EmptyCheck( TVMakeTB.Text, TVMakeLabel.Text );
                msg += Validation.YearCheck( TVYearTB.Text);
                msg += Validation.PriceCheck( tAllowance, TAllowanceLabel.Text );
            }

            if (msg != "")
            {
                MessageBox.Show( msg );
            }
            else
            {
                if (TradeVCB.Checked == true)
                {
                    TradeInVehicle traded = new TradeInVehicle( TVNameTB.Text, TVModelTB.Text, TVYearTB.Text, TVMakeTB.Text );

                    // add trade-in vehicle to invoice
                    invoice.TradedVehicle = traded;

                    // add trade-in allowance to invoice
                    invoice.TradeInAllowance = Convert.ToDouble(tAllowance);
                }
                // set invoice's NegotiatedPrice to be nPrice (has been through validation check) 
                invoice.NegotiatedPrice = Convert.ToDouble( nPrice );
                
           
                EditInvoice form = new EditInvoice( ref invoice );
                form.ShowDialog();

                // DialogResult.OK = Check invoice as paid and save invoice to database
                // DialogResult.Yes = Save invoice to database
                if (form.DialogResult == DialogResult.OK || form.DialogResult == DialogResult.Yes)
                {
                    // save invoice to database
                    Database.InvoiceList.Add( invoice );

                    // save current state of invoice list to database
                    Database.SaveInvoiceList();

                    MessageBox.Show( "Invoice created and added successfully!" );
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        private void CancelButton_Click( object sender, EventArgs e )
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}

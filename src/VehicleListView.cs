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
    // form provides view of vehicle list for management staff
    public partial class VehicleListView : Form
    {
        public VehicleListView()
        {
            InitializeComponent();
            LoadViewItems();
        }

        private void button3_Click( object sender, EventArgs e )
        {
            AddVehicle form = new AddVehicle();
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                Database.SaveVehicleList();

                LoadViewItems();
            }
        }

        private void LoadViewItems()
        {
            // create binding source
            var source = new BindingSource();

            // bind global vehicle list to source, so whenever vehicle list changes, the source will change
            source.DataSource = Database.VehicleList;

            // set grid's datasource to be source, so grid updates whenever source changes without needing to restart program
            VehicleGridView.DataSource = source;

            VehicleGridView.Update();
            VehicleGridView.Refresh();
        }
 
       /* private void VehicleGridView_CellContentClick( object sender, DataGridViewCellEventArgs e )
        {

        }*/

        // delete vehicle
        private void DeleteButton_Click( object sender, EventArgs e )
        {
            AreYouSure d = new AreYouSure();

            d.ShowDialog();

            if (d.DialogResult == DialogResult.OK)
            {
                Vehicle selected = (Vehicle)VehicleGridView.CurrentRow.DataBoundItem;

                if (selected.IsSold == false)
                {
                    Database.VehicleList.Remove( selected );
                    Database.SaveVehicleList();
                    MessageBox.Show( "Vehicle removed!" );
                }
                else
                {
                    MessageBox.Show( "Cannot remove sold vehicles!" );
                }

                LoadViewItems();
            }
        }

        private void CustomerButton_Click( object sender, EventArgs e )
        {
            CustomerListView window = new CustomerListView();
            this.Hide();
            window.Show();
        }

        private void InvoiceButton_Click( object sender, EventArgs e )
        {
            InvoiceListView form = new InvoiceListView();
            form.Show();
            this.Hide();
            
        }

        private void DealerOptButton_Click( object sender, EventArgs e )
        {
            DealerOptionsListView form = new DealerOptionsListView();
            form.Show();
            this.Hide();
        }

        private void StaffButton_Click( object sender, EventArgs e )
        {
            StaffListView form = new StaffListView();
            form.Show();
            this.Hide();
        }

        private void VehicleGridView_CellContentDoubleClick( object sender, DataGridViewCellEventArgs e )
        {
            // get object from data grid view
            Vehicle selected = (Vehicle)VehicleGridView.CurrentRow.DataBoundItem;

                if (selected.VehicleType == "New Vehicle")
                {
                    NewVehicle v = (NewVehicle)selected;

                    EditNewVehicle form = new EditNewVehicle( ref v );

                    form.ShowDialog();

                    if (form.DialogResult == DialogResult.OK)
                    {
                        Database.SaveVehicleList();
                        LoadViewItems();
                    }
                }

                else if (selected.VehicleType == "Trade-in Vehicle")
                {
                    TradeInVehicle v = (TradeInVehicle)selected;
                    EditTradeInVehicle form = new EditTradeInVehicle( ref v );

                    form.ShowDialog();

                    if (form.DialogResult == DialogResult.OK)
                    {
                        Database.SaveVehicleList();
                        LoadViewItems();
                    }
                }
            
        }
    }
}

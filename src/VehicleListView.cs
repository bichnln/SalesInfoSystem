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

        private void CustomerButton_Click( object sender, EventArgs e )
        {
            this.Hide();
            CustomerListView window = new CustomerListView();
            window.Show();
            this.Close();
        }

        private void VehicleGridView_CellContentClick( object sender, DataGridViewCellEventArgs e )
        {

        }

        private void DeleteButton_Click( object sender, EventArgs e )
        {
            AreYouSure d = new AreYouSure();

            d.ShowDialog();

            if (d.DialogResult == DialogResult.OK)
            {
                Vehicle selected = (Vehicle)VehicleGridView.CurrentRow.DataBoundItem;

                Database.VehicleList.Remove( selected );
                Database.SaveVehicleList();

                LoadViewItems();
            }
        }
    }
}

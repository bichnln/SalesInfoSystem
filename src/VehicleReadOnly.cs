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
    public partial class VehicleReadOnly : Form
    {
        public Vehicle Selected;

        public VehicleReadOnly()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.None;

            LoadViewItems();
        }

        private void VehicleGridView_CellContentClick( object sender, DataGridViewCellEventArgs e )
        {

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

        private void VehicleGridView_CellDoubleClick( object sender, DataGridViewCellEventArgs e )
        {
            Selected = (Vehicle)VehicleGridView.CurrentRow.DataBoundItem;
            if (Selected.IsSold == false)
            {
                VehicleDetails form = new VehicleDetails( ref Selected );
                form.ShowDialog();

                if (form.DialogResult == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.OK;
                }
            }
            else
            {
                MessageBox.Show( "Selected vehicle is sold! Please choose another vehicle!" );
            }
            

        }
    }
}

    

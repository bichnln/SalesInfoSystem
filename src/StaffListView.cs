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
    // form provide view of staff list for managemetn staffs
    public partial class StaffListView : Form
    {
        public StaffListView()
        {
            InitializeComponent();
            LoadViewItems();
        }

        // add button
        private void button3_Click( object sender, EventArgs e )
        {
            AddStaff form = new AddStaff();
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                // save current staff list to database
                Database.SaveStaffList();
                LoadViewItems(); 
            }
        }

        private void LoadViewItems()
        {
            // create binding source
            var source = new BindingSource();

            // bind global vehicle list to source, so whenever vehicle list changes, the source will change
            source.DataSource = Database.StaffList;

            // set grid's datasource to be source, so grid updates whenever source changes without needing to restart program
            StaffGridView.DataSource = source;

            StaffGridView.Update();
            StaffGridView.Refresh();
        }

        private void CustomerButton_Click( object sender, EventArgs e )
        {
            CustomerListView form = new CustomerListView();
            this.Hide();
            form.Show();
        }

        private void DealerOptButton_Click( object sender, EventArgs e )
        {
            DealerOptionsListView form = new DealerOptionsListView();
            this.Hide();
            form.Show();
        }

        private void InvoiceButton_Click( object sender, EventArgs e )
        {
            InvoiceListView form = new InvoiceListView();
            this.Hide();
            form.Show();
        }

        // Vehicle button
        private void button2_Click( object sender, EventArgs e )
        {
            VehicleListView form = new VehicleListView();
            this.Hide();
            form.Show();
        }

        private void DeleteButton_Click( object sender, EventArgs e )
        {
            AreYouSure d = new AreYouSure();

            d.ShowDialog();

            if (d.DialogResult == DialogResult.OK)
            {
                Human selected = (Human)StaffGridView.CurrentRow.DataBoundItem;
                if (selected != CurrentSession.Account)
                {
                    Database.StaffList.Remove( selected );

                    Database.SaveStaffList();

                    LoadViewItems();

                    MessageBox.Show( "Staff removed!" );
                }
                else
                {
                    MessageBox.Show( "You cannot remove yourself from the database!" );
                } 
            }
        }
        // edit selected staff record
        private void StaffGridView_CellDoubleClick_1( object sender, DataGridViewCellEventArgs e )
        {
            Human selected = (Human)StaffGridView.CurrentRow.DataBoundItem;

            EditStaff form = new EditStaff( ref selected );

            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                Database.SaveStaffList();
                LoadViewItems();
            }
        }
    }
}

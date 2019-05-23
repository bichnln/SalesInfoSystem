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
    public partial class ListView : Form
    {
        public ListView()
        {
            InitializeComponent();
            listView1.Columns.Add( "First Name" );
            listView1.Columns.Add( "Last Name" );
            listView1.Columns.Add( "Address" );
            listView1.Columns.Add( "Phone Number" );

            foreach (Customer c in Database.CustomerList)
            {
                listView1.Items.Add( new ListViewItem(new[] { c.FirstName, c.LastName, c.Address, c.PhoneNumber } ) );
            }

          //  customerBindingSource.Add( Database.CustomerList[0] );
        }

        private void listView1_SelectedIndexChanged( object sender, EventArgs e )
        {

        }

        private void dataGridView1_CellContentClick( object sender, DataGridViewCellEventArgs e )
        {
            dataGridView1.DataSource = Database.CustomerList;
            
        }
    }
}

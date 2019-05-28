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
{   // form provides read-only view for salesperson to add dealer-installed option to invoice
    public partial class DealerOptionReadOnly : Form
    {
        public DealerOption Selected;

        public DealerOptionReadOnly()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.None;
            LoadViewItems();
        }

        private void LoadViewItems()
        {
            // create binding source
            var source = new BindingSource();

            // bind global vehicle list to source, so whenever vehicle list changes, the source will change
            source.DataSource = Database.OptionList;

            // set grid's datasource to be source, so grid updates whenever source changes without needing to restart program
            DealerOptionGridView.DataSource = source;

            // reload data grid view of dealer option list
            DealerOptionGridView.Update();
            DealerOptionGridView.Refresh();

        }

        private void DealerOptionGridView_CellDoubleClick( object sender, DataGridViewCellEventArgs e )
        {
            Selected = (DealerOption)DealerOptionGridView.CurrentRow.DataBoundItem;

            DealerOptionDetails form = new DealerOptionDetails( ref Selected );

            form.ShowDialog();
            
            if (form.DialogResult == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}

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
    public partial class AreYouSure : Form
    {
        public AreYouSure()
        {
            InitializeComponent();
            DialogResult = DialogResult.None;
        }

        private void YesButton_Click( object sender, EventArgs e )
        {
            DialogResult = DialogResult.OK;
        }

        private void NoButton_Click( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}

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
{     // read-only form for dealer-installed options details
    public partial class DealerOptionDetails : Form
    {
   
        public DealerOptionDetails(ref DealerOption o)
        {
            InitializeComponent();
            TitleLabel.Text = o.Code + "'s Details";

            CodeTB.Text = o.Code;
            DescriptionTB.Text = o.Description;
            PriceTB.Text = o.Price.ToString();
        }

        /*private void textBox1_TextChanged( object sender, EventArgs e )
        {

        }
        */
       
    }
}

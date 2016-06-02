using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SftEngHW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsend_Click(object sender, EventArgs e)
        {
            double dlold = 268, dlyun = 120, sum = 0;
            double oldnum = 0, yunnum = 0, pt = 1;

            if (rb2.Checked)
            {
                dlold = 368;
                dlyun = 150;
            }

            oldnum = Convert.ToDouble(txtold.Text);
            yunnum = Convert.ToDouble(txtyun.Text);

            if (chth.Checked)
            {
                if (chyun.Checked)
                {
                    yunnum -= 1; 
                }
                else
                {
                    oldnum -= 1;
                }
            }
            else if (chten.Checked)
            {
                pt = 0.95;
            }

            sum = ((dlold * oldnum) + (dlyun * yunnum)) * pt;

            txted.Text = sum.ToString() + ",";

        }
        
    }
}

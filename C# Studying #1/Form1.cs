using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ost_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(sNum.Text);
            double b = Convert.ToDouble(tNum.Text);

            if (a / b == 1)
            {
                blueEllipse.Visible = false;
                redEllipse.Visible = true;
            }
            else if (a / b == 2)
            {
                redEllipse.Visible = false;
                blueEllipse.Visible = true;
            }
            else
            {
                redEllipse.Visible = false;
                blueEllipse.Visible = false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _555
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuSlider1_ValueChanged(object sender, EventArgs e)
        {
            if (bunifuSlider1.Value >= 20)
            {
                AbstractConditioner lgConditioner = null;
                Temperature temperature = null;

                lgConditioner = new LgConditioner();
                temperature = lgConditioner.FactoryMethod();
                lgConditioner.AnOperation(lgConditioner.FactoryMethod().ToString());
                bunifuCustomLabel1.Text = lgConditioner.AnOperation("warm");
            }
            else
            {
                AbstractConditioner samsungConditioner = null;
                Temperature temperature = null;

                samsungConditioner = new LgConditioner();
                temperature = samsungConditioner.FactoryMethod();
                samsungConditioner.AnOperation(samsungConditioner.FactoryMethod().ToString());
                bunifuCustomLabel1.Text = samsungConditioner.AnOperation("cold");
            }
        }

        private void bunifuSlider1_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(bunifuCustomLabel1, "Tooltip text");
        }
    }
}

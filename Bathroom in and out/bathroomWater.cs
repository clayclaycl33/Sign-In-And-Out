using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bathroom_in_and_out
{
    public partial class bathroomWater : Form
    {

        private MainFromm _mainForm;

        public bathroomWater(MainFromm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            _mainForm._watercheck = true;

            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            _mainForm._bathroomcheck = true;

            this.Close();

        }
    }
}

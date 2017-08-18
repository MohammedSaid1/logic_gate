using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_5_
{
    public partial class NOR : Form
    {
        public NOR()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true || checkBox2.Checked == true)
                pictureBox3.Visible = false;
            else if (checkBox1.Checked == false && checkBox2.Checked == false)
                pictureBox3.Visible = true; 

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true || checkBox2.Checked == true)
                pictureBox3.Visible = false;
            else if (checkBox1.Checked == false && checkBox2.Checked == false)
                pictureBox3.Visible = true;
        }
    }
}

﻿using System;
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
    public partial class BUFFER : Form
    {
        public BUFFER()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                pictureBox3.Visible = false;
            else
                pictureBox3.Visible = true; 
        }
    }
}

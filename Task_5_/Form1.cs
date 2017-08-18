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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AND an = new AND();
            an.Show(); 
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OR or = new OR();
            or.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NOT not = new NOT();
            not.Show(); 
        }

        private void button10_Click(object sender, EventArgs e)
        {
            NOR nor = new NOR();
            nor.Show(); 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            XOR xor = new XOR();
            xor.Show(); 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            XNOR xnor = new XNOR();
            xnor.Show(); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NAND nand = new NAND();
            nand.Show(); 
        }

        private void button8_Click(object sender, EventArgs e)
        {
            BUFFER buf = new BUFFER();
            buf.Show(); 
        }
    }
}

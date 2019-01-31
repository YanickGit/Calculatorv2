using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatorv2
{
    public partial class frm_Calc : Form
    {
        public frm_Calc()
        {
            InitializeComponent();
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            tb_Main.Text = tb_Main.Text + "0";
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            tb_Main.Text = tb_Main.Text + "1";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            tb_Main.Text = tb_Main.Text + "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            tb_Main.Text = tb_Main.Text + "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            tb_Main.Text = tb_Main.Text + "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            tb_Main.Text = tb_Main.Text + "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            tb_Main.Text = tb_Main.Text + "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            tb_Main.Text = tb_Main.Text + "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            tb_Main.Text = tb_Main.Text + "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            tb_Main.Text = tb_Main.Text + "9";
        }

        private void btn_Dot_Click(object sender, EventArgs e)
        {
            tb_Main.Text = tb_Main.Text + ".";
        }

        private void btn_Plus_Click(object sender, EventArgs e)
        {
            tb_Main.Text = tb_Main.Text + "+";
        }

        private void btn_Minus_Click(object sender, EventArgs e)
        {
            tb_Main.Text = tb_Main.Text + "-";
        }

        private void btn_Multiply_Click(object sender, EventArgs e)
        {
            tb_Main.Text = tb_Main.Text + "*";
        }

        private void btn_Divide_Click(object sender, EventArgs e)
        {
            tb_Main.Text = tb_Main.Text + "/";
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tb_Main.Text = "";
        }

        private void btn_Equal_Click(object sender, EventArgs e)
        {

        }

        
    }
}

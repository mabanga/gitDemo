using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float num, ans;
        int count;
        //Create one method to disable Calculator
        public void DisableCalc()
        {
            txtScreen.Clear();
            txtScreen.Enabled = false;
            btnOFF.Hide();
            btnON.Show();
            btn0.Enabled = false;
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
            btnPoint.Enabled = false;
            btnPlus.Enabled = false;
            btnMoins.Enabled = false;
            btnMultiply.Enabled = false;
            btnDivide.Enabled = false;
            btnClear.Enabled = false;
            btnBackSpace.Enabled = false;
            btnEqual.Enabled = false;

        }
        //Create one method to enable Calculator
        public void EnableCalc()
        {
            txtScreen.Enabled = true;
            btnOFF.Show();
            btnON.Hide();
            btn0.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
            btnPoint.Enabled = true;
            btnPlus.Enabled = true;
            btnMoins.Enabled = true;
            btnMultiply.Enabled = true;
            btnDivide.Enabled = true;
            btnClear.Enabled = true;
            btnBackSpace.Enabled = true;
            btnEqual.Enabled = true;
        }
        public void compute()
        {
            switch (count)
            {
                case 1:
                    ans = num + float.Parse(txtScreen.Text);
                    txtScreen.Text = ans.ToString();
                    break;
                case 2:
                    ans = num - float.Parse(txtScreen.Text);
                    txtScreen.Text = ans.ToString();
                    break;
                case 3:
                    ans = num * float.Parse(txtScreen.Text);
                    txtScreen.Text = ans.ToString();
                    break;
                case 4:
                    if (float.Parse(txtScreen.Text) == 0)
                    {
                        txtScreen.Text = $"Zero not divides.";
                    }
                    else
                    {
                        ans = num / float.Parse(txtScreen.Text);
                        txtScreen.Text = ans.ToString();
                    }

                    break;
                default:
                    break;
            }
        }
        private void btnON_Click(object sender, EventArgs e)
        {
            EnableCalc();
        }
        private void btnPoint_Click(object sender, EventArgs e)
        {
            txtScreen.Text = $"{txtScreen.Text},";
            txtScreen.ForeColor = Color.Red;
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            txtScreen.Text = $"{txtScreen.Text}0";
            txtScreen.ForeColor = Color.Red;
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            txtScreen.Text = $"{txtScreen.Text}1";
            txtScreen.ForeColor = Color.Red;
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            txtScreen.Text = $"{txtScreen.Text}2";
            txtScreen.ForeColor = Color.Red;
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            txtScreen.Text = $"{txtScreen.Text}3";
            txtScreen.ForeColor = Color.Red;
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            txtScreen.Text = $"{txtScreen.Text}4";
            txtScreen.ForeColor = Color.Red;
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            txtScreen.Text = $"{txtScreen.Text}5";
            txtScreen.ForeColor = Color.Red;
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            txtScreen.Text = $"{txtScreen.Text}6";
            txtScreen.ForeColor = Color.Red;
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            txtScreen.Text = $"{txtScreen.Text}7";
            txtScreen.ForeColor = Color.Red;
        }
        private void btnOFF_Click(object sender, EventArgs e)
        {
            DisableCalc();
        }
    }
}

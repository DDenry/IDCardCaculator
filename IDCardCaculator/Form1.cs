using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDCardCaculator
{
    public partial class Form1 : Form
    {
        private int[] weightFactors = new int[] { 7, 9, 10, 5, 8, 4, 2, 1, 6, 3, 7, 9, 10, 5, 8, 4, 2 };
        private string[] arr = new string[] { "1", "0", "X", "9", "8", "7", "6", "5", "4", "3", "2" };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.Beep();

        }

        private void textBox_IDNumber_TextChanged(object sender, EventArgs e)
        {
            string inputStr = ((TextBox)sender).Text.Trim();
            if (inputStr.Length == 17)
            {
                if (!(inputStr.Contains("x") || inputStr.Contains("X")))
                {
                    button.Enabled = true;
                    tip.Text = "";
                }
                else button.Enabled = false;
            }
            else
            {
                button.Enabled = false;
                tip.Text = "*请输入身份证号前17位";
            }
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            string inputStr = textBox_IDNumber.Text.Trim();
            int[] groups = new int[inputStr.Length];
            for (int i = 0; i < groups.Length; i++)
            {
                groups[i] = int.Parse(inputStr.Substring(i, 1));
            }
            //
            MessageBox.Show("完整的身份证号为：" + CaculateLastIDNumber(groups), "系统消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox_IDNumber.Text = "";
        }
        private string CaculateLastIDNumber(int[] groups)
        {
            int total = 0;
            for (int i = 0; i < weightFactors.Length; i++)
            {
                total += groups[i] * weightFactors[i];
            }
            return textBox_IDNumber.Text.Trim() + arr[total % 11];
        }

        private void textBox_IDNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')//这是允许输入退格键  
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))//这是允许输入0-9数字  
                {
                    e.Handled = true;
                }
            }
        }
    }
}

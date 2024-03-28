using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        private double op1;
        private double op2;
        private string operation;
        private double result;


        public Form1()
        {
            InitializeComponent();
        }

        private void digitalBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if(displaytxt.Text == "0")
            {
                displaytxt.Clear();
            }
            displaytxt.Text = displaytxt.Text + btn.Text;
        }

        private void dotBtn_Click(object sender, EventArgs e)
        {
            if(!displaytxt.Text.Contains('.'))
            {
                displaytxt.Text = displaytxt.Text + ".";
            }
        }

        private void operationBtn(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            op1 = double.Parse(displaytxt.Text);
            operation = button.Text;
            displaytxt.Text = "0";
            

        }

        private void equalBtn_Click(object sender, EventArgs e)
        {
            
            if (!double.IsNaN(op1))
            {
                op2 = double.Parse(displaytxt.Text);
                displaytxt.Clear() ;
                switch(operation)
                {
                    case "+":
                        result = op1 + op2;
                        break;
                    case "-":
                        result = op1 - op2;
                        break;
                    case "*":
                        result = op1 * op2;
                        break;
                    case "/":
                        result = op1 / op2;
                        break;
                }
                displaytxt.Text = result.ToString();
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            op1 = double.NaN; op2 = double.NaN;
            operation = string.Empty;
            displaytxt.Clear();
        }
    }
}

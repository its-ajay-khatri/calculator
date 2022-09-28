using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {

        double resultValue = 0;
        string operationPerformed = "";
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {          
            if (textbox_Result.Text == "0" || isOperationPerformed)
                textbox_Result.Clear();

            isOperationPerformed = false;
            Button btn = (Button)sender;
            if (btn.Text == ".")
            {
                if (!textbox_Result.Text.Contains("."))
                {
                    textbox_Result.Text = textbox_Result.Text + btn.Text;
                }
            }
            else
            {
                textbox_Result.Text = textbox_Result.Text + btn.Text;
            }
            
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if(resultValue!= 0)
            {
                switch (operationPerformed)
                {
                    case "+":
                        textbox_Result.Text = (resultValue + Double.Parse(textbox_Result.Text)).ToString();
                        break;
                    case "-":
                        textbox_Result.Text = (resultValue - Double.Parse(textbox_Result.Text)).ToString();
                        break;
                    case "*":
                        textbox_Result.Text = (resultValue * Double.Parse(textbox_Result.Text)).ToString();
                        break;
                    case "/":
                        textbox_Result.Text = (resultValue / Double.Parse(textbox_Result.Text)).ToString();
                        break;
                    default:
                        break;

                }
                
                operationPerformed = btn.Text;
                labeltext.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }

            else { 
            operationPerformed = btn.Text;
            resultValue = Double.Parse(textbox_Result.Text);
            labeltext.Text = resultValue + " " + operationPerformed;
            isOperationPerformed = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textbox_Result.Text = "0";
          
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textbox_Result.Text = (resultValue + Double.Parse(textbox_Result.Text)).ToString();
            textbox_Result.Text = textbox_Result.Text.Remove(textbox_Result.Text.Length - 1, 1);
            resultValue = Double.Parse(textbox_Result.Text);
            labeltext.Text = "";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            switch(operationPerformed)
            {
                case "+":
                    textbox_Result.Text = (resultValue + Double.Parse(textbox_Result.Text)).ToString();
                    break;
                case "-":
                    textbox_Result.Text = (resultValue - Double.Parse(textbox_Result.Text)).ToString();
                    break;
                case "*":
                    textbox_Result.Text = (resultValue * Double.Parse(textbox_Result.Text)).ToString();
                    break;
                case "/":
                    textbox_Result.Text = (resultValue / Double.Parse(textbox_Result.Text)).ToString();
                    break;
                default:
                    break;
                    
            }
            resultValue = Double.Parse(textbox_Result.Text);
            labeltext.Text = "";
            
        }
    }
}

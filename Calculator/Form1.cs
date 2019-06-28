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
        double Value = 0;
        string Operation = "";
        bool OperatorPressed = false;

        public Form1()
        {
            InitializeComponent();
        }


        private void Number_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Result.Text = (Result.Text == "0") ? "" : Result.Text;
            Result.Text = Result.Text + button.Text;
        }

        private void OperationButton(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Operation = button.Text;
            TempLabel.Text = Result.Text;
            Result.Text = "";
            OperatorPressed = true;
            Value = Double.Parse(TempLabel.Text);
        }

        private void CalculateResult(object sender, EventArgs e)
        {
            OperatorPressed = false;
            TempLabel.Text = "";
            switch (Operation)
            {
                case "+":
                    Result.Text = (Value + Convert.ToDouble(Result.Text)).ToString();
                    break;
                case "/":
                    Result.Text = (Value / Convert.ToDouble(Result.Text)).ToString();
                    break;
                case "-":
                    Result.Text = (Value - Convert.ToDouble(Result.Text)).ToString();
                    break;
                case "*":
                    Result.Text = (Value * Convert.ToDouble(Result.Text)).ToString();
                    break;

                default:
                    break;
            }
        }

        private void ClearButton(object sender, EventArgs e)
        {
            Result.Clear();
            Value = 0;

        }

        private void ClearEverythingButton(object sender, EventArgs e)
        {
            Result.Clear();
            Value = 0;
            Operation = "";
            TempLabel.Text = "";
            OperatorPressed = false;
        }

        private void Result_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

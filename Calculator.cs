using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculate()
        {
            string num1Input = this.Num1Input.Text;
            string num2Input = this.Num2Input.Text;

            if (!string.IsNullOrEmpty(num1Input) && !string.IsNullOrEmpty(num2Input))
            {
                double num1 = Convert.ToDouble(num1Input);
                double num2 = Convert.ToDouble(num2Input);
                double sum = num1 + num2;
                this.SumOutput.Text = Convert.ToString(sum);
            }
        }

        private void Num1Input_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void Num2Input_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }
    }
}

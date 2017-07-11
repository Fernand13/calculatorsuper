using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            double firstValue = Convert.ToDouble(input1.Text);
            double lastValue = Convert.ToDouble(input2.Text);
            ITwoArgumentsOperation calculator = TwoArgumentsCalculatorsFactory.CreateCalculator(((Button)sender).Name);
            double result = calculator.Calculate(firstValue, lastValue);

            Answer.Text = result.ToString();
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            double firstValue = Convert.ToDouble(input1.Text);
            IOneArgumentsOperation calculator = OneArgumentsCalculatorsFactory.CreateCalculator(((Button)sender).Name);
            double result = calculator.Calculate(firstValue);

            Answer.Text = result.ToString();
        }
    }
}

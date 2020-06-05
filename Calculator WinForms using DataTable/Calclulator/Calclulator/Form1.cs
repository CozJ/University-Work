using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calclulator
{
    public partial class Form1 : Form
    {
        Calculation Calculator = new Calculation();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Calculator.addNumber('1');
            updateLabel();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Calculator.addNumber('2');
            updateLabel();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Calculator.addNumber('3');
            updateLabel();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Calculator.addNumber('4');
            updateLabel();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Calculator.addNumber('5');
            updateLabel();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Calculator.addNumber('6');
            updateLabel();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Calculator.addNumber('7');
            updateLabel();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Calculator.addNumber('8');
            updateLabel();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Calculator.addNumber('9');
            updateLabel();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Calculator.addNumber('0');
            updateLabel();
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            Calculator.ParseResult();
            updateLabel();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            Calculator.undo();
            updateLabel();
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            Calculator.AllClear();
            updateLabel();
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            Calculator.addOperator('*');
            updateLabel();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            Calculator.addOperator('/');
            updateLabel();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            Calculator.addOperator('+');
            updateLabel();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            Calculator.addOperator('-');
            updateLabel();
        }

        private void updateLabel()
        {
            ReadOut.Text = Calculator.DisplayValue();
        }
    }
}

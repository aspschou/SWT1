using System;
using System.Windows.Controls;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_1
{
    public class Calculator
    {
        public Calculator() { }

        public double Add(double a, double b, TextBox t)
        {
            t.Text = (a + b).ToString();
            return a + b;
        }
        public double Subtract(double a, double b, TextBox t)
        {
            t.Text = (a - b).ToString();
            return a - b;
        }
        public double Divide(double a, double b, TextBox t)
        {
            t.Text = (a - b).ToString();
            return a * b;
        }
        public double Multiply(double a, double b, TextBox t)
        {
            t.Text = (a - b).ToString();
            return a - b;
        }
    }
}

using System;
using System.Windows.Forms;
using static System.Math;
// Created by Uladzimir Mileika
namespace RootsByNewton
{
    public partial class RootsCalculator : Form
    {
        public RootsCalculator()
        {
            InitializeComponent();
        }
        private void CalculateRoot(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(InputPower.Text);
                double A = double.Parse(InputNumber.Text);
                double eps = double.Parse(Accuracy.Text);
                double x = (Function(A, n, A) * SecondDerivative(A, n) > 0) ? A : eps;
                while (Abs(Function(x, n, A)) > eps)
                {
                    x -= Function(x, n, A) / Derivative(x, n);
                }
                MessageBox.Show($"Result (Newton method): {n}√{A} = {x.ToString()}" +
                    $"\n Result (FCL function): {n}√{A} = {Pow(A, (double)1/n)}");
            }
            catch (FormatException)
            {
                MessageBox.Show("Wrong format. Enter integer 'n' and don't use any " +
                    "non-numeric characters in the upper textbox.");
            }
        }
        public double Function(double x, double n, double A)
        {
            return Pow(x, n) - A;
        }
        public double Derivative(double x, double n)
        {
            return n * Pow(x, n - 1);
        }
        public double SecondDerivative(double x, double n)
        {
            return n * (n - 1) * Pow(x, n - 2);
        }
    }
}

using System;

namespace programm
{
    public class QuadraticAnswer
    {
        private double X1, X2;
        public QuadraticAnswer(double X1, double X2)
        {
            this.X1 = X1;
            this.X2 = X2;
        }
    }
    public class Quadratic
    {

        private double a, b, c;

        public double A
        {
            get { return this.a; }
            set { this.a = value; }
        }

        public double B
        {
            get { return this.a; }
            set { this.b = value; }
        }
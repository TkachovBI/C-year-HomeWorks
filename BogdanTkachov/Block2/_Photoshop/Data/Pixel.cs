using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop.Data
{
    public class Pixel
    {
        private double r;
        private double g;
        private double b;

        private double Check(double val)
        {
            if (val < 0 || val > 1)
            {
                throw new Exception( $"Wrong channel value {val} (the value must be between 0 and 1");
            }
            else
            {
                return val;
            }
        }

        public double R 
        {
            get
            {
                return r;
            }
            set
            {
                r = Check(value);
            }
        }
        public double G 
        {
            get
            {
                return g;
            }
            set
            {
                g = Check(value);
            }
        }
        public double B 
        {
            get
            {
                return b;
            }
            set
            {
                
                b = Check(value);
            }
        }
    }
}

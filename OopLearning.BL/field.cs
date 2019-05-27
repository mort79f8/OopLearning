using System;
using System.Collections.Generic;
using System.Text;

namespace OopLearning.BL
{
    public class Field
    {
        private double width;
        private double length;
        private string crop;

        public double Width {
            get => width;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width skal være mere end 0");
                }
                else
                {
                    width = value;
                }
            }
        }
        public double Length {
            get => length;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Length skal være mere end 0");
                }
                else
                {
                    length = value;
                }
            }
        }
        public string Crop { get => crop; set => crop = value; }
        public double Area { get; }
        public double Yield { get; }

    }
}

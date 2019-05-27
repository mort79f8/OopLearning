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
        public string Crop {
            get => crop;
            set
            {
                var cropCheck = ValidateCrop(value);
            }
        }
        public double Area { get; }
        public double Yield { get; }

        public Field()
        {

        }
        public Field(double width, double length, string crop, double area, double yield)
        {
            Width = width;
            Length = length;
            Crop = crop;
            Area = area;
            Yield = yield;
        }


    }
}

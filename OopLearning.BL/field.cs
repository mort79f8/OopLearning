﻿using System;
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
                if (cropCheck.IsValid)
                {
                    crop = value;
                }
                else
                {
                    throw new ArgumentException(cropCheck.errMessage, nameof(crop));
                }
            }
        }
        public double Area {
            get
            {
                if (Length == 0 || Width == 0)
                {
                    throw new InvalidOperationException("Length eller Width må ikke være 0");
                }
                else
                {
                    return Length*Width;
                }
            }
        }
        public double Yield {
            get
            {
                switch (Crop.ToLower())
                {
                    case "wheat":
                        return (Area / 100) * 2;
                    case "potatoes":
                        return (Area / 100) * 4;
                    case "oat":
                        return (Area / 200) * 3;
                    case "carrots":
                        return (Area / 30) * 3;
                    default:
                        return 0;
                }

            }
        }

        public Field()
        {

        }
        public Field(double width, double length, string crop)
        {
            Width = width;
            Length = length;
            Crop = crop;
        }

        public static (bool IsValid, string errMessage) ValidateCrop(string value)
        {
            if (value is null)
            {
                return (false, "length eller width er 0");
            }

            if (value.ToLower() == "potatoes" || value == "wheat" || value == "oat" || value == "carrots")
            {
                return (true, "");
            }
            else
            {
                return (false, "Der må kun være Potatoes, Wheat, Oak eller Carrots på marken");
            }
        }



    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace OopLearning.BL.Inheritance
{
    public class ImageFileInfo : CustomFileInfo
    {
        protected int width;
        protected int heigth;

        public ImageFileInfo(string name, int size, DateTime creation, int width, int heigth) : base(name, size, creation)
        {
            this.width = width;
            this.heigth = heigth;
        }

        public override bool IsSizeTooLarge()
        {
            if (base.IsSizeTooLarge() || width > 1920 || heigth > 1080)
            {
                return true;
            }
            return false;
        }
    }
}

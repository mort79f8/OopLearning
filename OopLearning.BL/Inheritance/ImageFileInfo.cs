using System;
using System.Collections.Generic;
using System.Text;

namespace OopLearning.BL.Inheritance
{
    class ImageFileInfo : CustomFileInfo
    {
        protected int width;
        protected int heigth;

        public ImageFileInfo(string name, int size, DateTime creation, int myWidth, int myHeigth) : base(name, size, creation)
        {
            width = myHeigth;
            heigth = myHeigth;
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

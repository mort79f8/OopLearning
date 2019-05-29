using System;
using System.Collections.Generic;
using System.Text;

namespace OopLearning.BL.Inheritance
{
    class VideoFileInfo : ImageFileInfo
    {
        private int duration;

        public VideoFileInfo(string name, int size, DateTime creation, int myWidth, int myHeigth, int myDuration) : base(name, size, creation, myWidth, myHeigth)
        {
            duration = myDuration;
        }

        public override string ToString()
        {
            return $"Video: {FileName}";
        }
    }
}

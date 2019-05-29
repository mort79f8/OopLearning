using System;
using System.Collections.Generic;
using System.Text;

namespace OopLearning.BL.Inheritance
{
    public class VideoFileInfo : ImageFileInfo
    {
        private int duration;

        public VideoFileInfo(string name, int size, DateTime creation, int width, int heigth, int duration) : base(name, size, creation, width, heigth)
        {
            this.duration = duration;
        }

        public override string ToString()
        {
            return $"Video: {FileName}";
        }
    }
}

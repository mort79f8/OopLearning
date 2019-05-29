using System;
using System.Collections.Generic;
using System.Text;

namespace OopLearning.BL.Inheritance
{
    abstract class CustomFileInfo
    {
        protected string fileName;
        protected int fileSize;
        protected DateTime creationTime;

        protected CustomFileInfo(string name, int size, DateTime creation)
        {
            fileName = name;
            fileSize = size;
            creationTime = creation;
        }

        public virtual bool IsSizeTooLarge()
        {
            return "not definded yet"

        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}

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

        public string FileName { get => fileName; set => fileName = value; }
        public int FileSize { get => fileSize; set => fileSize = value; }
        public DateTime CreationTime { get => creationTime; set => creationTime = value; }

        protected CustomFileInfo(string name, int size, DateTime creation)
        {
            fileName = name;
            fileSize = size;
            creationTime = creation;
        }

        public virtual bool IsSizeTooLarge()
        {
            if (FileSize > 45)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"{FileName}";
        }

    }
}

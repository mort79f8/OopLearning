using System;
using System.Collections.Generic;
using System.Text;

namespace OopLearning.BL.Inheritance
{
    public class DocumentFileInfo : CustomFileInfo
    {
        public DocumentFileInfo(string name, int size, DateTime creation) : base(name, size, creation)
        {
        }
    }
}

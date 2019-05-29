using System;
using System.Collections.Generic;
using System.Text;

namespace OopLearning.BL.Inheritance
{
    class DocumentFileInfo : CustomFileInfo
    {
        public DocumentFileInfo(string name, int size, DateTime creation) : base(name, size, creation)
        {
        }
    }
}

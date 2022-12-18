using System;

namespace _12DZ_KFU
{
    internal class InfoAttribAttribute : Attribute
    {
        
        public string Developer;
        public string Date
        {
            get;
            set;
        }
        public InfoAttribAttribute(string developer)
        {
            Developer = developer;
        }
        
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace pract8
{
    interface ICar
    {
        public int BusCapacity { get; set; }
        public string Name { get; set; }
        public string ShowInformation();
        public int CompareTo(object object1);
    }
}

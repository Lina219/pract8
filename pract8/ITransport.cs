using System;
using System.Collections.Generic;
using System.Text;

namespace pract8
{
    interface ITransport
    {
        public int Capacity { get; set; }
        public string Name { get; set; }
        public string ShowInformation();
    }
}

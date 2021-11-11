using System;
using System.Collections.Generic;
using System.Text;

namespace pract8
{
    interface ICloneable
    {
        public Bus ShallowClone();

        public object Clone();
    }
}

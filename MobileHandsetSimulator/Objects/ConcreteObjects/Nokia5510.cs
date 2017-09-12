using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileHandsetSimulator
{
    class Nokia5510 : Handset
    {
        public override string Display()
        {
            return @"This is a very basic model from Nokia with no camera whatsoever!!";
        }

        public override string ToString()
        {
            return "Nokia 5510";
        }
    }
}

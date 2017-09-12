using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileHandsetSimulator
{
    public class NokiaLumia920 : Handset
    {
        private readonly int _rearCameraMPs = 20;
        private readonly int _frontCameraMPs = 5;

        public NokiaLumia920()
        {
            SetPhotographyDevice(new RearCamera(_rearCameraMPs));
            MainPhotographyDevice = new RearCamera(_rearCameraMPs);
            SecondPhotographyDevice = new FrontCamera(_frontCameraMPs);
        }

        public override string Display()
        {
            return @"Nokia Lumia 920... A full-featured phone from Nokia";
        }
    }
}

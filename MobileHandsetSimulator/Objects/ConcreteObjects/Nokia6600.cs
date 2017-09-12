using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileHandsetSimulator
{
    public class Nokia6600:Handset
    {
        private readonly int _rearCameraMPs = 12;

        public Nokia6600()
        {
            SetPhotographyDevice(new RearCamera(_rearCameraMPs));
            MainPhotographyDevice = new RearCamera(_rearCameraMPs);
            //Front-camera re not supported in this deviace
            SecondPhotographyDevice = null;
        }

        public override string Display()
        {
            return @"Nokia Lumia 6600... 
                        A Nokia phone with a lots of features and hight-resolution camera";
        }
    }
}

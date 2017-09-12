using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileHandsetSimulator
{
    public class Nokia6600:Handset
    {
        private readonly int rearCameraMPs = 12;

        public Nokia6600()
        {
            photographyDevice = new RearCamera(rearCameraMPs);
        }

        public void LoadFrontCamera()
        {
            //Front-camera re not supported in this deviace
            SetPhotographyDevice(null);
        }

        public void LoadRearCamera()
        {
            SetPhotographyDevice(new RearCamera(rearCameraMPs));
        }

        public override string Display()
        {
            return @"Nokia Lumia 6600... 
                        A Nokia phone with a lots of features and hight-resolution camera";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileHandsetSimulator
{
    public class NokiaLumia920 : Handset
    {
        private readonly int rearCameraMPs = 12;
        private readonly int frontCameraMPs = 5;

        public NokiaLumia920()
        {
            photographyDevice = new RearCamera(rearCameraMPs);
        }

        public void LoadFrontCamera()
        {
            SetPhotographyDevice(new FrontCamera(frontCameraMPs));
        }

        public void LoadRearCamera()
        {
            SetPhotographyDevice(new RearCamera(rearCameraMPs));
        }

        public override string Display()
        {
            return @"Nokia Lumia 920... A full-featured phone from Nokia";
        }
    }
}

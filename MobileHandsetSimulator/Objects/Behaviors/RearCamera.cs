using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileHandsetSimulator
{
    public class RearCamera : IPhotographyDevice
    {
        public int MegaPixels { get; set; }

        public RearCamera(int supportedMegaPixels)
        {
            MegaPixels = supportedMegaPixels;
        }

        public string RecordVideo(string location)
        {
            return String.Format("Recording Video on {0} MP main camera", MegaPixels.ToString());
        }

        public string TakeSnap(string location)
        {
            return String.Format("Taking Photograph on {0} MP main camera", MegaPixels.ToString());
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileHandsetSimulator
{
    public class FrontCamera : IPhotographyDevice
    {
        public int megaPixels { get; set; }

        public FrontCamera(int supportedMegaPixels)
        {
            megaPixels = supportedMegaPixels;
        }

        public string RecordVideo(string location)
        {
            return String.Format("Recording Video on {0} MP main camera", megaPixels.ToString());
        }

        public string TakeSnap(string location)
        {
            return String.Format("Taking Photograph on {0} MP main camera", megaPixels.ToString());
        }
    }
}

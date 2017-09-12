using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileHandsetSimulator
{
    public abstract class Handset
    {
        public IPhotographyDevice photographyDevice;

        public abstract string Display();

        public string MakeACall(string destinationNumber)
        {
            return String.Format("Calling {0}", destinationNumber);
        }

        public string SendSms(string destinationNumber)
        {
            return String.Format("Sending SMS to {0}", destinationNumber);
        }

        public string TakeSnap(string location)
        {
            if (photographyDevice != null)
                return photographyDevice.TakeSnap(location);
            else
                return @"Sorry! This phone doesn't support photography";
        }

        public string RecordVideo(string location)
        {
            if (photographyDevice != null)
                return photographyDevice.RecordVideo(location);
            else
                return @"Sorry! This phone doesn't support videography";
        }

        public void SetPhotographyDevice(IPhotographyDevice newPhotographyDevice)
        {
            photographyDevice = newPhotographyDevice;
        }
    }
}

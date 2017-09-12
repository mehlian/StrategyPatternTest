using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileHandsetSimulator
{
    public abstract class Handset
    {
        private IPhotographyDevice _photographyDevice;

        public IPhotographyDevice MainPhotographyDevice { get; set; }
        public IPhotographyDevice SecondPhotographyDevice { get; set; }

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
            if (_photographyDevice != null)
                return _photographyDevice.TakeSnap(location);
            else
                return @"Sorry! This phone doesn't support photography";
        }

        public string RecordVideo(string location)
        {
            if (_photographyDevice != null)
                return _photographyDevice.RecordVideo(location);
            else
                return @"Sorry! This phone doesn't support videography";
        }

        public void SetPhotographyDevice(IPhotographyDevice newPhotographyDevice)
        {
            _photographyDevice = newPhotographyDevice;
        }

        public void ActivateMainPhotographyDevice()
        {
            _photographyDevice = MainPhotographyDevice;
        }

        public void ActivateSecondPhotographyDevice()
        {
            _photographyDevice = SecondPhotographyDevice;
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MobileHandsetSimulator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();



            var nokiaLumia920 = new NokiaLumia920();
            var nokia5510 = new Nokia5510();
            cmbboxPhoneModel.ItemsSource = new[] { nokia5510 };

        }

        private void btnCall_Click(object sender, RoutedEventArgs e)
        {
            MainOutputWindow.Text = string.Empty;
            var nokia6600 = new Nokia6600();
            MainOutputWindow.Text = nokia6600.MakeACall("666");
        }

        private void btnSMS_Click(object sender, RoutedEventArgs e)
        {
            MainOutputWindow.Text = string.Empty;
            var nokia6600 = new Nokia6600();
            MainOutputWindow.Text = nokia6600.SendSms("test sms");
        }

        private void btnActivateFrontCamera_Click(object sender, RoutedEventArgs e)
        {
            MainOutputWindow.Text = "Activate front camera";
            var nokia6600 = new Nokia6600();
            nokia6600.LoadFrontCamera();
        }

        private void btnActivateRearCamera_Click(object sender, RoutedEventArgs e)
        {
            MainOutputWindow.Text = "Activate rear camera";
            var nokia6600 = new Nokia6600();
            nokia6600.LoadRearCamera();
        }

        private void btnTakeSnap_Click(object sender, RoutedEventArgs e)
        {
            MainOutputWindow.Text = string.Empty;
            var nokia6600 = new Nokia6600();
            MainOutputWindow.Text = nokia6600.TakeSnap(@"I:\snap...");
        }

        private void btnRecordVideo_Click(object sender, RoutedEventArgs e)
        {
            MainOutputWindow.Text = string.Empty;
            var nokia6600 = new Nokia6600();
            MainOutputWindow.Text = nokia6600.RecordVideo(@"I:\record...");
        }
    }
}

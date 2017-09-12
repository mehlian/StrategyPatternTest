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
            cmbboxPhoneModel.ItemsSource = new List<Handset> { new Nokia6600(), new NokiaLumia920(), new Nokia5510() };
            cmbboxPhoneModel.SelectedIndex = 0;
        }

        private void btnCall_Click(object sender, RoutedEventArgs e)
        {
            MainOutputWindow.Text = string.Empty;
            Handset handset = (Handset)cmbboxPhoneModel.SelectionBoxItem;
            MainOutputWindow.Text = handset.Display() + " " + handset.MakeACall("555 888 555");
        }

        private void btnSMS_Click(object sender, RoutedEventArgs e)
        {
            MainOutputWindow.Text = string.Empty;
            Handset handset = (Handset)cmbboxPhoneModel.SelectedItem;
            MainOutputWindow.Text = handset.SendSms("test sms");
        }

        private void btnActivateFrontCamera_Click(object sender, RoutedEventArgs e)
        {
            MainOutputWindow.Text = "Activate front camera";
            Handset handset = (Handset)cmbboxPhoneModel.SelectedItem;
            handset.ActivateSecondPhotographyDevice();
        }

        private void btnActivateRearCamera_Click(object sender, RoutedEventArgs e)
        {
            MainOutputWindow.Text = "Activate rear camera";
            Handset handset = (Handset)cmbboxPhoneModel.SelectedItem;
            handset.ActivateMainPhotographyDevice();
        }

        private void btnTakeSnap_Click(object sender, RoutedEventArgs e)
        {
            MainOutputWindow.Text = string.Empty;
            Handset handset = (Handset)cmbboxPhoneModel.SelectedItem;
            MainOutputWindow.Text = handset.TakeSnap("test Snap");
        }

        private void btnRecordVideo_Click(object sender, RoutedEventArgs e)
        {
            MainOutputWindow.Text = string.Empty;
            Handset handset = (Handset)cmbboxPhoneModel.SelectedItem;
            MainOutputWindow.Text = handset.RecordVideo("test Record");
        }
    }
}

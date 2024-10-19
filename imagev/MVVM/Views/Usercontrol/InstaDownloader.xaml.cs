using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Thisisbull = System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace imagev.MVVM.Views.Usercontrol
{
    /// <summary>
    /// Interaction logic for InstaDownloader.xaml
    /// </summary>
    public partial class InstaDownloader : Thisisbull.UserControl
    {
        public InstaDownloader()
        {
            InitializeComponent();
        }

        private void SetProfilePath()
        {
            try
            {
                string profilepath = "C:\\Users\\DELL\\Desktop\\Downloads\\Vz3ZF20nr2c-HD.jpg";
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(profilepath, UriKind.Absolute);
                bitmap.EndInit();

                InstaprofilePic.Source = bitmap; // Set the source of the Image control
            }
            catch (Exception ex)
            {

            }

        }
        private void SetProfiieName()
        {
            try
            {
                string videoTitle = "Mutura";

                Instaprofile.Text = videoTitle; // Set the source of the Image control
            }
            catch (Exception ex)
            {

            }
        }
    }
}

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
    /// Interaction logic for DownloadView.xaml
    /// </summary>
    public partial class DownloadView : Thisisbull.UserControl
    {
        public DownloadView()
        {
            InitializeComponent();
        }


        public event EventHandler SetYoutubeDownloadView;
        private void GotoYoutubeDownloader(object sender, MouseButtonEventArgs e)
        {
            SetYoutubeDownloadView?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler SetInstagramDownloadView;
        private void GotoInstagramDownloader(object sender, MouseButtonEventArgs e)
        {
            SetInstagramDownloadView?.Invoke(this, EventArgs.Empty);
        }
    }
}

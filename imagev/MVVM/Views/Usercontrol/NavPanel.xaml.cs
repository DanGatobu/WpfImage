using System.ComponentModel;
using System.Runtime.CompilerServices;
using Thisisbull = System.Windows.Controls;
using System.Diagnostics;
using System.Windows;

namespace imagev.MVVM.Views.Usercontrol
{
    /// <summary>
    /// Interaction logic for NavPanel.xaml
    /// </summary>
    public partial class NavPanel : Thisisbull.UserControl,INotifyPropertyChanged
    {

        private bool checknav;
        
       
        
        public bool NavOn
        {
            get => checknav;
            set
            {
                if (checknav != value) // Check if the value is actually changing
                {
                    checknav = value;
                    
                    OnPropertyChanged(); // Notify the UI of the property change
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        public event EventHandler GallPhotos;
        private void GoToAllNav(object sender, RoutedEventArgs e)
        {
            GallPhotos.Invoke(this, EventArgs.Empty);
        }

        public NavPanel()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        public void MenuClick(object sender, RoutedEventArgs e)
        {
            NavOn = !NavOn;
          
        }

        public event EventHandler Gfavourites;
        private void GoFavouritesnav(object sender, RoutedEventArgs e)
        {
            Gfavourites.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler Gfolder;
        private void GoFoldernav(object sender, RoutedEventArgs e)
        {
            Gfolder.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler Gdownload;
        private void GoDownloadnav(object sender, RoutedEventArgs e)
        {
            Gdownload.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler Gdrive;
        private void GoDrivenav(object sender, RoutedEventArgs e)
        {
            Gdrive.Invoke(this, EventArgs.Empty);
        }



    }
}

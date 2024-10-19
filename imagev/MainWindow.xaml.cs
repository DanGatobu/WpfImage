using System.Collections.ObjectModel;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using static System.Net.Mime.MediaTypeNames;
using imagev.MVVM.Views.Usercontrol;
using WpfImage = System.Windows.Controls.Image;
using System.Diagnostics;
using System.Windows.Input;
using System.ComponentModel;


namespace imagev
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<BitmapImage> Images { get; set; }
        private object _currentView;
        public MainWindow()
        {
            InitializeComponent();
            this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
            Images = new ObservableCollection<BitmapImage>();
            Contentgo.Content = new Maingallary();
            MainNavPanel.Gfavourites += NavPanel_Gfavourites;
            MainNavPanel.Gfolder += NavPanel_Gfolder;
            MainNavPanel.GallPhotos += MainNavPanel_GallPhotos;
            MainNavPanel.Gdownload += MainNavPanel_Gdownload;
            MainNavPanel.Gdrive += MainNavPanel_Gdrive;
            Bankai.WindowMinimizeClicked += Bankai_WindowMinimizeClicked;
            Bankai.WindowMaximizeClicked += Bankai_WindowMaximizeClicked;
            Bankai.WindowCloseClicked += Bankai_WindowCloseClicked;
            DownloadView.



        }

        private void Bankai_WindowCloseClicked(object? sender, EventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void Bankai_WindowMaximizeClicked(object? sender, EventArgs e)
        {
           Maximize();
        }

        private void Bankai_WindowMinimizeClicked(object? sender, EventArgs e)
        {
            Minimize();
        }

        private void MainNavPanel_Gdrive(object? sender, EventArgs e)
        {
            Contentgo.Content = new DriveView();
        }

        private void MainNavPanel_Gdownload(object? sender, EventArgs e)
        {
            Contentgo.Content = new DownloadView();
        }

        private void MainNavPanel_GallPhotos(object? sender, EventArgs e)
        {
            Contentgo.Content = new Maingallary();
        }

        private void NavPanel_Gfolder(object? sender, EventArgs e)
        {
            Contentgo.Content = new FolderView();
        }

        private void NavPanel_Gfavourites(object? sender, EventArgs e)
        {
            Contentgo.Content = new Maingallary();
        }




        // Command to change views
        public ICommand NavigateCommand { get; }

        public void LoadImages(string directory)
        {
            if (Directory.Exists(directory))
            {
                var imageFiles = Directory.GetFiles(directory, "*.jpg");
                foreach (var imageFile in imageFiles)
                {
                    var bitMap = new BitmapImage();
                    bitMap.BeginInit();
                    bitMap.UriSource = new Uri(imageFile, UriKind.Absolute);
                    bitMap.CacheOption = BitmapCacheOption.OnLoad;
                    bitMap.EndInit();
                    Images.Add(bitMap);



                }
            }
        }

        public static void TestPrint()
        {
            Debug.WriteLine("Fghjklkjh");
            System.Windows.MessageBox.Show("clicked image button");
        }

        private void Minimize()
        {
            {
                if (this.WindowState == WindowState.Normal)
                {
                    this.WindowState = WindowState.Minimized;
                }
                else if (this.WindowState == WindowState.Minimized)
                {
                    this.WindowState = WindowState.Normal;
                }
            }
        }

        private void Maximize()

        {
            //BitmapImage MaximizeIcon = new BitmapImage(new Uri("/Images/icons8-square-50.png", UriKind.Relative));
            //BitmapImage RestoreIcon = new BitmapImage(new Uri("/Images/squares.png", UriKind.Relative));

            if (this.WindowState == WindowState.Normal)
            {
                this.WindowState = WindowState.Maximized;
            }
            else if (this.WindowState == WindowState.Maximized)
            {


                this.WindowState = WindowState.Normal;
            }
        }
        

        private void Lv_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {

        }

        private void ImageBtns1(object sender, System.Windows.Input.MouseEventArgs e)
        {
            var img = sender as WpfImage;
            if (img != null)
            {
                var expander = img.Tag as Expander;

                // If the Tag is set correctly and the expander is found
                if (expander != null)
                {
                    // Toggle the visibility of the Expander
                    expander.Visibility = expander.Visibility == Visibility.Collapsed ? Visibility.Visible : Visibility.Collapsed;
                }
            }

        }
        public object CurrentView
        {
            get => _currentView;
            set
            {
                _currentView = value;
                // Raise PropertyChanged event if using MVVM (optional)
            }
        }     

        

       
        
        private void AddFolderdisp(object sender, System.Windows.Input.MouseButtonEventArgs e)

        {
            var AdfF = new AddFolderbtn();
            AdfF.Show_pop_up();
        }

        











    }
















    
    
}
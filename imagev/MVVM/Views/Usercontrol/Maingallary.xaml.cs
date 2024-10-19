using imagev.Data;
using imagev.MVVM.Model;
using Microsoft.Identity.Client;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using Thisisbull = System.Windows.Controls;

namespace imagev.MVVM.Views.Usercontrol
{
    /// <summary>
    /// Interaction logic for maingallary.xaml
    /// </summary>
    /// 


    public partial class Maingallary : Thisisbull.UserControl


    {
        ImageData image = new ImageData();
        List<ImageData> mainImageList = new List<ImageData>();

        string selectedValue = "maingallary";

        public ObservableCollection<BitmapImage> Images { get; set; }
        public Maingallary()
        {
            InitializeComponent();
            //LoadImages(@"C:\Users\DELL\Desktop\wallpaper");

            Images = new ObservableCollection<BitmapImage>();
            //DisplayImages();







        }




        public static List<string> List_links()
        {
            using (var Dbc = new AppDbcontext())
            {

                var Fdl = Dbc.Folders.Select(f => f.FolderLink).ToList();
                return Fdl;

            }
        }

        public class ImageData
        {
            public string Name { get; set; } = string.Empty;
            public string Path { get; set; } = string.Empty;
            public DateTime DateAdded { get; set; } = DateTime.MinValue;
            public long Size { get; set; } = 0;
            public BitmapSource ImageContent { get; set; } // For WPF
        }
        public void AddToImageList(string path)
        {
            ImageData newImage = new ImageData
            {
                Name = Path.GetFileName(path),
                Path = path,
                DateAdded = DateTime.Now,
                Size = new FileInfo(path).Length,
                ImageContent = ConvertToBitmapSource(Image.FromFile(path))
            };

            mainImageList.Add(newImage);

        }
        private BitmapSource ConvertToBitmapSource(Image image)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                // Save the Image to the memory stream
                image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Bmp);
                memoryStream.Position = 0; // Reset the stream position

                // Create a BitmapImage from the memory stream
                BitmapImage bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.StreamSource = memoryStream;
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.EndInit();
                bitmapImage.Freeze(); // Optional: Freeze the BitmapImage for thread safety

                return bitmapImage; // Return the BitmapSource
            }
        }


        public void LoadAllImages()
        {
            List<string> Mp_i;
            Mp_i = List_links();


            foreach (var dire in Mp_i) {

                bool checDir = Directory.Exists(dire);
                if (checDir)
                {

                    var imageFiles = Directory.GetFiles(dire.ToString(), "*.jpg");
                    foreach (var imageFile in imageFiles)
                    {

                        AddToImageList(imageFile);


                    }
                }
            }
        }
        public static List<string> GetFavourites()
        {
            return new List<string>();
        }

        public void FavouritesFilter()
        {
            List<string> favourites = GetFavourites(); // Get favourite items
            MainImageBox.Items.Clear(); // Access the ListBox instance directly

            foreach (var imageData in mainImageList)
            {
                // Ignore '02' in names
                string baseName = imageData.Name.Replace("02", "").Trim();

                // Check if the name matches any in the favourites list
                if (favourites.Any(fav => fav.Equals(baseName, StringComparison.OrdinalIgnoreCase)))
                {
                    MainImageBox.Items.Add(imageData.Name); // Add to the ListBox
                }
            }
        }

        private void DisplayImages()
        {
            LoadAllImages();

            foreach (var imageData in mainImageList)
            {
                MainImageBox.Items.Add(imageData.ImageContent); // Add image names to the ListBox
            }
        }
        public void SetImages(string selectedFilter)
        {
            if (selectedFilter == "maingallary")
            {
                string hjjh = "fghj";
            }







        }
    }
}

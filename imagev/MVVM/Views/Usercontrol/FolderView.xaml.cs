using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for FolderView.xaml
    /// </summary>
    public partial class FolderView : Thisisbull.UserControl
    {
        public ObservableCollection<TextItem> TextItems { get; set; }
        public FolderView()
        {
            InitializeComponent();

            DataContext = this;

        }

        public static List<string> GetFolderPaths()
        {
            return new List<string>();
        }

        public void ShowFolders(List<string> fpath)

        {
            foreach (string f in fpath) 
            {
                TextItems.Add(new TextItem { foldertextpath = f });

            }
          

        }
        public class TextItem
        {

            public string foldertextpath { get; set; } = " "; // Text to display in the TextBox
        }
    }

    
}

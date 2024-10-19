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
    /// Interaction logic for searchbox.xaml
    /// </summary>
    public partial class searchbox : Thisisbull.UserControl
    {
        public searchbox()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, Thisisbull.TextChangedEventArgs e)
        {

        }
    }
}

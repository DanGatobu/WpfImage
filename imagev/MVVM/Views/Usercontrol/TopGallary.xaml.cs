using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Thisisbull=System.Windows.Controls;
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
    /// Interaction logic for TopGallary.xaml
    /// </summary>
    public partial class TopGallary : Thisisbull.UserControl
    {
        public TopGallary()
        {
            InitializeComponent();
        }

        private void SortActivate(object sender, MouseButtonEventArgs e)
        {
            System.Windows.MessageBox.Show("dfdghjhgffg");
            //SortSelect.IsPopupOpen = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("dfdghjhgffg");

        }
    }
}

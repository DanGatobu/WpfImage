using System.Windows.Media.Imaging;
using System.Windows;
using Thisisbull = System.Windows.Controls;
using System.ComponentModel;
using System.Windows.Controls.Primitives;


namespace imagev.MVVM.Views.Usercontrol
{
    /// <summary>
    /// Interaction logic for WindowControl.xaml
    /// </summary>
    public partial class WindowControl : Thisisbull.UserControl

    {
        private string _iconName = "CardMultipleOutline";

        public string IconName
        {
            get => _iconName;
            set
            {
                if (_iconName != value)
                {
                    _iconName = value;
                    OnPropertyChanged(nameof(IconName));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void ToggleIcon()

        {

            var currentIcon = Icon.Kind;

            Icon.Kind = currentIcon == MaterialDesignThemes.Wpf.PackIconKind.CardMultipleOutline
                ? MaterialDesignThemes.Wpf.PackIconKind.CheckboxBlankOutline
                : MaterialDesignThemes.Wpf.PackIconKind.CardMultipleOutline;
        }


        public WindowControl()
        {
            InitializeComponent();


            

        }

        public event EventHandler WindowMinimizeClicked;
        public event EventHandler WindowMaximizeClicked;
        public event EventHandler WindowCloseClicked;


        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            

            WindowMinimizeClicked?.Invoke(this, EventArgs.Empty);
        }

        private void MaximizeButton_Click(object sender, EventArgs e)
        {
            WindowMaximizeClicked?.Invoke(this, EventArgs.Empty);
            ToggleIcon();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            WindowCloseClicked?.Invoke(this, EventArgs.Empty);
        }




    }
}

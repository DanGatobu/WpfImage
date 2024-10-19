using System.Windows.Input;
using Thisisbull = System.Windows.Controls;
using Winforms = System.Windows.Forms;
using System.Diagnostics;
using imagev.Data;
using imagev.MVVM.Model;
namespace imagev.MVVM.Views.Usercontrol

{
    /// <summary>
    /// Interaction logic for AddFolderbtn.xaml
    /// </summary>
    public partial class AddFolderbtn : Thisisbull.UserControl
    {
        public AddFolderbtn()
        {
            InitializeComponent();

        }
        public void Show_pop_up()
        {
            Adfd.IsOpen = true;

        }
        public static void Add_lintdb( string Fpath)
        {
            using (var Dbc = new AppDbcontext())
            {
                var Fdl = new Foldermodel();
                Fdl.FolderLink = Fpath;
                Dbc.Folders.Add(Fdl);
                Dbc.SaveChanges();
            }

        }

        private void Adf(object sender, MouseButtonEventArgs e)

        {
            Debug.WriteLine("nimeitewa");

            Winforms.FolderBrowserDialog dialog = new Winforms.FolderBrowserDialog();
            Winforms.DialogResult result = dialog.ShowDialog();
            if(result == Winforms.DialogResult.OK)
            {
                string Fpath = dialog.SelectedPath;
                Add_lintdb(Fpath);
                
                
            }

        }

       
    }
}

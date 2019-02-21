using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using LoginApplication.Tools.Managers;
using LoginApplication.ViewModels;

namespace LoginApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IContentOwner
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
            NavigateManager.Instance.Innitialize(new BaseNavigationModel(this));
            NavigateManager.Instance.Navigate(ViewType.SignIn);

        }

        public ContentControl ContentControl
        {
            get
            {
                return _contentControl;
            }
        }
    }
}

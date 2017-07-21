using UwpSample.ViewModels;
using Windows.UI.Xaml.Controls;

namespace UwpSample
{
    public sealed partial class AcademyView : Page
    {
        public AcademyView()
        {
            this.InitializeComponent();
            ViewModel = new AcademyViewModel();
        }

        public AcademyViewModel ViewModel { get; set; }
    }
}

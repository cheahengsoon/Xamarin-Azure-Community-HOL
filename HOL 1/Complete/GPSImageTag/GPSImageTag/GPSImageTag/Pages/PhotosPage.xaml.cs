using GPSImageTag.ViewModels;
using Xamarin.Forms;

namespace GPSImageTag
{
    public partial class PhotosPage : ContentPage
    {
        PhotosPageViewModel vm;
        public PhotosPage()
        {
            InitializeComponent();

            vm = new PhotosPageViewModel();

            BindingContext = vm;
        }
    }
}

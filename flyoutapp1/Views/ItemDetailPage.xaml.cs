using System.ComponentModel;
using Xamarin.Forms;
using flyoutapp1.ViewModels;

namespace flyoutapp1.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}

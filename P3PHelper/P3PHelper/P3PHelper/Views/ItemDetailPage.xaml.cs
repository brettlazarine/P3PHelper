using P3PHelper.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace P3PHelper.Views
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
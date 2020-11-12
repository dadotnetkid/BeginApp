using System.ComponentModel;
using Xamarin.Forms;
using BeginApp.ViewModels;

namespace BeginApp.Views
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
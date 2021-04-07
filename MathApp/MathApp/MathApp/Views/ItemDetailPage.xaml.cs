using MathApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MathApp.Views
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
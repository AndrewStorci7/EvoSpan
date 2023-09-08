using EvoSpan.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace EvoSpan.Views
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
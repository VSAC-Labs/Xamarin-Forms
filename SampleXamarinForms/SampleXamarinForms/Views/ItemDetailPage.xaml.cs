using SampleXamarinForms.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace SampleXamarinForms.Views
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
using MauiMigrationDemo.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MauiMigrationDemo.Views
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
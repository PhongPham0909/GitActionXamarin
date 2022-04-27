using System.ComponentModel;
using Xamarin.Forms;
using DemoGitActionXamarin.ViewModels;

namespace DemoGitActionXamarin.Views
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

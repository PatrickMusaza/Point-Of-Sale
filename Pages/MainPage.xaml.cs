using Point_Of_Sale.Models;
using Point_Of_Sale.PageModels;

namespace Point_Of_Sale.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}
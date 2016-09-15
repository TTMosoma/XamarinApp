namespace XamarinApp.Views.Master
{
    using Xamarin.Forms;
    using XamarinApp.Interfaces;
    public partial class MasterNavigation : ContentPage
    {
        public ListView ListView { get { return listView; } }

        public MasterNavigation(IMenuItems pageItems)
        {
            InitializeComponent();
            listView.ItemsSource = pageItems.LoadMasterPageItems();
        }
    }
}

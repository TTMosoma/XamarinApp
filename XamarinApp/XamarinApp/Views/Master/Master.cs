namespace XamarinApp.Views.Master
{
    using Classes;
    using System;
    using Xamarin.Forms;
    public class Master : MasterDetailPage
    {
        public Master(MasterNavigation master, Page detail)
        {
            master.ListView.ItemSelected += NavigateToDetailsPage;
            Master = master;
            Detail = new NavigationPage(detail);
        }

        private void NavigateToDetailsPage(object sender, SelectedItemChangedEventArgs e)
        {
            var listview = sender as ListView;
            listview.SelectedItem = null;

            var item = e.SelectedItem as MasterPageItem;

            if (item == null)
                return;
             
            Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
            IsPresented = false;
        }
    }
}

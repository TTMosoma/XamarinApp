using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using XamarinApp.Classes;

namespace XamarinApp.Views
{
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
            BindingContext = new ViewModels.Home();
        }

        protected override void OnAppearing()
        {
            MessagingCenter.Subscribe<NavigationMessage>(this, "Navigate", async (navigationMessage) =>
            {
                var selectedJob = navigationMessage.Parameter as Models.Job;
                await Navigation.PushModalAsync(new Job() {  BindingContext = new ViewModels.Job(selectedJob) }, true);
            });

            MessagingCenter.Subscribe<NavigationMessage>(this, "Dismiss", async (navigationMessage) =>
            {
                await Navigation.PopModalAsync(false);
            });

            base.OnAppearing();
        }
        protected override bool OnBackButtonPressed()
        {
            return base.OnBackButtonPressed();  
        }
        protected override void OnDisappearing()
        {
            MessagingCenter.Unsubscribe<NavigationMessage>(this, "Navigate");
            MessagingCenter.Unsubscribe<NavigationMessage>(this, "Dismiss");
            base.OnDisappearing();
        }

    }
}

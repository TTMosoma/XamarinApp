namespace XamarinApp.Classes
{
    using Interfaces;
    using System.Collections.Generic;

    public class MenuItems : IMenuItems
    {
        public List<MasterPageItem> LoadMasterPageItems()
        {
            var masterPageItems = new List<MasterPageItem>();
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Home",
                IconSource = "house.png",
                TargetType = typeof(Views.Home)
            });

            masterPageItems.Add(new MasterPageItem
            {
                Title = "About",
                IconSource = "about.png",
                TargetType = typeof(Views.About)
            });

            masterPageItems.Add(new MasterPageItem
            {
                Title = "Profile",
                IconSource = "profile.png",
                TargetType = typeof(Views.Profile)
            });

            return masterPageItems;
        }
    }
}

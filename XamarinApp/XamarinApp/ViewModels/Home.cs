
namespace XamarinApp.ViewModels
{
    using Models;
    using System.Collections.ObjectModel;
    using Mvvm;
    using System.Collections.Generic;
    using System;
    using Xamarin.Forms;
    using Classes;

    public class Home : MvvmBase
    {

        public ObservableCollection<Models.Job> Jobs { get; set; }
        private Models.Job selectedJob;

        public Models.Job SelectedJob
        {
            get { return selectedJob; }
            set
            {
                if (value == null) return;
                selectedJob = value;
                RaisePropertyChangedEvent(nameof(SelectedJob));

                MessagingCenter.Send(new NavigationMessage() { Parameter = SelectedJob }, "Navigate");
            }
        }

        public Home()
        {
            Jobs = new ObservableCollection<Models.Job>(LoadJobs());
        }

        private IEnumerable<Models.Job> LoadJobs()
        {
            var jobNames = new string[] { "Plumbing", "Roofing", "Drainage" };
            Random rnd = new Random();

            var people = new List<Person>();
            var jobs = new List<Models.Job>();
            for (int i = 0; i < 20; i++)
            {
                var jobname = jobNames[rnd.Next(jobNames.Length)];
                jobs.Add(new Models.Job()
                {
                    HoursSpent = rnd.Next(1, 10),
                    IsComplete = rnd.Next(1, 10) >= 5  ?  false : true,
                    JobImagePath = string.Format("{0}.png", jobname),
                    JobName = jobname,
                });
            }

            return jobs;
        }
    }
}

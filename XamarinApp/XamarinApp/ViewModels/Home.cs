
namespace XamarinApp.ViewModels
{
    using Models;
    using System.Collections.ObjectModel;
    using Mvvm;
    using System.Collections;
    using System.Collections.Generic;
    using System;
    using System.Windows.Input;
    using Xamarin.Forms;

    public class Home : MvvmBase
    {
        private ICommand completeChecked { get; set; }

        public ObservableCollection<Job> Jobs { get; set; }
        private Job selectedJob;

        public Job SelectedJob
        {
            get { return selectedJob; }
            set
            {
                if (value == null) return;
                selectedJob = value;
                RaisePropertyChangedEvent(nameof(SelectedJob));
            }
        }

        public Home()
        {
            CompleteChecked = new Command(CompleteAction);
            Jobs = new ObservableCollection<Job>(LoadJobs());
        }

        private void CompleteAction(object obj)
        {

        }

        public ICommand CompleteChecked
        {
            get { return completeChecked; }
            private set { completeChecked = value; }
        }
        private IEnumerable<Job> LoadJobs()
        {
            var jobNames = new string[] { "Plumbing", "Roofing", "Drainage" };
            Random rnd = new Random();

            var people = new List<Person>();
            var jobs = new List<Job>();
            for (int i = 0; i < 10; i++)
            {
                var jobname = jobNames[rnd.Next(jobNames.Length)];
                jobs.Add(new Job()
                {
                    HoursSpent = rnd.Next(1, 10),
                    IsComplete = false,
                    JobImagePath = string.Format("{0}.png", jobname),
                    JobName = jobname,
                });
            }

            return jobs;
        }
    }
}

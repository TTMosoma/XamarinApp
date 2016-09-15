
namespace XamarinApp.ViewModels
{
    using Models;
    using System.Collections.ObjectModel;
    using Mvvm;
    using System.Collections;
    using System.Collections.Generic;
    using System;

    public class Home : MvvmBase
    {
        public ObservableCollection<Job> Jobs { get; set; }

        public Home()
        {
            Jobs = new ObservableCollection<Job>(LoadJobs());
        }

        private IEnumerable<Job> LoadJobs()
        {
            var jobNames = new string[] { "Water plumbing", "Roofing", "Drainage" };
            Random rnd = new Random();

            var people = new List<Person>();
            var jobs = new List<Job>();
            for (int i = 0; i < 10; i++)
            {
                var jobname = jobNames[rnd.Next(jobNames.Length - 1)];
                jobs.Add(new Job()
                {
                    HoursSpent = rnd.Next(1, 10),
                    IsComplete = false,JobImagePath  = string.Format("{0}.png", jobname),
                    JobName = jobname,
                });
            }

            return jobs;
        }
    }
}

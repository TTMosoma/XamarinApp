namespace XamarinApp.Models
{
    using System;
    using XamarinApp.Mvvm;

    public class Job : MvvmBase
    {
        private decimal hoursSpent;
        private bool isComplete;
        private string jobImagepath;
        private string jobName;

        public decimal HoursSpent
        {
            get { return Math.Round(hoursSpent, 2); }
            set
            {
                if (hoursSpent == value)
                    return;
                hoursSpent = value;
                RaisePropertyChangedEvent(nameof(HoursSpent));
            }
        }

        public bool IsComplete
        {
            get { return isComplete; }
            set
            {
                if (isComplete == value)
                    return;

                isComplete = value;
                RaisePropertyChangedEvent(nameof(IsComplete));
            }
        }

        public string JobImagePath
        {
            get { return jobImagepath; }
            set
            {
                jobImagepath = value;
                RaisePropertyChangedEvent(nameof(JobImagePath));
            }
        }

        public string JobName
        {
            get { return jobName; }
            set
            {
                if (jobName == value)
                    return;

                jobName = value;
                RaisePropertyChangedEvent(nameof(JobName));
            }
        }

        public decimal RunningCost
        {
            get
            {
                return Math.Round(HoursSpent * 350, 2);
            }
        }
    }
}
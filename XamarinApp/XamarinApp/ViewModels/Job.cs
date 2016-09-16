using System.Windows.Input;
using Xamarin.Forms;
using XamarinApp.Classes;

namespace XamarinApp.ViewModels
{
    public class Job : Mvvm.MvvmBase
    {
        private ICommand dismiss;
        private Models.Job selectedJob;

        public Models.Job SelectedJob
        {
            get { return selectedJob; }
            set { selectedJob = value; }
        }

        public Job(Models.Job job)
        {
            SelectedJob = job;
            Dismiss = new Command(DismissAction);
            CompleteChecked = new Command(CompleteAction);
        }

        public ICommand CompleteChecked
        {
            get { return completeChecked; }
            private set { completeChecked = value; }
        }

        public ICommand Dismiss
        {
            get { return dismiss; }
            private set { dismiss = value; }
        }

        private ICommand completeChecked { get; set; }

        private void CompleteAction(object obj)
        {
        }

        private void DismissAction(object obj)
        {
            MessagingCenter.Send(new NavigationMessage(), "Dismiss");
        }
    }
}
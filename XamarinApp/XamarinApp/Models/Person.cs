
namespace XamarinApp.Models
{
    using Mvvm;

    public class Person : MvvmBase
    {
        public Person()
        {
        }

        private decimal costPerHour;

        public decimal CostPerHour
        {
            get { return costPerHour; }
            private set
            {
                if (costPerHour == value)
                    return;

                costPerHour = value;
                RaisePropertyChangedEvent(nameof(CostPerHour));
            }
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public string CellNumber { get; set; }
    }
}

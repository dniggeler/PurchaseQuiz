using System.ComponentModel;

namespace WpfPurchaseQuizApp.Models
{
    public class QuizData : INotifyPropertyChanged
    {
        private int _availablePurchase = 0;
        private int _year1Purchase = 0;
        private int _year2Purchase = 0;
        private int _year3Purchase = 0;
        private int _year4Purchase = 0;
        private int _year5Purchase = 0;

        public double PurchaseMax => 100000.0;

        public double PurchaseTotal
        {
            get
            {
                return (Year1Purchase + Year2Purchase + Year3Purchase + Year4Purchase + Year5Purchase);
            }
        }
        public double AvailablePurchase
        {
            get
            {
                return PurchaseMax - PurchaseTotal;
            }
        }

        public int Year1Purchase
        {
            get { return _year1Purchase; }

            set
            {
                _year1Purchase = value;
                this.OnPropertyChanged("PurchaseTotal");
                this.OnPropertyChanged("AvailablePurchase");
            }
        }

        public int Year2Purchase
        {
            get { return _year2Purchase; }

            set
            {
                _year2Purchase = value;
                this.OnPropertyChanged("PurchaseTotal");
                this.OnPropertyChanged("AvailablePurchase");
            }
        }

        public int Year3Purchase
        {
            get { return _year3Purchase; }

            set
            {
                _year3Purchase = value;
                this.OnPropertyChanged("PurchaseTotal");
                this.OnPropertyChanged("AvailablePurchase");
            }
        }

        public int Year4Purchase
        {
            get { return _year4Purchase; }

            set
            {
                _year4Purchase = value;
                this.OnPropertyChanged("PurchaseTotal");
                this.OnPropertyChanged("AvailablePurchase");
            }
        }

        public int Year5Purchase
        {
            get { return _year5Purchase; }

            set
            {
                _year5Purchase = value;
                this.OnPropertyChanged("PurchaseTotal");
                this.OnPropertyChanged("AvailablePurchase");
            }
        }

        public QuizData()
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

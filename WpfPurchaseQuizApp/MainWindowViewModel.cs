using System.ComponentModel;
using WpfPurchaseQuizApp.Models;

namespace WpfPurchaseQuizApp
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private SimulationResultViewModel _simulationResultViewModel;
        private SimulationInputViewModel _simulationInputViewModel;
        private int _year1Purchase = 0;
        private int _year2Purchase = 0;
        private int _year3Purchase = 0;
        private int _year4Purchase = 0;
        private int _year5Purchase = 0;


        public MainWindowViewModel()
        {
            SimulationResultViewModel = new SimulationResultViewModel();
            SimulationInputViewModel = new SimulationInputViewModel();
        }

        public int PurchaseMax => 100000;

        public int PurchaseTotal
        {
            get { return (_year1Purchase + _year2Purchase + _year3Purchase + _year4Purchase + _year5Purchase); }
        }


        public int Year1Purchase
        {
            get { return _year1Purchase; }

            set
            {
                _year1Purchase = value;

                if (PurchaseTotal > PurchaseMax)
                {
                    _year1Purchase -= (PurchaseTotal - PurchaseMax);
                }
                SimulationInputViewModel.AvailableAmountForPurchase = PurchaseMax - PurchaseTotal;

                this.OnPropertyChanged("Year1Purchase");
            }
        }

        public int Year2Purchase
        {
            get { return _year2Purchase; }

            set
            {
                _year2Purchase = value;

                if (PurchaseTotal > PurchaseMax)
                {
                    _year2Purchase -= (PurchaseTotal - PurchaseMax);
                }
                SimulationInputViewModel.AvailableAmountForPurchase = PurchaseMax - PurchaseTotal;

                this.OnPropertyChanged("Year2Purchase");
            }
        }

        public int Year3Purchase
        {
            get { return _year3Purchase; }

            set
            {
                _year3Purchase = value;

                if (PurchaseTotal > PurchaseMax)
                {
                    _year3Purchase -= (PurchaseTotal - PurchaseMax);
                }
                SimulationInputViewModel.AvailableAmountForPurchase = PurchaseMax - PurchaseTotal;

                this.OnPropertyChanged("Year3Purchase");
            }
        }

        public int Year4Purchase
        {
            get { return _year4Purchase; }

            set
            {
                _year4Purchase = value;

                if (PurchaseTotal > PurchaseMax)
                {
                    _year4Purchase -= (PurchaseTotal - PurchaseMax);
                }
                SimulationInputViewModel.AvailableAmountForPurchase = PurchaseMax - PurchaseTotal;

                this.OnPropertyChanged("Year4Purchase");
            }
        }

        public int Year5Purchase
        {
            get { return _year5Purchase; }

            set
            {
                _year5Purchase = value;

                {
                    SimulationInputViewModel.AvailableAmountForPurchase = PurchaseMax - PurchaseTotal;
                }

                if (PurchaseTotal > PurchaseMax)
                {
                    _year5Purchase -= (PurchaseTotal - PurchaseMax);
                }
                SimulationInputViewModel.AvailableAmountForPurchase = PurchaseMax - PurchaseTotal;

                this.OnPropertyChanged("Year5Purchase");
            }
        }


        public SimulationResultViewModel SimulationResultViewModel
        {
            get { return _simulationResultViewModel; }
            set
            {
                _simulationResultViewModel = value;
                OnPropertyChanged("SimulationResultViewModel");
            }
        }

        public SimulationInputViewModel SimulationInputViewModel
        {
            get { return _simulationInputViewModel; }
            set
            {
                _simulationInputViewModel = value;
                OnPropertyChanged("SimulationInputViewModel");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {         
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
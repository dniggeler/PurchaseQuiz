using System.ComponentModel;
using System.Windows.Input;

namespace WpfPurchaseQuizApp.Models
{
    public class SimulationInputViewModel : INotifyPropertyChanged
    {
        private int _nbrYearsToSimulate;
        private double _supplementaryInterestRate;
        private int _grossSalary;
        private string _cityOfTax;
        private int _availablePurchase;

        private FinalAmountCommand _finalAmountCommand;

        public SimulationInputViewModel()
        {
            _cityOfTax = "Zürich";
            _grossSalary = 100000;
            _nbrYearsToSimulate = 5;

            _finalAmountCommand = new FinalAmountCommand();
        }

        public ICommand SimulateCommand
        {
            get
            {
                return _finalAmountCommand;
            }
        }

        public double SupplementaryInterestRate
        {
            get { return _supplementaryInterestRate; }
            set
            {
                _supplementaryInterestRate = value;
                this.OnPropertyChanged("SupplementaryInterestRate");
            }
        }

        public int GrossSalary
        {
            get { return _grossSalary; }
            set
            {
                _grossSalary = value;
                this.OnPropertyChanged("GrossSalary");
            }
        }

        public int NbrYearsToSimulate
        {
            get { return _nbrYearsToSimulate; }
            set
            {
                _nbrYearsToSimulate = value;
                this.OnPropertyChanged("NbrYearsToSimulate");
            }
        }

        public string CityOfTax
        {
            get { return _cityOfTax; }
            set
            {
                _cityOfTax = value;
                this.OnPropertyChanged("CityOfTax");
            }
        }

        public int AvailableAmountForPurchase
        {
            get { return _availablePurchase; }
            set
            {
                _availablePurchase = value;
                this.OnPropertyChanged("AvailableAmountForPurchase");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
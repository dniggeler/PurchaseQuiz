using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfPurchaseQuizApp.Models
{
    public class SimulationResultViewModel : INotifyPropertyChanged
    {
        private double _finalRetirementAmount;
        private double _finalRetirementAmountExTax;

        public double FinalRetirementAmount
        {
            get { return _finalRetirementAmount; }
            set
            {
                _finalRetirementAmount = value;
                this.OnPropertyChanged("FinalRetirementAmount");
            }
        }

        public double FinalRetirementAmountExTax
        {
            get { return _finalRetirementAmountExTax; }
            set
            {
                _finalRetirementAmountExTax = value;
                this.OnPropertyChanged("FinalRetirementAmountExTax");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

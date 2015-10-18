using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfPurchaseQuizApp.Models
{
    public class SimulationInputViewModel : INotifyPropertyChanged
    {
        public int NbrYearsToSimulate { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}

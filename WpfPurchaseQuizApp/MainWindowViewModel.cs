using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfPurchaseQuizApp.Models;

namespace WpfPurchaseQuizApp
{
    public class MainWindowViewModel
    {
        public MainWindowViewModel()
        {
            SimulationResultViewModel = new SimulationResultViewModel();

            SimulationInputViewModel = new SimulationInputViewModel();
        }

        public SimulationResultViewModel SimulationResultViewModel { get; set; }
        public SimulationInputViewModel SimulationInputViewModel { get; set; }
    }
}

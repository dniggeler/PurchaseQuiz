using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfPurchaseQuizApp.Models
{
    public class FinalAmountCommand : ICommand
    {
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var input = parameter as SimulationInputViewModel;

            MessageBox.Show($"Number of years to simulate: {input.NbrYearsToSimulate}");
        }

        public event EventHandler CanExecuteChanged;
    }
}
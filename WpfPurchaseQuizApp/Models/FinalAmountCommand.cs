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
            MessageBox.Show("Final amount is 150000");
            var result = 150000M;
        }

        public event EventHandler CanExecuteChanged;
    }
}
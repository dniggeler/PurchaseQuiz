using System;
using System.ComponentModel;
using System.Windows.Input;

namespace WpfPurchaseQuizApp.Models
{
    public class QuizData : INotifyPropertyChanged
    {
        private FinalAmountCommand _finalAmountCommand;


        public QuizData()
        {
            _finalAmountCommand = new FinalAmountCommand();
        }

        public ICommand SimulateCommand
        {
            get { return _finalAmountCommand; }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfPurchaseQuizApp.Models;

namespace WpfPurchaseQuizApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public QuizData Data { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            Data = new QuizData();

            this.PurchaseSlider1.DataContext = Data;
            this.PurchaseSlider2.DataContext = Data;
            this.PurchaseSlider3.DataContext = Data;
            this.PurchaseSlider4.DataContext = Data;
            this.PurchaseSlider5.DataContext = Data;
            this.TbAvailablePurchase.DataContext = Data;
            this.TbStatus.DataContext = Data;
        }
    }
}

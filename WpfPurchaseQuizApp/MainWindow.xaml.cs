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
        public const double MaxPurchase = 50000;

        protected QuizData Data { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            Data = new QuizData();

            this.purchaseSlider1.DataContext = Data;
            this.purchaseSlider2.DataContext = Data;
            this.purchaseSlider3.DataContext = Data;
            this.purchaseSlider4.DataContext = Data;
            this.purchaseSlider5.DataContext = Data;
            this.TbPurchaseTotal.DataContext = Data;
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Data.PurchaseTotal.ToString());
        }
    }
}

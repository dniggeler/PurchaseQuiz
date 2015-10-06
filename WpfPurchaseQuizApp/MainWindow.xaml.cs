﻿using System;
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

        protected QuizConfig config { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            config = new QuizConfig();

            this.purchaseSlider1.DataContext = config;
            this.purchaseSlider1.Maximum = config.PurchaseTotal;
        }
    }
}

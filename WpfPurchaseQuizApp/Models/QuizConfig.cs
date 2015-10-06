using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfPurchaseQuizApp.Models
{
    public sealed class QuizConfig
    {
        public double PurchaseTotal { get; set; }
        public double Value1 { get; set; }

        public QuizConfig()
        {
            PurchaseTotal = 50000;
        }
    }
}

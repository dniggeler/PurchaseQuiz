using System;

namespace Calculators.Bvg.Contracts.Models
{
    public class CustomerData
    {
        public DateTime Birthdate { get; set; }
        public DateTime? RetiredAt { get; set; }
        public int Gender { get; set; }
        public decimal PartTimeDegree { get; set; }
        public decimal DisabilityDegree { get; set; }
        public decimal ReportedSalary { get; set; }
        public decimal RetirementCapitalBvgBoY { get; set; }
        public decimal RetirementCapitalBvgEoY { get; set; }
        public decimal RetirementCapitalTotalBoY { get; set; }
        public decimal RetirementCapitalTotalEoY { get; set; }
        public decimal FinalRetirementAssets { get; set; }
        public decimal FinalRetirementAssetsExtra { get; set; }
        public decimal FinalRetirementAssetsBvg { get; set; }
        public decimal FinalRetirementAssetsNoInterest { get; set; }
        public decimal FinalRetirementAssetsNoInterestExtra { get; set; }
        public decimal FinalRetirementAssetsNoInterestBvg { get; set; }
        public decimal MaxPurchaseAmount { get; set; }
        public decimal ConversionRateBvg { get; set; }
        public decimal ConversionRateExtra { get; set; }
        public decimal? MaxWithdrawableAmount { get; set; }
    }
}
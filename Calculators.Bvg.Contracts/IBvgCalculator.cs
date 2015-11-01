using Calculators.Bvg.Contracts.Models;

namespace Calculators.Bvg.Contracts
{
    public interface IBvgCalculator
    {

        /// <summary>
        ///     Maximale AHV-Rente.
        /// </summary>
        /// <returns></returns>
        decimal AhvMax(int year);

        /// <summary>
        ///     BVG-Obergrenze für obligatorisch versicherbaren Jahreslohn.
        /// </summary>
        /// <returns></returns>
        decimal BvgMax(int year);

        /// <summary>
        ///     UVG-Obergrenze
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        decimal UvgMax(int year);

        /// <summary>
        ///     Maximaler im BVG versicherbarer Jahreslohn.
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        decimal MaxBvgVersLohn(int year);

        /// <summary>
        ///     Koordinationsabzug für BVG-Jahreslohn
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        decimal BvgKoord(int year);

        /// <summary>
        ///     Maximal versicherbarer Jahreslohn im BVG.
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        decimal BvgMaxInsured(int year);

        /// <summary>
        ///     Minimal versicherter/koordinierter Lohn
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        decimal BvgMin(int year);

        /// <summary>
        ///     BVG Jahreslohn
        /// </summary>
        /// <param name="processDetails"></param>
        /// <returns></returns>
        decimal BvgBeff(CustomerData processDetails);

        /// <summary>
        ///     Versicherter BVG-Lohn
        /// </summary>
        /// <param name="processDetails"></param>
        /// <returns></returns>
        decimal BvgBanr(CustomerData processDetails);

        /// <summary>
        ///     BVGs the minimum wage (BVG-Eintrittsschwelle).
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        decimal BvgMinimumWage(int year);

        /// <summary>
        ///     BVG Umwandlungssatz.
        /// </summary>
        /// <param name="processDetails"></param>
        /// <returns></returns>
        decimal UmwsBvg(CustomerData processDetails);

        /// <summary>
        ///     factor retirement credit
        /// </summary>
        /// <param name="processDetails"></param>
        /// <returns></returns>
        decimal GetGutschriftBvg(CustomerData processDetails);

        #region benefits

        /// <summary>
        /// Yearly retirement credit BVG.
        /// </summary>
        /// <param name="processDetails"></param>
        /// <returns></returns>
        decimal BvgAgsJahr(CustomerData processDetails);

        /// <summary>
        /// BVG-Altersrente
        /// </summary>
        /// <param name="processDetails"></param>
        /// <returns></returns>
        decimal BvgAltersrente(CustomerData processDetails);

        /// <summary>
        /// BVG-Witwenrente durch Krankheit.
        /// </summary>
        /// <param name="processDetails"></param>
        /// <returns></returns>
        decimal BvgWitwenRenteKrankheit(CustomerData processDetails);

        /// <summary>
        /// BVG-Witwenrente durch Unfall.
        /// </summary>
        /// <param name="processDetails"></param>
        /// <returns></returns>
        decimal BvgWitwenRenteUnfall(CustomerData processDetails);

        /// <summary>
        /// BVG-Invalidenrente durch Krankheit.
        /// </summary>
        /// <param name="processDetails"></param>
        /// <returns></returns>
        decimal BvgInvalidenRenteKrankheit(CustomerData processDetails);

        /// <summary>
        /// BVG-Invalidenrente durch Unfall.
        /// </summary>
        /// <param name="processDetails"></param>
        /// <returns></returns>
        decimal BvgInvalidenRenteUnfall(CustomerData processDetails);

        #endregion
    }
}
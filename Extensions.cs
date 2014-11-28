using System;
using System.Globalization;

namespace CountryLanguageCurrency
{
    /// <summary>
    /// Extensions
    /// </summary>
    public static class Extensions
    {
        #region String

        /// <summary>
        /// Make first letter uppercase
        /// </summary>
        /// <param name="s">String to process</param>
        /// <returns>Passed string with first letter uppercase</returns>
        public static string FirstLetterUpperCase(this string s)
        {
            if(string.IsNullOrEmpty(s))
                return s;

            char[] a = s.ToCharArray();
            a[0] = char.ToUpperInvariant(a[0]);
            return new string(a);
        }

        #endregion

        #region CultureInfo

        /// <summary>
        /// Get root culture, i.e. the last parent before the invariant culture.
        /// </summary>
        /// <remarks>
        /// Never returns null.
        /// </remarks>
        /// <param name="cultureInfo">The <see cref="CultureInfo"/> to get the root for.</param>
        /// <returns><paramref name="cultureInfo"/>'s root culture, i.e. the last parent before the invariant culture.</returns>
        public static CultureInfo GetRootCulture(this CultureInfo cultureInfo)
        {
            while(cultureInfo.Parent.LCID != CultureInfo.InvariantCulture.LCID)
                cultureInfo = cultureInfo.Parent;

            return cultureInfo;
        }

        /// <summary>
        /// Gets a <see cref="LanguageCode"/> for the passed <paramref name="cultureInfo"/>.
        /// </summary>
        /// <remarks>
        /// Never returns null.
        /// </remarks>
        /// <param name="cultureInfo">The <see cref="cultureInfo"/> to get the <see cref="LanguageCode"/> for.</param>
        /// <returns>The <see cref="LanguageCode"/> corresponding to <paramref name="cultureInfo"/>.</returns>
        public static LanguageCode GetLanguageCode(this CultureInfo cultureInfo)
        {
            // Get root language, e.g. for chinese.
            cultureInfo = cultureInfo.GetRootCulture();

            string languageCodeString = cultureInfo.TwoLetterISOLanguageName.ToLowerInvariant().FirstLetterUpperCase();
            return (LanguageCode)Enum.Parse(typeof(LanguageCode), languageCodeString);
        }

        /// <summary>
        /// Gets a <see cref="LanguageInfo"/> for the passed <paramref name="cultureInfo"/>.
        /// </summary>
        /// <remarks>
        /// Never returns null.
        /// </remarks>
        /// <param name="cultureInfo">The <see cref="cultureInfo"/> to get the <see cref="LanguageInfo"/> for.</param>
        /// <returns>The <see cref="LanguageInfo"/> corresponding to <paramref name="cultureInfo"/>.</returns>
        public static LanguageInfo GetLanguage(this CultureInfo cultureInfo)
        {
            return LanguageInfo.GetLanguage(cultureInfo.GetLanguageCode());
        }

        /// <summary>
        /// Gets the <see cref="CountryCode"/> for the passed <see cref="CultureInfo"/>.
        /// </summary>
        /// <param name="cultureInfo">The <see cref="CultureInfo"/> to get the <see cref="CountryCode"/> for.</param>
        /// <returns>The <see cref="CountryCode"/> corresponding to <paramref name="cultureInfo"/> or null when there is no region associated with <paramref name="cultureInfo"/>, i.e. when <paramref name="cultureInfo"/> is a neutral or the invariant culture.</returns>
        public static CountryCode? GetCountryCode(this CultureInfo cultureInfo)
        {
            return cultureInfo.LCID == CultureInfo.InvariantCulture.LCID || cultureInfo.IsNeutralCulture ? (CountryCode?)null : new RegionInfo(cultureInfo.LCID).GetCountryCode();
        }

        /// <summary>
        /// Gets the default <see cref="CountryCode"/> for the passed <see cref="CultureInfo"/>.
        /// </summary>
        /// <remarks>
        /// For the invariant culture, this is null.
        /// For a neutral culture, i.e. a culture not associated with a country, this is the <see cref="CountryCode"/> of the corresponding <see cref="LanguageInfo.Country"/>, i.e. the language's origin, e.g. "France" for "French".
        /// For all others, i.e. all specific cultures, this is the same as <see cref="GetCountryCode(CultureInfo)"/>.
        /// </remarks>
        /// <param name="cultureInfo">The <see cref="CultureInfo"/> to get the default <see cref="CountryCode"/> for.</param>
        /// <returns>The default <see cref="CountryCode"/> corresponding to <paramref name="cultureInfo"/> or null when <paramref name="cultureInfo"/> is the invariant culture.</returns>
        public static CountryCode? GetDefaultCountryCode(this CultureInfo cultureInfo)
        {
            return cultureInfo.LCID == CultureInfo.InvariantCulture.LCID ? null : (cultureInfo.IsNeutralCulture ? cultureInfo.GetLanguage().Country.Code : cultureInfo.GetCountryCode());
        }

        /// <summary>
        /// Gets a <see cref="CountryInfo"/> for the passed <see cref="CultureInfo"/>.
        /// </summary>
        /// <param name="cultureInfo">The <see cref="CultureInfo"/> to get the <see cref="CountryInfo"/> for.</param>
        /// <returns>The <see cref="CountryInfo"/> corresponding to <paramref name="cultureInfo"/> or null when there is no region associated with <paramref name="cultureInfo"/>, i.e. when <paramref name="cultureInfo"/> is a neutral or the invariant culture.</returns>
        public static CountryInfo GetCountry(this CultureInfo cultureInfo)
        {
            CountryCode? countryCode = cultureInfo.GetCountryCode();
            return countryCode == null ? null : CountryInfo.GetCountry(countryCode.Value);
        }

        /// <summary>
        /// Gets the default <see cref="CountryInfo"/> for the passed <see cref="CultureInfo"/>.
        /// </summary>
        /// <remarks>
        /// For the invariant culture, this is null.
        /// For a neutral culture, i.e. a culture not associated with a country, this the same as <see cref="LanguageInfo.Country"/>, i.e. the language's origin, e.g. "France" for "French".
        /// For all others, i.e. all specific cultures, this is the same as <see cref="GetCountry(CultureInfo)"/>.
        /// </remarks>
        /// <param name="cultureInfo">The <see cref="CultureInfo"/> to get the default <see cref="CountryInfo"/> for.</param>
        /// <returns>The default <see cref="CountryInfo"/> corresponding to <paramref name="cultureInfo"/> or null when <paramref name="cultureInfo"/> is the invariant culture.</returns>
        public static CountryInfo GetDefaultCountry(this CultureInfo cultureInfo)
        {
            return cultureInfo.LCID == CultureInfo.InvariantCulture.LCID ? null : (cultureInfo.IsNeutralCulture ? cultureInfo.GetLanguage().Country : cultureInfo.GetCountry());
        }
 
        /// <summary>
        /// Gets the <see cref="CurrencyCode"/> for the passed <see cref="CultureInfo"/>.
        /// </summary>
        /// <param name="cultureInfo">The <see cref="CultureInfo"/> to get the <see cref="CurrencyCode"/> for.</param>
        /// <returns>The <see cref="CurrencyCode"/> corresponding to <paramref name="cultureInfo"/> or null when there is no region associated with <paramref name="cultureInfo"/>, i.e. when <paramref name="cultureInfo"/> is a neutral or the invariant culture.</returns>
        public static CurrencyCode? GetCurrencyCode(this CultureInfo cultureInfo)
        {
            CountryInfo countryInfo = cultureInfo.GetCountry();
            return countryInfo == null ? (CurrencyCode?)null : countryInfo.CurrencyCode;
        }

        /// <summary>
        /// Gets the default <see cref="CurrencyCode"/> for the passed <see cref="CultureInfo"/>.
        /// </summary>
        /// <remarks>
        /// For the invariant culture, this is null.
        /// For a neutral culture, i.e. a culture not associated with a country, this is the <see cref="CurrencyCode"/> of the corresponding default country, i.e. the currency code of the language's origin, e.g. "Euro" for "France" for "French".
        /// For all others, i.e. all specific cultures, this is the same as <see cref="GetCurrencyCode(CultureInfo)"/>.
        /// </remarks>
        /// <param name="cultureInfo">The <see cref="CultureInfo"/> to get the default <see cref="CurrencyCode"/> for.</param>
        /// <returns>The default <see cref="CurrencyCode"/> corresponding to <paramref name="cultureInfo"/> or null when <paramref name="cultureInfo"/> is the invariant culture.</returns>
        public static CurrencyCode? GetDefaultCurrencyCode(this CultureInfo cultureInfo)
        {
            return cultureInfo.LCID == CultureInfo.InvariantCulture.LCID ? null : (cultureInfo.IsNeutralCulture ? cultureInfo.GetLanguage().Country.CurrencyCode : cultureInfo.GetCurrencyCode());
        }

        /// <summary>
        /// Gets a <see cref="CurrencyInfo"/> for the passed <see cref="CultureInfo"/>.
        /// </summary>
        /// <param name="cultureInfo">The <see cref="CultureInfo"/> to get the <see cref="CurrencyInfo"/> for.</param>
        /// <returns>The <see cref="CurrencyInfo"/> corresponding to <paramref name="cultureInfo"/> or null when there is no region associated with <paramref name="cultureInfo"/>, i.e. when <paramref name="cultureInfo"/> is a neutral or the invariant culture.</returns>
        public static CurrencyInfo GetCurrency(this CultureInfo cultureInfo)
        {
            CountryInfo countryInfo = cultureInfo.GetCountry();
            return countryInfo == null ? null : countryInfo.Currency;
        }

        /// <summary>
        /// Gets the default <see cref="CurrencyInfo"/> for the passed <see cref="CultureInfo"/>.
        /// </summary>
        /// <remarks>
        /// For the invariant culture, this is null.
        /// For a neutral culture, i.e. a culture not associated with a country, this is the <see cref="CurrencyInfo"/> of the corresponding default country, i.e. the currency of the language's origin, e.g. "Euro" for "France" for "French".
        /// For all others, i.e. all specific cultures, this is the same as <see cref="GetCurrency(CultureInfo)"/>.
        /// </remarks>
        /// <param name="cultureInfo">The <see cref="CultureInfo"/> to get the default <see cref="CurrencyInfo"/> for.</param>
        /// <returns>The default <see cref="CurrencyInfo"/> corresponding to <paramref name="cultureInfo"/> or null when <paramref name="cultureInfo"/> is the invariant culture.</returns>
        public static CurrencyInfo GetDefaultCurrency(this CultureInfo cultureInfo)
        {
            return cultureInfo.LCID == CultureInfo.InvariantCulture.LCID ? null : (cultureInfo.IsNeutralCulture ? cultureInfo.GetLanguage().Country.Currency : cultureInfo.GetCurrency());
        }
 
        #endregion

        #region RegionInfo

        /// <summary>
        /// Gets the <see cref="CountryCode"/> for the passed <see cref="RegionInfo"/>.
        /// </summary>
        /// <remarks>
        /// Never returns null.
        /// </remarks>
        /// <param name="regionInfo">The <see cref="RegionInfo"/> to get the <see cref="CountryCode"/> for.</param>
        /// <returns>The <see cref="CountryCode"/> corresponding to <paramref name="regionInfo"/>.</returns>
        public static CountryCode GetCountryCode(this RegionInfo regionInfo)
        {
            CountryCode? countryCode = CountryInfo.GetCountryCode(regionInfo.TwoLetterISORegionName);

            // This should never happen. Just to make Resharper happy.
            if(countryCode == null)
                throw new ArgumentException(string.Format("There is no CountryCode for region '{0}'.", regionInfo.TwoLetterISORegionName));

            return countryCode.Value;
        }

        /// <summary>
        /// Gets a <see cref="CountryInfo"/> for the passed <see cref="RegionInfo"/>.
        /// </summary>
        /// <remarks>
        /// Never returns null.
        /// </remarks>
        /// <param name="regionInfo">The <see cref="RegionInfo"/> to get the <see cref="CountryInfo"/> for.</param>
        /// <returns>The <see cref="CountryInfo"/> corresponding to <paramref name="regionInfo"/>.</returns>
        public static CountryInfo GetCountry(this RegionInfo regionInfo)
        {
            return CountryInfo.GetCountry(regionInfo.GetCountryCode());
        }

        /// <summary>
        /// Gets a <see cref="CurrencyInfo"/> for the passed <see cref="RegionInfo"/>.
        /// </summary>
        /// <remarks>
        /// Never returns null.
        /// </remarks>
        /// <param name="regionInfo">The <see cref="RegionInfo"/> to get the <see cref="CurrencyInfo"/> for.</param>
        /// <returns>The <see cref="CurrencyInfo"/> corresponding to <paramref name="regionInfo"/>.</returns>
        public static CurrencyInfo GetCurrency(this RegionInfo regionInfo)
        {
            return regionInfo.GetCountry().Currency;
        }

        /// <summary>
        /// Gets the <see cref="CurrencyCode"/> for the passed <see cref="RegionInfo"/>.
        /// </summary>
        /// <remarks>
        /// Never returns null.
        /// </remarks>
        /// <param name="regionInfo">The <see cref="RegionInfo"/> to get the <see cref="CurrencyCode"/> for.</param>
        /// <returns>The <see cref="CurrencyCode"/> corresponding to <paramref name="regionInfo"/>.</returns>
        public static CurrencyCode GetCurrencyCode(this RegionInfo regionInfo)
        {
            return regionInfo.GetCountry().CurrencyCode;
        }

        #endregion
    }
}

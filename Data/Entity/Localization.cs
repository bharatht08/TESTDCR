namespace Lshp.BaseWebApi.Data.Entity
{
    /// <summary>
    /// Localization
    /// </summary>
    public class Localization : BaseEntity
    {
        /// <summary>
        /// Culture
        /// </summary>
        public string Culture { get; set; }

        /// <summary>
        /// Key of the string
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// value of the key in that Culture
        /// </summary>
        public string Value { get; set; }
    }
}
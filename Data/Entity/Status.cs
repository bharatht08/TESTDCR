namespace Lshp.BaseWebApi.Data.Entity
{
    /// <summary>
    /// Status Entity
    /// </summary>
    public class Status : BaseEntity
    {
        /// <summary>
        /// Status Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Status Code
        /// </summary>
        public string Code { get; set; }
    }
}
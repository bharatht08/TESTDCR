using System;

namespace Lshp.BaseWebApi.Data.Entity
{
    /// <summary>
    /// baseentity for all other entity
    /// </summary>
    public class BaseEntity
    {
        /// <summary>
        /// primary Key
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// date when the records is created
        /// </summary>
        public DateTime CreatedDate { get; set; }
        /// <summary>
        /// datetime when the record is modified
        /// </summary>
        public DateTime? ModifiedDate { get; set; }
        /// <summary>
        /// datetime for inactive
        /// </summary>
        public DateTime? InactiveDate { get; set; }
    }
}
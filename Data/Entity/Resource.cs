using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;  
using System.ComponentModel.DataAnnotations.Schema;  

namespace Lshp.BaseWebApi.Data.Entity
{
    /// <summary>
    /// Resource
    /// </summary>
    public class Resource:BaseEntity
    {
        /// <summary>
        /// ResourceID Composite key
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ResourceID{get;set;}

        /// <summary>
        /// OwnerID composite key
        /// </summary>
        public int OwnerID{get;set;}

        /// <summary>
        /// OwnerId will be Foreign key references from Users Table
        /// </summary>
        [ForeignKey("OwnerID")]
        public Users users{get;set;}

        /// <summary>
        /// Name of resource
        /// </summary>
        public string ResourceName{get;set;}

        /// <summary>
        /// Url of resource
        /// </summary>
        public string ResourceDetails{get;set;}

        /// <summary>
        /// ShareResource
        /// </summary>
        public IList<ShareResource> ShareResource { get; set; }

    }
}
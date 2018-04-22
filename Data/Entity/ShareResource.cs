using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Lshp.BaseWebApi.Data.Entity
{
    /// <summary>
    /// ShareResource table property
    /// </summary>
    public class ShareResource:BaseEntity
    {
        /// <summary>
        /// ShareID is primary key
        /// </summary>
        public int ShareID{get;set;}
        /// <summary>
        /// ResourceID is Composite key
        /// </summary>
        public int ResourceID{get;set;}

        /// <summary>
        /// Resource
        /// </summary>
        [ForeignKey("ResourceID")]
        public Resource Resource{get;set;}

        /// <summary>
        /// ResourceID,OwnerID are foreign keys ref from Resource
        /// </summary>

        /// <summary>
        /// AccessLevelID is Composite key
        /// </summary>
        public int AccessID{get;set;}

        /// <summary>
        /// AccessID is foreign key ref from Acccess
        /// </summary>
        [ForeignKey("AccessID")]
        public Acccess Acccess{get;set;}

        /// <summary>
        /// UserID is Composite key
        /// </summary>
        public int ShareUserID{get;set;}

        /// <summary>
        /// users
        /// </summary>
        public Users users{get;set;}
    }
}
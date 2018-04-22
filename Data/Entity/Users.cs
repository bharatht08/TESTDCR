using System.Collections.Generic;
namespace Lshp.BaseWebApi.Data.Entity
{
    /// <summary>
    /// Users table property
    /// </summary>
    public class Users:BaseEntity
    {
        /// <summary>
        /// UserID primarykey
        /// </summary>
        public int UserID { get; set; }
       
        /// <summary>
        /// User's Name
        /// </summary>
        public string Name{get;set;}

        /// <summary>
        /// User EmailID
        /// </summary>
        public string Email{get;set;}

        /// <summary>
        /// User Passwords
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// ShareResource
        /// </summary>
        public IList<ShareResource> ShareResource { get; set; }
		
		/// <summary>
        /// ShareResource
        /// </summary>
        public IList<ShareResource> WSShareResource { get; set; }
		
		/// <summary>
        /// ShareResource
        /// </summary>
        public IList<ShareResource> ERShareResource { get; set; }
    }
}
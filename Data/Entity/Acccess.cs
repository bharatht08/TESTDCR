namespace Lshp.BaseWebApi.Data.Entity
{
    /// <summary>
    /// Access
    /// </summary>
    public class Acccess:BaseEntity
    {
        /// <summary>
        /// AccessID primarykey
        /// </summary>
        public int AccessID{get;set;}
        /// <summary>
        /// Accesstype defines AccessLevel
        /// </summary>
        public string AccessType{get;set;}
		/// <summary>
        /// AccessID primarykey
        /// </summary>
        public int TRAccessID{get;set;}
        /// <summary>
        /// Accesstype defines AccessLevel
        /// </summary>
        public string DMAccessType{get;set;}
		
		/// <summary>
        /// AccessID primarykey
        /// </summary>
        public int SEAccessID{get;set;}
        /// <summary>
        /// Accesstype defines AccessLevel
        /// </summary>
        public string LEAccessType{get;set;}
    }
}
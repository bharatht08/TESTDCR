namespace Lshp.BaseWebApi.Data.Entity
{
    /// <summary>
    /// Template table 
    /// </summary>
    public class Template : BaseEntity
    {
        /// <summary>
        /// Name of the template
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Template Body
        /// </summary>
        public string Body { get; set; }
        /// <summary>
        /// Template subject
        /// </summary>
        public string Subject { get; set; }
        /// <summary>
        /// MessageTypeID from MessageType
        /// </summary>
        public int MessageTypeId { get; set; }
        /// <summary>
        /// MessageType
        /// </summary>
        public virtual MessageType MessageType { get; set; }
		
		/// <summary>
        /// BHARTH _ MessageTypeID from MessageType
        /// </summary>
        public int BDMessageTypeId { get; set; }
        /// <summary>
        /// EWMessageType
        /// </summary>
        public virtual ETMessageType MessageType { get; set; }
    }
}
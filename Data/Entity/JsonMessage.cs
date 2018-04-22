namespace Lshp.BaseWebApi.Data.Entity
{
    /// <summary>
    /// JsonMessage Entity
    /// </summary>
    public class JsonMessage : BaseEntity
    {
        /// <summary>
        /// tamplateid from tempaltes table
        /// </summary>
        public int TemplateId { get; set; }
        /// <summary>
        /// Message which we need to send
        /// </summary>
        public string MessageData { get; set; }
        /// <summary>
        /// what is the subject of the message
        /// </summary>
        public string SubjectData { get; set; }
        /// <summary>
        /// to whom we need to send
        /// </summary>
        public string ToEmail { get; set; }
        /// <summary>
        /// status of the current message
        /// </summary>
        public int StatusId { get; set; }
        /// <summary>
        /// MessageType for messageType entity (eg: mobile/email)
        /// </summary>
        public int MessageTypeId { get; set; }
		
		 /// <summary>
        /// to whom we need to send
        /// </summary>
        public string SEToEmail { get; set; }
        /// <summary>
        /// status of the current message
        /// </summary>
        public int SSStatusId { get; set; }
        /// <summary>
        /// MessageType for messageType entity (eg: mobile/email)
        /// </summary>
        public int SWMessageTypeId { get; set; }
    }
}
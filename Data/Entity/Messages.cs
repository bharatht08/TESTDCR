using System;

namespace Lshp.BaseWebApi.Data.Entity
{
    /// <summary>
    /// Message Entity
    /// </summary>
    public class Message : BaseEntity
    {
        /// <summary>
        /// Content 
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Subject { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ToEmail { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? SentDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int StatusId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int RetryCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int JsonMessageId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int MessageTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual JsonMessage JsonMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual MessageType MessageType { get; set; }
    }
}
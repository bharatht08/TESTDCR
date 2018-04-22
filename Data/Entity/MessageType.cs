using System.Collections.Generic;

namespace Lshp.BaseWebApi.Data.Entity
{
    /// <summary>
    /// MessageType
    /// </summary>
    public class MessageType : BaseEntity
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public MessageType()
        {
            Messages = new HashSet<Message>();
            Templates = new HashSet<Template>();
        }

        /// <summary>
        /// Message Type 
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// Message code
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// List of Message associated with this messagetype
        /// </summary>
        public virtual ICollection<Message> Messages { get; set; }
        /// <summary>
        /// List of Templates associated with this messagetype
        /// </summary>
        public virtual ICollection<Template> Templates { get; set; }
    }
}
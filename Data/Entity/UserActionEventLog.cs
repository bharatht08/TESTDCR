namespace Lshp.BaseWebApi.Data.Entity
{
    /// <summary>
    /// UserActionEventLog table property
    /// </summary>
    public class UserActionEventLog : BaseEntity
    {
        /// <summary>
        /// eventid primarykey
        /// </summary>
        public int EventID { get; set; }
        /// <summary>
        /// LogLevel indicates the complexcity
        /// </summary>
        public string LogLevel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// http requestid
        /// </summary>
        public string RequestID { get; set; }
        /// <summary>
        /// request of the ip
        /// </summary>
        public string RequestIP { get; set; }
        /// <summary>
        /// request url
        /// </summary>
        public string RequestUrl { get; set; }
        /// <summary>
        /// request data
        /// </summary>
        public string RequestData { get; set; }
        /// <summary>
        /// requested server name
        /// </summary>
        public string ServerName { get; set; }
    }
}
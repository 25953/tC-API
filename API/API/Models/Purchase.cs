using Mono.TextTemplating;

namespace API.Models
{
    public class Purchase
    {
        /// <summary>
        /// data related with photos that user bys 
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// PK
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public State State { get; set; } 


    }
    /// <summary>
    /// avaiable states related with a buy
    /// </summary>
    public enum State
    {
        Pending,
        Paid,
        Sent,
        Delivered,
        Closed
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class Purchase
    {
        /// <summary>
        /// data related with photos that user bys 
        /// </summary>
        /// 
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// PK
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public State State { get; set; }


        /* **************************************************************
         *  Relationships
         * ************************************************************** */

        [ForeignKey(nameof(Buyer))]

        public int BuyerFK { get; set; }

        public MyUser Buyer { get; set; }


        /* **************************************************************
         *  Relationships
         * ************************************************************** */

        public ICollection<Photography> ListOfPhotos { get; set; }

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

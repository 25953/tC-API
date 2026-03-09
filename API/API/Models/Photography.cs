using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{

    /// <summary>
    /// Photos data
    /// </summary>
    public class Photography
    {
        /// <summary>
        /// primary key
        /// </summary>
        /// 

        [Key]
        public int Id { get; set; } 
        /// <summary>
        /// name of the photo
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// some descirption of the photo
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// name of the file related with the photo we use
        /// </summary>
        public string File { get; set; }
        /// <summary>
        /// the date when the photo was taken
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// the price that user must pay to buy the photo
        /// </summary>
        public decimal Price { get; set; }


        /* **************************************************************
         *  Relationships
         * ************************************************************** */


        [ForeignKey(nameof(Category))]
        public int CategoryFK { get; set; }
        public Category Category { get; set; }

        public ICollection<Purchase> ListOfPurchase  { get; set; }

    }
}

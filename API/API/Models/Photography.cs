using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Serialization;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Xunit;
using Xunit.Sdk;

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


        [StringLength(50)]
        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }= string.Empty;
        /// <summary>
        /// some descirption of the photo
        /// </summary>

        [StringLength(200)]
        public string?Description { get; set; }
        /// <summary>
        /// name of the file related with the photo we use
        /// </summary>

        [StringLength(100)]
        public string File { get; set; }
        /// <summary>
        /// the date when the photo was taken
        /// </summary>


        [DataType(DataType.Date)]

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
        /// <summary>
        /// the price that user must pay to buy the photo
        /// </summary>
        public decimal Price { get; set; }


        /* **************************************************************
         *  Relationships
         * ************************************************************** */


        [ForeignKey(nameof(Category))]
        [Display(Name = "Category")]
        public int CategoryFK { get; set; }
        public Category Category { get; set; } = null;

        public ICollection<Purchase> ListOfPurchase  { get; set; }

    }
}

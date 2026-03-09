using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace API.Models
{

    /// <summary>
    /// the category
    /// </summary>
    public class Category
    {
        public int Id { get; set; }


        [StringLength(50)]
        [Required(ErrorMessage = "Name is required.")]
        [Display(Name="Nome de categoria")]
        public string Name { get; set; } = "";




        /* **************************************************************
         *  Relationships
         * ************************************************************** */



        public ICollection<Photography> ListOfPhotos { get; set; } = [];



    }
}

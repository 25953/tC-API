using System.Collections.Generic;

namespace API.Models
{

    /// <summary>
    /// the category
    /// </summary>
    public class Category
    {
        public int Id { get; set; }


        public  string Name { get; set; }




        /* **************************************************************
         *  Relationships
         * ************************************************************** */



        public ICollection<Photography> ListOfPhotos { get; set; }



    }
}

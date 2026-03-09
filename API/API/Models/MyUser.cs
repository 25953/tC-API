namespace API.Models
{

    /// <summary>
    /// web shop users data
    /// </summary>
    public class MyUser
    {

        /// <summary>
        /// PK
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// name of user
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// address of users
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// postal code of users the address
        /// </summary>
        public string PostalCode { get; set; }
        /// <summary>
        /// tax number
        /// </summary>
        public string TaxNumber { get; set; }
        /// <summary>
        /// country of users
        /// </summary>
        public string Country { get; set; }
        /// <summary>
        /// the cell phone number that an user has
        /// </summary>
        public string PhoneNumber { get; set; }



        /* **************************************************************
         *  Relationships
         * ************************************************************** */



        public ICollection<Purchase> ListOfPurchases { get; set; }





    }
}

using System.ComponentModel.DataAnnotations;

namespace NorthwindApp
{
    /// <summary>
    /// Represents a customer.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Gets or sets the customer ID.
        /// </summary>
        [Key]
        public string CustomerID { get; set; }

        /// <summary>
        /// Gets or sets the company name.
        /// </summary>
        [Required]
        public string CompanyName { get; set; }

        /// <summary>
        /// Gets or sets the contact name.
        /// </summary>
        public string ContactName { get; set; }

        /// <summary>
        /// Gets or sets the contact title.
        /// </summary>
        public string ContactTitle { get; set; }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the region.
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// Gets or sets the postal code.
        /// </summary>
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets the phone.
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Gets or sets the fax.
        /// </summary>
        public string Fax { get; set; }
    }
}
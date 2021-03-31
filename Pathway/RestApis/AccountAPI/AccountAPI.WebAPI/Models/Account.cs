using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace AccountAPI.WebAPI.Models
{
    [XmlRoot("account")]
    public class Account
    {
        [Required]
        [XmlElement("account_code")]
        public string AccountCode { get; set; }

        [XmlElement("username ")]
        public string UserName { get; set; }

        [Required]
        [XmlElement("email")]
        public string Email { get; set; }

        [Required]
        [XmlElement("first_name")]
        public string FirstName { get; set; }

        [Required]
        [XmlElement("last_name")]
        public string LastName { get; set; }

        [XmlElement("company_name")]
        public string CompanyName { get; set; }
    }
}

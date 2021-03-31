using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace AccountAPI.WebAPI.Models
{
    [XmlRoot("new_account_notification")]
    public class AccountNotiRequest
    {
        [Required]
        [XmlElement("account")]
        public Account Account { get; set; }

    }
}

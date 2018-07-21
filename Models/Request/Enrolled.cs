
using System.ComponentModel.DataAnnotations;

namespace Dummy3D.Models.Request {
    public class Enrolled {
        [Required]
        public uint Amount { get; set;}
        [Required]
        [RegularExpression("[A-Z]{2}")]
        public string Currency { get; set;}
        public string OrderId {get; set;}
        public CreditCard Card { get; set;}
        public Merchant Merchant { get; set;}
        [Url]
        public string ReturnUrl { get; set;}
    }
}

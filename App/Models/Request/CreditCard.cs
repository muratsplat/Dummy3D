using System.Net;
using System.ComponentModel.DataAnnotations;

namespace App.Models.Request {
    public class CreditCard {
        [Required]
        [CreditCard]
        public CreditCard Number { get; set;}
        [Required]
        public uint ExpireMonth { get; set;}
        [Required]
        public uint ExpireYear { get; set;}
        [Required]
        public uint CVV { get; set;}
        
    }
}
using System.Net;
using System.ComponentModel.DataAnnotations;

namespace Dummy3D.Models.Request {
    public class CreditCard {
        [Required]
        [CreditCard]

        public uint Number { get; set;}
        [Required]
        public uint ExpireMonth { get; set;}
        [Required]
        public uint ExpireYear { get; set;}
        [Required]
        public uint CVV { get; set;}
        [Required]
        
        public IPAddress CustomerIp { get; set;}
    }
}
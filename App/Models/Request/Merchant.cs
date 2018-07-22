using System.Globalization;
using System.ComponentModel.DataAnnotations;

namespace App.Models.Request {
    public class Merchant {
        [Required]
        public string ID { get; set;}
        [Required]
        public string Name { get; set;}
        
        [Required]
        [RegularExpression("[A-Z]{2}")]
        public string Country { get; set;}

        [Required]
        [RegularExpression("[0-9]{6}")]
        public uint BinNumber { get; set;}
    }
}
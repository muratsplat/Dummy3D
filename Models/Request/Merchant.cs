using System.Globalization;
using System.ComponentModel.DataAnnotations;


namespace Dummy3D.Models.Request {
    public class Merchant {
        [Required]
        public string ID { get; set;}
        [Required]
        public string Name { get; set;}
        [Required]
        public RegionInfo Country { get; set;}
        
        public uint CVV { get; set;}
        [Required]
        [RegularExpression("[0-9]{6,11}")]
        public uint BinNumber { get; set;}
    }
}
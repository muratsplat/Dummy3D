using System.Globalization;
using System.ComponentModel.DataAnnotations;

namespace Dummy3D.Models.Request {
    public class Merchant {
        [Required]
        public string ID { get; set;}
        [Required]
        public string Name { get; set;}
        
        [Required]
        [RegularExpression("[A-Z]{2}")]
        public RegionInfo Country { get; set;}

        [Required]
        [RegularExpression("[0-9]{6}")]
        public uint BinNumber { get; set;}
    }
}
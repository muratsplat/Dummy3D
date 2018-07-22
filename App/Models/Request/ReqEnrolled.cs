using System.Net;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace App.Models.Request {
    public class ReqEnrolled {
        [Required]
        [JsonProperty]
        public uint Amount { get; set;}
        [Required]
        [JsonProperty]
        [RegularExpression("[A-Z]{2}")]
        public string Currency { get; set;}
        [JsonProperty]
        public string OrderId {get; set;}
        [JsonProperty]
        public CreditCard Card { get; set;}
        [JsonProperty]
        public Merchant Merchant { get; set;}
        [Url]
        [JsonProperty]
        public string ReturnUrl { get; set;}
        [Required]
        [JsonProperty]
        public string Ip { get; set;}

        
    }
}

using System.Net;
namespace Dummy3D.Models.Request {
    public class CreditCard {
        public uint Number { get; set;}
        public uint ExpireMonth { get; set;}
        public uint ExpireYear { get; set;}
        public uint CVV { get; set;}
        public IPAddress CustomerIp { get; set;}
    }
}
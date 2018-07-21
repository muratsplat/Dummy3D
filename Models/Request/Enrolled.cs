

namespace Dummy3D.Models.Request {
    public class Enrolled {
        public uint Amount { get; set;}
        public string Currency { get; set;}
        public string OrderId {get; set;}
        public CreditCard Card { get; set;}
        public Merchant Merchant { get; set;}
        public string ReturnUrl { get; set;}
    }
}

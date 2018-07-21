using System.Globalization;

namespace Dummy3D.Models.Request {
    public class Merchant {
        public string ID { get; set;}
        public string Name { get; set;}
        public RegionInfo Country { get; set;}
        public uint CVV { get; set;}
        public uint BinNumber { get; set;}
    }
}
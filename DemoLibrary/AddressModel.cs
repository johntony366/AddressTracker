using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class AddressModel
    {
        public string HouseNumber { get; set; }
        public string ZipCode { get; set; }
        public string District { get; set; }
        public string State { get; set; }

        public string AddressValue => $"{HouseNumber} {ZipCode} {District} {State}";
    }
}

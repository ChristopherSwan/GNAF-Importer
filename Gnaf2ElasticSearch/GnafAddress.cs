using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gnaf2ElasticSearch
{
    public class GnafAddress
    {

        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }
        public string Suburb { get; set; }
        public string State { get; set; }
        public string PostCode { get; set; }
        public string AddressDetailPid { get; set; }

        public float Latitude { get; set; }
        public float Longitude { get; set; }
    }
}

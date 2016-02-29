using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gnaf2ElasticSearch
{
    public class PopulateWorkerProgressEventArgs
    {
        public Int32 count;
        public Int32 total;
        public string progress;
    }
}

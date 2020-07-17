using System;
using System.Collections.Generic;
using System.Text;

namespace EsempioPJ20.Models
{
    class TracersResponse
    {
        public IEnumerable<Tracer> data { get; set; }
    }

    class Tracer
    {
        public string id { get; set; }
        public string status { get; set; }
        public string type { get; set; }
    }
}

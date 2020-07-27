using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCalculator.Entities
{
    public class Log
    {
        public Guid Id { get; set; }
        public string IPAddress { get; set; }
        public DateTime DateTime { get; set; }
    }
}

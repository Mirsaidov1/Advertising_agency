using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Partner
    {
        public int Partner_id { get; set; }
        public string Name { get; set; }
        public string Term_of_cooperation { get; set; }
        public string Analytics { get; set; }

        //public void GenerateReport()
        //{
        //    Console.WriteLine($"Report for partner {Name} has been generated.");
        //}
    }
}

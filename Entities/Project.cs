using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Project
    {
        public int Project_id { get; set; }
        public int Client_id { get; set; }
        public string Name { get; set; }
        public string Objective { get; set; }
        public decimal Budget { get; set; }
        public DateTime Start_date { get; set; }
        public DateTime End_date { get; set; }

        //public void CalculateDuration()
        //{
        //    TimeSpan duration = End_date - Start_date;
        //    Console.WriteLine($"Project '{Name}' duration is {duration.Days} days.");
        //}
    }
}

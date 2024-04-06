using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Brand
    {
        public int Brand_id { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
        public string History { get; set; }
        public string Goals { get; set; }
        public string Marketing_strategy { get; set; }


        //public void DisplayBrandInfo()
        //{
        //    Console.WriteLine($"Brand: {Name}\nLogo: {Logo}\nHistory: {History}\nGoals: {Goals}\nMarketing Strategy: {Marketing_strategy}");
        //}
    }
}

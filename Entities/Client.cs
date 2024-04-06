using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Client
    {
        public int Client_id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Industry { get; set; }
        public decimal Budget { get; set; }

        //public void UpdateBudget(decimal newBudget)
        //{
        //    Budget = newBudget;
        //    Console.WriteLine($"{Name}'s budget has been updated to {newBudget}.");
        //}
    }
}

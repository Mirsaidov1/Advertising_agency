using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Invoice
    {
        public int Invoice_id { get; set; }
        public int Client_id { get; set; }
        public decimal Amount { get; set; }
        public string Status { get; set; }
        public DateTime Issued_date { get; set; }
        public DateTime Payment_due_date { get; set; }

        //public void IsOverdue()
        //{
        //    if (DateTime.Now > Payment_due_date)
        //    {
        //        Console.WriteLine($"Invoice {Invoice_id} is overdue.");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"Invoice {Invoice_id} is not overdue.");
        //    }
        //}
    }
}

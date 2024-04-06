using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Program
    {
        static void Main()
        {
            Client client = new Client
            {
                Client_id = 1,
                Name = "Example Company",
                Phone = "123-456-7890",
                Email = "example@example.com",
                Industry = "Marketing",
                Budget = 10000
            };

            //client.UpdateBudget(15000);

            Project project = new Project
            {
                Project_id = 1,
                Client_id = client.Client_id,
                Name = "Marketing Campaign",
                Objective = "Increase brand awareness",
                Budget = 5000,
                Start_date = new DateTime(2024, 4, 1),
                End_date = new DateTime(2024, 4, 30)
            };

            //project.CalculateDuration();

            Campaign campaign = new Campaign
            {
                Campaign_id = 1,
                Project_id = project.Project_id,
                Name = "Social Media Campaign",
                Target_audience = "Young adults",
                Media_channels = "Facebook, Instagram",
                Budget = 2000
            };

            //campaign.ChangeMediaChannels("Facebook, Instagram, Twitter");

            Brand brand = new Brand
            {
                Brand_id = 1,
                Name = "Example Brand",
                Logo = "logo.png",
                History = "Founded in 2010...",
                Goals = "Increase market share...",
                Marketing_strategy = "Focus on social media..."
            };

            //brand.DisplayBrandInfo();

            Partner partner = new Partner
            {
                Partner_id = 1,
                Name = "Marketing Agency",
                Term_of_cooperation = "2-year contract",
                Analytics = "Data analysis..."
            };

            //partner.GenerateReport();

            Invoice invoice = new Invoice
            {
                Invoice_id = 1,
                Client_id = client.Client_id,
                Amount = 500,
                Status = "Unpaid",
                Issued_date = new DateTime(2024, 4, 1),
                Payment_due_date = new DateTime(2024, 4, 10)
            };

            //invoice.IsOverdue();
        }
    }
}

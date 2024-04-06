using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Campaign
    {
        public int Campaign_id { get; set; }
        public int Project_id { get; set; }
        public string Name { get; set; }
        public string Target_audience { get; set; }
        public string Media_channels { get; set; }
        public decimal Budget { get; set; }

        //public void ChangeMediaChannels(string newChannels)
        //{
        //    Media_channels = newChannels;
        //    Console.WriteLine($"Campaign '{Name}' now uses {newChannels} media channels.");
        //}

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public class Team : Coach
    {
        List<FootballPlayer> Players { get; set; }

        public Team()
        {
            Players = new List<FootballPlayer>();
        }

        public void AverageAge()
        {
            double sum = 0;
            double average = 0;
            foreach (var ages in Players)
            {
                sum += ages.Age;
                average = sum / Players.Count;
            }
            Console.WriteLine(average);
        }
    }
}

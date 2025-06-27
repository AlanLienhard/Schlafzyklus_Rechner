using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schlafzyklus_Rechner
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime TimeWakeup;
            DateTime bedTime = DateTime.MinValue;
            // Das ist die durchschnittliche Dauer eines Schlafzyklus
            TimeSpan sleepCycle = TimeSpan.FromMinutes(90);

            Console.WriteLine("Willkommen zum Schlafzyklus Rechner.");
            Console.WriteLine("Gib ein, wann du aufwachen möchtest [hh:mm]:");
            TimeWakeup = DateTime.Parse(Console.ReadLine());
            for (int i = 1; i <= 6; i++) 
            {
                bedTime = TimeWakeup - TimeSpan.FromMinutes(90 * i);
                Console.WriteLine($"Für {i} Zyklen: {bedTime:HH:mm}");

            }

            Console.WriteLine("Du solltest um diese Zeit schlafen gehen: " + bedTime.ToString("HH:mm"));


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoslipSlippBP
{
    internal class Restart
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the speed limit:  ");
            var speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the car speed:  ");
            var carSpeed = Convert.ToInt32(Console.ReadLine());
            const int demeritPoint = 5;
            var pointTotal = (carSpeed - speedLimit) / demeritPoint;
            if (speedLimit >= carSpeed)
                Console.WriteLine("Ok");
            else if (speedLimit < carSpeed && pointTotal < 12)
            {
                Console.WriteLine("Speed is" + " " + (carSpeed - speedLimit) + "kmh " + "Over");
                Console.WriteLine("");
                Console.WriteLine(pointTotal + " " + "Deremit Points");
            }
            else if (speedLimit < carSpeed && pointTotal >= 12)
            {
                Console.WriteLine("Speed is" + " " + (carSpeed - speedLimit) + "kmh " + "Over");
                Console.WriteLine("");
                Console.WriteLine(pointTotal + " " + "Deremit Points");
                Console.WriteLine("");
                Console.WriteLine("SUSPENDED");
            }
            Console.Write("Press enter to clear:");
            Console.ReadLine();
        }
    }
}

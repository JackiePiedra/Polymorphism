using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Boat ssJackie = new Boat(4, 100, "red", 90.0d, .90d);
            ssJackie.Move();
            ssJackie.Move();
            Console.WriteLine("Boat "+ssJackie.GetDistanceTraveled());

            Automobile mercedesBenz = new Automobile(4, 18, 4, 5, 300, "white", 80.0d);
        }
    }
}

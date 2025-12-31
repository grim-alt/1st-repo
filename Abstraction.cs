using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    using System;
    abstract class Vehicle
    {
        public abstract void Start();
        public void Stop()
        {
            Console.WriteLine("Vehicle stopped");
        }
    }
    class Car : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Car started");
        }
    }

    class Program
    {
        static void Main()
        {
            Vehicle v = new Car(); 
            v.Start();
            v.Stop();
        }
    }
}

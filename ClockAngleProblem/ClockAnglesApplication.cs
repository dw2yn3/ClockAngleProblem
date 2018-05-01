using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockAngleProblem
{
    class ClockAnglesApplication
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ClockAngles.Calculate(2300));
            Console.WriteLine(ClockAngles.Calculate(2359));
            Console.WriteLine(ClockAngles.Calculate(1200));
            Console.WriteLine(ClockAngles.Calculate(2400));
            Console.WriteLine(ClockAngles.Calculate(0345));
            Console.WriteLine(ClockAngles.Calculate(0630));
            Console.WriteLine(ClockAngles.Calculate(0600));
            Console.WriteLine(ClockAngles.Calculate(0000));
            Console.WriteLine(ClockAngles.Calculate(1500));
            Console.WriteLine(ClockAngles.Calculate(1800));
            Console.WriteLine(ClockAngles.Calculate(1515));
            Console.ReadLine();
        }
    }
}

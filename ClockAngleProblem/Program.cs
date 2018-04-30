/**CLOCK ANGLE PROBLEM
* 
* Given a four digit integer ranging from 0000 to 2359, 
* 
* Write a method that will calculate
* the smallest angle made by the hour hand and the minute hand of an analog clock.
* Assume hour hand hand rests at the given number, suppose at 0330, the hour hand 
* will stop at 3, not in between 3 & 4, the minute hand stops at 30. 
* 
* Asssume there are no seconds.
* 
* For example, at 0345, the angle will be 180 degrees
* 
* Things to do!!!!
* Display a error message to if user enters number greater than 2359 or a negative number.
* Find precise angles between hands, assuming every hands move by the second
* Add a second hand and find the angles.
* */

using System;

namespace ClockAngleProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculate(2300));
            Console.WriteLine(Calculate(0300));
            Console.WriteLine(Calculate(2015));
            Console.WriteLine(Calculate(5000));
            Console.WriteLine(Calculate(0000));
            Console.WriteLine(Calculate(2359));
            Console.WriteLine(Calculate(1201));
            Console.ReadLine();
        }

        public static int Calculate(int time)
        {
            /*
             * angle holds angle calculated from time;
             * hour holds hour part of the time;
             * minute holds minute part of the time;
             * angleFromHourHand holds angle made by hour hand with 0000 baseline.
             * angleFromMinuteHand holds angle made by minute hand with 0000 baseline.
            */            
            int angle, hour, minute, angleFromHourHand, angleFromMinuteHand;

            //check for corners, where time is midnight or noon.
            if (time == 0000 || time == 1200)
            {
                return 0;
            }
            else if (time > 1200)
            {
                time = time - 1200;
            }

            hour = time / 100;
            minute = time - (hour * 100);

            angleFromHourHand = hour * 30;
            angleFromMinuteHand = minute * 6;

            /**Calculate angle by subtracting the angle made by hour hand from the minute hand
             * ensure to take the absolute value, so the angle is always delivered as a pisitive value */

            angle = Math.Abs(angleFromMinuteHand - angleFromHourHand);

            //if angle is greater than 180, then subtract from 360 degrees to get the smallest angle
            if (angle > 180)
            {
                angle = 360 - angle;
            }

            return angle;
        }
    }
}

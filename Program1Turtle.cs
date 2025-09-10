using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit4.TurtleLib;

namespace Turtle22
{
    internal partial class Program
    {
        public static Random rnd = new Random();
        /// <summary>
        /// Turtle program
        /// </summary>
        static void Main1()
        {
            double x1, y1;
            Turtle t = new Turtle();
            x1 = t.GetXLocation();
            Console.WriteLine(x1);
            //t1.MoveBackward(200);
            t.SetDelay(20);
            t.TailDown();
            Double step = 100 * 2 * Math.PI / 36;
            t.TurnRight(5);
            for (int i = 0; i < 36; i++)
            {
                t.MoveForward(step);
                t.TurnRight(10);
           
           

            }
            t.TurnLeft(5);

            x1 = Math.Round(t.GetXLocation(),2);
            Console.WriteLine(x1);

            t.TurnRight(180);
            t.MoveForward(100);// -step/2);
            t.TurnRight(180);
            //t.MoveForward(100);
            for (int i = 0; i < 4; i++)
            {
                t.MoveForward(200);
                t.TurnRight(90);
                double x = rnd.NextDouble() * 200;
                double y = rnd.NextDouble() * 200;
                t.TailUp();
                t.MoveForward(y);
                t.TurnRight(90);
                t.MoveForward(x);
                t.TailDown();
                t.MoveForward(10);


                x1 = Math.Round(t.GetXLocation(), 2);
                y1 = Math.Round(t.GetYLocation(), 2);
                Console.WriteLine($"x1:{x1}, y1: {y1}");



            }



            


        }
    }
}

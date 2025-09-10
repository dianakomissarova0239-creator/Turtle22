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
        /// <summary>
        /// Turtle program
        /// </summary>
        static void Main1()
        {
            Turtle t = new Turtle();

            //t1.MoveBackward(200);
            t.SetDelay(20);
            t.TailDown();
            Double step = 100 * 2 * Math.PI / 36;
            for (int i = 0; i < 36; i++)
            {
                t.MoveForward(step);
                t.TurnRight(10);
           
           

            }
            t.TurnRight(180);
            t.MoveForward(100-step/2);
            t.TurnRight(180);
            //t.MoveForward(100);
            for (int i = 0; i < 4; i++)
            {
                t.MoveForward(200);
                t.TurnRight(90);
            }

        }
    }
}

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;


class Player
{
    static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split(' ');
        int lightX = int.Parse(inputs[0]); // the X position of the light of power
        int lightY = int.Parse(inputs[1]); // the Y position of the light of power
        int initialTX = int.Parse(inputs[2]); // Thor's starting X position
        int initialTY = int.Parse(inputs[3]); // Thor's starting Y position
        string newX = ""; //this will print E and W
        string newY = ""; //this will print N and S

        // game loop
        while (true)
        {
            int remainingTurns = int.Parse(Console.ReadLine()); // The remaining amount of turns Thor can move. Do not remove this line.


            if (lightX > initialTX)
            {
                ++initialTX;

                newX = "E";
            }


            else if (lightX < initialTX)
            {
                --initialTX;

                newX = "W";
            }

            else
            {

                newX = "";
            }

            if (lightY > initialTY)
            {
                ++initialTY;

                newY = "S";
            }

            else if (lightY < initialTY)
            {
                --initialTY;

                newY = "N";
            }

            else
            {
                newY = "";
            }

            // A single line providing the move to be made: N NE E SE S SW W or NW
            Console.WriteLine(newY + newX);
        }
    }
}
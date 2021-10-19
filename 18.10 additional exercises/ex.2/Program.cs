using System;
using System.Collections.Generic;
using System.Linq;

namespace ex._2
{
    internal class Program
    {
        public static int currentPosition;
        static void Main(string[] args)
        {
            // Getting inital states of Icarus
            int[] initialState = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            // Starting position of icarus
            int startingPosition = int.Parse(Console.ReadLine());

            // Commands
            Queue<string> movesDirection = new Queue<string>();
            Queue<int> movesTimes = new Queue<int>();

            // Getting commands
            while (true)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0].ToLower() == "supernova") break;

                movesDirection.Enqueue(command[0]);
                movesTimes.Enqueue(int.Parse(command[1]));
            }

            currentPosition = startingPosition;
            // Executing the commands
            while (true)
            {
                if (movesDirection.Count == 0 && movesDirection.Count == 0) break;

                string direction = movesDirection.Dequeue();
                int times = movesTimes.Dequeue();

                // Going into a recursion
                if (direction == "left")
                {
                    moveLeft(currentPosition, initialState, times);
                }
                else
                    moveRight(currentPosition, initialState, times);


            }

            foreach (var i in initialState)
                Console.Write($"{i} ");
        }

        public static void moveLeft(int position,int[] states, int times)
        {
            if (position < 0)
            {
                position = states.Length - 1;
                states[position] -= 1;
            }
            states[position] -= 1;
            currentPosition = position;

            if (times < 0)
                return;

            moveLeft(position - 1,states, times - 1);
        }

        public static void moveRight(int position, int[] states, int times)
        {
            if (position >= states.Length)
            {
                position = 0;
                states[position] -= 1;
            }
            states[position] -= 1;
            currentPosition = position;

            if (times < 0)
                return;

            moveRight(position + 1, states, times - 1);
        }
    }
}

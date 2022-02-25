using MarsRoverCase.Core;
using System;
using System.Linq;

namespace MarsRoverCase
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // get the point entries from console line
            var maxPointEntries = Console.ReadLine().Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            // convert to an integer list
            var maxPoints = maxPointEntries.Select(int.Parse).ToList();

            // get the start position entries from console line
            var startPositions = Console.ReadLine().Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

            // create a position object
            var position = new Position();

            if (startPositions.Count == 3)
            {
                position.X = Convert.ToInt32(startPositions[0]);
                position.Y = Convert.ToInt32(startPositions[1]);
                position.Direction = Enum.Parse<Directions>(startPositions[2]);
            }

            try
            {
                // get the move entries from console line
                var moves = Console.ReadLine().ToUpper();

                //start to move by the points and move entries
                position.StartToMove(maxPoints, moves);
                Console.WriteLine($"{position.X} {position.Y} {position.Direction.ToString()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
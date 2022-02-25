using MarsRoverCase.Core;
using System.Collections.Generic;
using Xunit;

namespace MarsRoverCase.Tests
{
    public class MarsRoverCaseTests
    {
        [Fact]
        public void MoveTo_12N_LMLMLMLMM_Results_13N()
        {
            // create a position object
            var position = new Position
            {
                X = 1,
                Y = 2,
                Direction = Directions.N
            };

            var moves = "LMLMLMLMM";
            var maxPoints = new List<int>() { 5, 5 };

            //start to move
            position.StartToMove(maxPoints, moves);

            var expectedOutput = "1 3 N";
            var actualOutput = $"{position.X} {position.Y} {position.Direction.ToString()}";

            Assert.Equal(expectedOutput, actualOutput);
        }

        [Fact]
        public void MoveTo__33E_MRRMMRMRRM_Results_51E()
        {
            // create a position object
            var position = new Position
            {
                X = 3,
                Y = 3,
                Direction = Directions.E
            };

            var moves = "MMRMMRMRRM";
            var maxPoints = new List<int>() { 5, 5 };

            //start to move
            position.StartToMove(maxPoints, moves);

            var expectedOutput = "5 1 E";
            var actualOutput = $"{position.X} {position.Y} {position.Direction.ToString()}";

            Assert.Equal(expectedOutput, actualOutput);
        }
    }
}

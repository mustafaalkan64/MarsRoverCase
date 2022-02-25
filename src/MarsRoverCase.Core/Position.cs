using System;
using System.Collections.Generic;

namespace MarsRoverCase.Core
{
    public class Position : IPosition
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Directions Direction { get; set; }

        public Position()
        {
            X = 0;
            Y = 0;

            //Must be has default.
            Direction = Directions.N;
        }

        public void StartToMove(IList<int> maxPoints, string moves)
        {
            foreach (var move in moves)
            {
                switch (move)
                {
                    case 'M':
                        {
                            MoveToSameDirection();
                            break;
                        }
                    case 'L':
                        {
                            Rotate90Left();
                            break;
                        }
                    case 'R':
                        {
                            Rotate90Right();
                            break;
                        }
                    default:
                        {
                            throw new ArgumentException("Invalid character", nameof(move));
                        }
                }

                //validate positions
                if (X < 0 || X > maxPoints[0] || Y < 0 || Y > maxPoints[1])
                {
                    throw new Exception($"Position cannot be less than (0, 0) and greater than ({maxPoints[0]}, {maxPoints[1]})");
                }
            }
        }

        private void Rotate90Left()
        {
            switch (Direction)
            {
                case Directions.N:
                    {
                        Direction = Directions.W;
                        break;
                    }
                case Directions.S:
                    {
                        Direction = Directions.E;
                        break;
                    }
                case Directions.E:
                    {
                        Direction = Directions.N;
                        break;
                    }
                case Directions.W:
                    {
                        Direction = Directions.S;
                        break;
                    }
                default:
                    {
                        throw new ArgumentException("Invalid enum value", nameof(Direction));
                    }
            }
        }

        private void Rotate90Right()
        {
            switch (Direction)
            {
                case Directions.N:
                    {
                        Direction = Directions.E;
                        break;
                    }
                case Directions.S:
                    {
                        Direction = Directions.W;
                        break;
                    }
                case Directions.E:
                    {
                        Direction = Directions.S;
                        break;
                    }
                case Directions.W:
                    {
                        Direction = Directions.N;
                        break;
                    }
                default:
                    {
                        throw new ArgumentException("Invalid enum value", nameof(Direction));
                    }
            }
        }

        private void MoveToSameDirection()
        {
            switch (Direction)
            {
                case Directions.N:
                    {
                        Y += 1;
                        break;
                    }
                case Directions.S:
                    {
                        Y -= 1;
                        break;
                    }
                case Directions.E:
                    {
                        X += 1;
                        break;
                    }
                case Directions.W:
                    {
                        X -= 1;
                        break;
                    }
                default:
                    {
                        throw new ArgumentException("Invalid enum value", nameof(Direction));
                    }
            }
        }
    }
}
using System.Collections.Generic;

namespace MarsRoverCase.Core
{
    public interface IPosition
    {
        void StartToMove(IList<int> maxPoints, string moves);
    }
}
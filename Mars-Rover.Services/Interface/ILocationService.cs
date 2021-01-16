using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_Rover.Services.Interface
{
    public interface ILocationService
    {
        void MoveForward(ref int xCoordinate, ref int yCoordinate, ref string direction);
        string MoveLeftOrRight(string direction, string move);
    }
}

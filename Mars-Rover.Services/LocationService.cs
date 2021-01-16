using Mars_Rover.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_Rover.Services
{
    public class LocationService : ILocationService
    {
        public void MoveForward(ref int xCoordinate,ref int yCoordinate,ref string direction)
        {
            switch (direction)
            {
                case "N":
                    yCoordinate = yCoordinate + 1;
                    break;
                case "E":
                    xCoordinate = xCoordinate + 1;
                    break;
                case "S":
                    yCoordinate = yCoordinate - 1;
                    break;
                case "W":
                    xCoordinate = xCoordinate - 1;
                    break;
                default:
                    break;
            }
        }

        public string MoveLeftOrRight(string direction,string move)
        {
            switch (move)
            {
                case "L":
                    switch (direction)
                    {
                        case "N":
                            return "W";
                        case "E":
                            return "N";
                        case "S":
                            return "E";
                        case "W":
                            return "S";
                        default:
                            return null;
                    }
                case "R":
                    switch (direction)
                    {
                        case "N":
                            return "E";
                        case "E":
                            return "S";
                        case "S":
                            return "W";
                        case "W":
                            return "N";
                        default:
                            return null;
                    }
                default:
                    return null;

            }
        }       
    }
}

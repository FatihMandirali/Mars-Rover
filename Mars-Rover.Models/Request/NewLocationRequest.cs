using Mars_Rover.Models.Enum;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Mars_Rover.Models.Request
{
    public class NewLocationRequest
    {
        public int xCoordinate { get; set; }
        public int yCoordinate { get; set; }
        public DirectionEnum direction { get; set; }
        public List<MoveEnum> moves { get; set; }
    }
}

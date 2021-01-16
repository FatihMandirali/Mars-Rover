using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_Rover.Models.Response
{
    public class NewLocationResponse
    {
        public int xCoordinate { get; set; }
        public int yCoordinate { get; set; }
        public string direction { get; set; }
    }
}

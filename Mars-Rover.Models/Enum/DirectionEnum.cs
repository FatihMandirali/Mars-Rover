using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Mars_Rover.Models.Enum
{
    //[JsonConverter(typeof(StringEnumConverter))]
    public enum  DirectionEnum
    {
       N,
       E,
       S,
       W
    }
}

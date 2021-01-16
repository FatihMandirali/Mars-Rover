using Mars_Rover.Models;
using Mars_Rover.Models.Enum;
using Mars_Rover.Models.Request;
using Mars_Rover.Models.Response;
using Mars_Rover.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mars_Rover.Controllers
{
    [Route("api/[controller]")]
    public class LocationController : ControllerBase
    {
        private readonly ILocationService _locationService;

        public LocationController(ILocationService locationService)
        {
            _locationService = locationService;
        }

        /// <summary>
        /// Service showing its position according to the entered coordinate and direction of progress
        /// </summary>
        /// <param name="newLocationRequest">parameters required to set new location</param>
        /// <returns></returns>
        [HttpPost("PostNewLocation")]
        public ResponseModel<object> PostNewLocation([FromBody] NewLocationRequest newLocationRequest)
        {

            if(!ModelState.IsValid)
                return ResponseModel<object>.Create(null, ProcessStatusCodes.BadRequest, new FriendlyMessageModel() { Title = "Bad Request", Description = "Please check your request" });


            int xCoordinate = newLocationRequest.xCoordinate;
            int yCoordinate = newLocationRequest.yCoordinate;
            string direction = newLocationRequest.direction.ToString();

            newLocationRequest.moves.ForEach(x =>
            {
                if (x == MoveEnum.M)
                    _locationService.MoveForward(ref xCoordinate, ref yCoordinate, ref direction);
                else if (x == MoveEnum.R)
                    direction = _locationService.MoveLeftOrRight(direction, MoveEnum.R.ToString());
                else if (x == MoveEnum.L)
                    direction = _locationService.MoveLeftOrRight(direction, MoveEnum.L.ToString());
                
            });

            var newLocationResponse = new NewLocationResponse();
            newLocationResponse.direction = direction;
            newLocationResponse.xCoordinate = xCoordinate;
            newLocationResponse.yCoordinate = yCoordinate;



            return ResponseModel<object>.Create(newLocationResponse, ProcessStatusCodes.Success, new FriendlyMessageModel() { Title = "Success", Description = "New location calculated" });
        }
    }
}

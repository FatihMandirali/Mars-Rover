using Mars_Rover.Controllers;
using Mars_Rover.Models.Enum;
using Mars_Rover.Models.Request;
using Mars_Rover.Models.Response;
using Mars_Rover.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Mars_Rover.Tests
{
    public class LocationControllerTest
    {

        [Fact]
        public void LocationController_PostNewLocation_ThenSuccess_Test1()
        {
            var locationService = new LocationService();
            var locationController = new LocationController(locationService);


            var moveEnums = new List<MoveEnum>();
            moveEnums.Add(MoveEnum.L);
            moveEnums.Add(MoveEnum.M);
            moveEnums.Add(MoveEnum.L);
            moveEnums.Add(MoveEnum.M);
            moveEnums.Add(MoveEnum.L);
            moveEnums.Add(MoveEnum.M);
            moveEnums.Add(MoveEnum.L);
            moveEnums.Add(MoveEnum.M);
            moveEnums.Add(MoveEnum.M);

            var newLocationRequest = new NewLocationRequest();
            newLocationRequest.direction = Models.Enum.DirectionEnum.N;
            newLocationRequest.xCoordinate = 1;
            newLocationRequest.yCoordinate = 2;
            newLocationRequest.moves = moveEnums;

            var result =  locationController.PostNewLocation(newLocationRequest);
            var newLocationResponse = (NewLocationResponse)result.Data;
            Assert.Equal(1,newLocationResponse.xCoordinate);
            Assert.Equal(3,newLocationResponse.yCoordinate);
            Assert.Equal("N",newLocationResponse.direction);
        }


        [Fact]
        public void LocationController_PostNewLocation_ThenFail_Test()
        {
            var locationService = new LocationService();
            var locationController = new LocationController(locationService);


            var moveEnums = new List<MoveEnum>();
            moveEnums.Add(MoveEnum.M);
            moveEnums.Add(MoveEnum.M);
            moveEnums.Add(MoveEnum.R);
            moveEnums.Add(MoveEnum.L);
            moveEnums.Add(MoveEnum.M);
            moveEnums.Add(MoveEnum.R);
            moveEnums.Add(MoveEnum.L);
            moveEnums.Add(MoveEnum.M);

            var newLocationRequest = new NewLocationRequest();
            newLocationRequest.direction = Models.Enum.DirectionEnum.N;
            newLocationRequest.xCoordinate = 4;
            newLocationRequest.yCoordinate = 3;
            newLocationRequest.moves = moveEnums;

            var result = locationController.PostNewLocation(newLocationRequest);
            var newLocationResponse = (NewLocationResponse)result.Data;
            Assert.Equal(5, newLocationResponse.xCoordinate);
            Assert.Equal(1, newLocationResponse.yCoordinate);
            Assert.Equal("E", newLocationResponse.direction);
        }

        [Fact]
        public void LocationController_PostNewLocation_ThenSuccess_Test2()
        {
            var locationService = new LocationService();
            var locationController = new LocationController(locationService);


            var moveEnums = new List<MoveEnum>();
            moveEnums.Add(MoveEnum.M);
            moveEnums.Add(MoveEnum.M);
            moveEnums.Add(MoveEnum.R);
            moveEnums.Add(MoveEnum.M);
            moveEnums.Add(MoveEnum.M);
            moveEnums.Add(MoveEnum.R);
            moveEnums.Add(MoveEnum.M);
            moveEnums.Add(MoveEnum.R);
            moveEnums.Add(MoveEnum.R);
            moveEnums.Add(MoveEnum.M);

            var newLocationRequest = new NewLocationRequest();
            newLocationRequest.direction = Models.Enum.DirectionEnum.E;
            newLocationRequest.xCoordinate = 3;
            newLocationRequest.yCoordinate = 3;
            newLocationRequest.moves = moveEnums;

            var result = locationController.PostNewLocation(newLocationRequest);
            var newLocationResponse = (NewLocationResponse)result.Data;
            Assert.Equal(5, newLocationResponse.xCoordinate);
            Assert.Equal(1, newLocationResponse.yCoordinate);
            Assert.Equal("E", newLocationResponse.direction);
        }
    }
}

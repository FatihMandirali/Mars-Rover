using Mars_Rover.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Mars_Rover.Tests
{
    public class LocationServiceTest
    {

        [Theory]
        [InlineData("N", "R")]
        public void MoveLeftOrRight_WithTestData_ThenSuccess_Test(string direction, string move)
        {
            var locationService = new LocationService();
            var result = locationService.MoveLeftOrRight(direction, move);

            Assert.Equal("E", result);
        }

        [Theory]
        [InlineData("E", "R")]
        [InlineData("E", "L")]
        [InlineData("S", "L")]
        public void MoveLeftOrRight_WithTestData_ThenFail_Test(string direction, string move)
        {
            var locationService = new LocationService();
            var result = locationService.MoveLeftOrRight(direction, move);

            Assert.Equal("W", result);
        }

        [Theory]
        [InlineData(2, 2, "N")]
        public void MoveForward_WithTestData_ThenSuccess_Test(int x, int y, string directionCoordinate)
        {
            int xCoordinate = x;
            int yCoordinate = y;
            string direction = directionCoordinate;

            var locationService = new LocationService();
            locationService.MoveForward(ref xCoordinate, ref yCoordinate, ref direction);

            Assert.Equal(2, xCoordinate);
            Assert.Equal(3, yCoordinate);
            Assert.Equal("N", direction);
        }

        [Theory]
        [InlineData(1, 2, "N")]
        [InlineData(2, 1, "E")]
        [InlineData(3, 2, "S")]
        [InlineData(4, 2, "W")]
        [InlineData(2, 4, "N")]
        public void MoveForward_WithTestData_ThenFail_Test(int x, int y, string direc)
        {
            int xCoordinate = x;
            int yCoordinate = y;
            string direction = direc;

            var locationService = new LocationService();
            locationService.MoveForward(ref xCoordinate, ref yCoordinate, ref direction);

            Assert.Equal(2, xCoordinate);
            Assert.Equal(3, yCoordinate);
            Assert.Equal("N", direction);
        }
    }
}

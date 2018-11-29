using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimmysCarSimulator.DrivingClass;

namespace TimmysCarSimulator
{
    class Program
    {
        private const string defineRoomText = "Welcome to the car simulator. The purpose with this application is to drive a car with " +
            "input from the user, with a room size defined by the user, as well as starting position and direction. " +
            "The only car working now is the monster truck. \n\nPlease define the size of the room by typing two numbers separated with a space, for example: 8 6";
        static void Main(string[] args)
        {
            Console.WriteLine(defineRoomText);

            var roomsize = Console.ReadLine();

            Room room = new Room();

            bool validatorRoom = room.CheckValidAxis(roomsize);

            while (validatorRoom == false)
            {
                Console.WriteLine("Something went wrong. Try again. Example input: 8 6");

                var newTry = Console.ReadLine();

                validatorRoom = room.CheckValidAxis(newTry);
            }

            Console.WriteLine("You have entered a room with the size " + room.XAxis + " " + room.YAxis + ". Please type the starting position of the car with integers, as well " +
                "as the direction it will be facing with a N (north), S (south), W (west), or E (east) all separated with spaces. For example: 2 3 N");

            var carPosition = Console.ReadLine();

            //Assumption here that if implementing new models (i.e off-road) there should be a prompt asking which model the user wants to use. However, it feels fine for now to just
            //go straight for the monster truck
            MonsterTruck mTruck = new MonsterTruck();

            bool validatorCar = mTruck.CheckValidPosition(carPosition, room);

            while (validatorCar == false)
            {
                Console.WriteLine("Something went wrong. Try again. Example input: 2 3 N");

                var newTry = Console.ReadLine();

                validatorCar = mTruck.CheckValidPosition(newTry, room);
            }

            Console.WriteLine("Your car is positioned " + mTruck.XPosition + " " + mTruck.YPosition + " facing " + mTruck.Direction + ". " +
                "Use commands in series to drive. F goes forward. L turns 90 degrees left. R turns 90 degrees right. B goes back without turning. Example input: FFFRFFLBB");

            var driveCommand = Console.ReadLine();

            Driving driving = new Driving();

            var validResult = driving.ValidDriving(driveCommand, mTruck);

            while (validResult == false)
            {
                Console.WriteLine("Try again. The only acceptable commands are F L R B");

                var newTry = Console.ReadLine();

                validResult = driving.ValidDriving(newTry, mTruck);
            }

            var drivingResult = driving.DrivingCar(mTruck, room);

            if (drivingResult)
            {
                Console.WriteLine("Simulation successful. Position: " + mTruck.XPosition + " " + mTruck.YPosition + " facing " + mTruck.Direction);
            }
            else
            {
                Console.WriteLine("Simulation failed. Car crashed at " + mTruck.XPosition + " " + mTruck.YPosition + " facing " + mTruck.Direction); 
            }

            Console.ReadKey();

        }
    }
}


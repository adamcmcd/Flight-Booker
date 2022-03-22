using System;
using System.IO;

namespace Assessment
{
    class Program
    {
        static void Main()
        {
            string menuOneUserInput;
            bool quit = false;

            DisplayFlight.Menu();

            do
            {
                //does while user's input is not valid (ValidateNumber = false)
                do
                {
                    menuOneUserInput = Console.ReadLine();
                    menuOneUserInput = menuOneUserInput.Trim();

                } while (!Validate.Number(menuOneUserInput, 6));

                switch (menuOneUserInput)
                {
                    //menuOne = 1) Book Seats
                    case "1":
                        {
                            //invokes method BookSeat
                            BookSeat();
                            break;
                        }

                    //menuOne = 2) View Account
                    case "2":
                        {
                            //invokes method LogIn within class View Account
                            Console.WriteLine("UNDER CONSTRUCTION");
                            DisplayFlight.Menu();
                            break;
                        }

                    //menuOne = 3) Display Flights
                    case "3":
                        {
                            //invokes method Timetable within class DisplayFlight
                            DisplayFlight.Timetable();
                            DisplayFlight.Menu();
                            break;
                        }

                    //menuOne = 4) Display Seats
                    case "4":
                        {
                            //invokes method Seats withon class DisplayFlight
                            DisplayFlight.Seats();
                            DisplayFlight.Menu();
                            break;
                        }

                    //menuOne = 5) Quit
                    //quit = true and loop ends closing console
                    case "5":
                        {
                            Console.WriteLine("Closing...");
                            Console.ReadLine();
                            quit = true;
                            break;
                        }
                }
            } while (!quit);
        }

        /// <summary>
        /// 
        /// </summary>
        public static void BookSeat()
        {
            //variable declaration
            string userFlightCode;
            string flyingFrom;
            string flyingTo;
            string seatClass;
            string noOfSeats;
            int travellers;

            //does while user does not enter valid Airports (ValidateAirports = false)
            do
            {
                flyingFrom = DisplayFlight.flyFrom();
                flyingTo = DisplayFlight.flyTo();

            } while (!Validate.Airports(flyingFrom, flyingTo));

            //does while user has not entered a valid flight code (ValidateFlightCode = false)
            do
            {
                userFlightCode = DisplayFlight.Code();

            } while (!Validate.FlightCode(userFlightCode));

            DisplayFlight.SeatingClass();
            //while user does not enter valid number (ValidateNumber = false)
            do
            {
                seatClass = Console.ReadLine();
                seatClass = seatClass.Trim();

            } while (!Validate.Number(seatClass, 4));

            //combine all user's flight information
            string flightInformation = userFlightCode + flyingFrom + flyingTo;

            //number of seats being booked entry
            Console.WriteLine("How many are travelling?");

            switch (seatClass)
            {
                //seatClass = 1) First class
                case "1":
                    {
                        //while input not valid (ValidateNumber = false)
                        do
                        {
                            noOfSeats = Console.ReadLine();
                            noOfSeats = noOfSeats.Trim();

                        } while (!Validate.Number(noOfSeats, 21));
                        //number of seats needed
                        travellers = Convert.ToInt32(noOfSeats);
                        GetSeat.FirstClass(travellers, flightInformation);
                        break;
                    }
                //seatClass = 2) Business class
                case "2":
                    {
                        //while input not valid (ValidateNumber = false)
                        do
                        {
                            noOfSeats = Console.ReadLine();
                            noOfSeats = noOfSeats.Trim();

                        } while (!Validate.Number(noOfSeats, 37));
                        //number of seats needed
                        travellers = Convert.ToInt32(noOfSeats);
                        GetSeat.BusinessClass(travellers, flightInformation);
                        break;
                    }
                //seatClass = 3) Economy class
                case "3":
                    {
                        //while input not valid (ValidateNumber = false)
                        do
                        {
                            noOfSeats = Console.ReadLine();
                            noOfSeats = noOfSeats.Trim();

                        } while (!Validate.Number(noOfSeats, 109));
                        //number of seats needed
                        travellers = Convert.ToInt32(noOfSeats);
                        GetSeat.EconomyClass(travellers, flightInformation);
                        break;
                    }
            }

            Console.WriteLine("Thank you for your booking on flight {0} from {1} to {2}", userFlightCode, flyingFrom, flyingTo);
            string createText = flightInformation + Environment.NewLine;
            File.WriteAllText(@"F:\Assessment\PlaneBookings", createText);
            Console.WriteLine("Press enter to return to main menu");
            Console.ReadLine();
            Main();
        }
    }
}
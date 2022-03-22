using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment
{
    class DisplayFlight
    {

        /// <summary>
        /// 
        /// </summary>
        public static void Timetable()
        {
            Console.WriteLine("                                Departure Times");
            Console.WriteLine("Flight Code | Day        | Luton | Edinburgh | Glasgow\n");
            Console.WriteLine("WMA001      | Saturday   | 05:00 | 07:15     | 08:10" +
                            "\nWMA002      | Saturday   | 11:00 | 13:15     | 14:15" +
                            "\nWMA003      | Saturday   | 17:05 | 19:20     | 20:30" +
                            "\nWMA101      | Sunday     | 05:00 | 07:15     | 08:10" +
                            "\nWMA102      | Sunday     | 11:00 | 13:15     | 14:15" +
                            "\nWMA103      | Sunday     | 17:45 | 20:00     | 21:10");
            Console.WriteLine("Press enter to return to Main Menu");
            Console.ReadLine();
        }

        /// <summary>
        /// 
        /// </summary>
        public static void Seats()
        {
            Console.SetWindowSize(100, 25);
            Console.WriteLine();
            Console.WriteLine("                                          SEAT ROWS                                          ");
            Console.WriteLine(" S  4 | 4 | 4 | 4 | 4 | 6 | 6 | 6 | 6 | 6 | 6 | 9 | 9 | 9 | 9 | 9 | 9 | 9 | 9 | 9 | 9 | 9 | 9" +
                            "\n E    |   |   |   |   | 5 | 5 | 5 | 5 | 5 | 5 | 8 | 8 | 8 | 8 | 8 | 8 | 8 | 8 | 8 | 8 | 8 | 8" +
                            "\n A  3 | 3 | 3 | 3 | 3 | 4 | 4 | 4 | 4 | 4 | 4 | 7 | 7 | 7 | 7 | 7 | 7 | 7 | 7 | 7 | 7 | 7 | 7" +
                            "\n T    |   |   |   |   |   |   |   |   |   |   | 6 | 6 | 6 | 6 | 6 | 6 | 6 | 6 | 6 | 6 | 6 | 6" +
                            "\n      |   |   |   |   |   |   |   |   |   |   | 5 | 5 | 5 | 5 | 5 | 5 | 5 | 5 | 5 | 5 | 5 | 5" +
                            "\n N    |   |   |   |   |   |   |   |   |   |   | 4 | 4 | 4 | 4 | 4 | 4 | 4 | 4 | 4 | 4 | 4 | 4" +
                            "\n U  2 | 2 | 2 | 2 | 2 | 3 | 3 | 3 | 3 | 3 | 3 | 3 | 3 | 3 | 3 | 3 | 3 | 3 | 3 | 3 | 3 | 3 | 3" +
                            "\n M    |   |   |   |   | 2 | 2 | 2 | 2 | 2 | 2 | 2 | 2 | 2 | 2 | 2 | 2 | 2 | 2 | 2 | 2 | 2 | 2" +
                            "\n B  1 | 1 | 1 | 1 | 1 | 1 | 1 | 1 | 1 | 1 | 1 | 1 | 1 | 1 | 1 | 1 | 1 | 1 | 1 | 1 | 1 | 1 | 1" +
                            "\n E                                                                                           " +
                            "\n R  A | B | C | D | E | F | G | H | I | J | K | L | M | N | O | P | Q | R | S | T | U | V | W" +
                            "\n       First Class    |    Business Class     |                Economy Class                 ");
            Console.WriteLine("Press enter to return to Main Menu");
            Console.ReadLine();
        }

        /// <summary>
        /// 
        /// </summary>
        public static void RetryMenu()
        {
            Console.WriteLine("This is not an avaiable flight" +
                "\nPlease try again or see Flight Timetable.");
            Console.WriteLine("1) Try again" +
                            "\n2) Flight Timetable");
            Console.WriteLine("Please enter a number");
        }

        /// <summary>
        /// 
        /// </summary>
        public static void Menu()
        {
            //prints main menu
            Console.WriteLine("        Wry Man Air:" +
                            "\nLuton -> Edinburgh -> Glasgow");

            //print menu for Wry Man Air Booking
            Console.WriteLine("1) Book Seats");
            Console.WriteLine("2) View Account");
            Console.WriteLine("3) Display Flights");
            Console.WriteLine("4) Display Seats");
            Console.WriteLine("5) Quit");
            Console.WriteLine("Please enter a number:");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string flyFrom()
        {
            string flyingFrom;

            //flying from and to entry
            Console.WriteLine("Please enter where you are flying from");
            //format string (flyingFrom) to make it easier to match
            flyingFrom = Console.ReadLine();
            flyingFrom = flyingFrom.ToUpper();
            flyingFrom = flyingFrom.Trim();
            return flyingFrom;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string flyTo()
        {
            string flyingTo;

            Console.WriteLine("Please enter where you are flying to");
            //format string (flyingTo) to make it easier to match
            flyingTo = Console.ReadLine();
            flyingTo = flyingTo.ToUpper();
            flyingTo = flyingTo.Trim();
            return flyingTo;
        }

        public static string Code()
        {
            string flightCode;

            //Flightcode entry
            Console.WriteLine("Please enter your flight code");
            //format string to make it easier to match
            flightCode = Console.ReadLine();
            flightCode = flightCode.ToUpper();
            flightCode = flightCode.Trim();
            return flightCode;
        }

        public static void SeatingClass()
        {
            //seating class entry
            Console.WriteLine("Which class are you booking?");
            Console.WriteLine("1) First Class" +
                            "\n2) Business" +
                            "\n3) Economy");
            Console.WriteLine("Please enter a number");
        }
    }
}

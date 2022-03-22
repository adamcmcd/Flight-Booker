using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Assessment
{
    class Validate
    {
        //variable declaration
        static string userInput;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userString"></param>
        /// <param name="range"></param>
        /// <returns></returns>
        public static bool Number(string userString, int range)
        {
            int userNumber;

            //checks if user's input is same as integer and converts if possible
            if (int.TryParse(userString, out userNumber))
            {
                if (userNumber >= range || userNumber <= 0)
                {
                    Console.WriteLine("Please enter a number within range");
                    return false;
                }
                //if in range return true
                else
                {
                    return true;
                }
            }
            //if not same as integer return false
            else
            {
                Console.WriteLine("Please enter a number");
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <param name="key2"></param>
        /// <returns></returns>
        public static bool Password(string key, string key2)
        {
            if (key == key2)
            {
                return true;
            }
            else
            {
                Console.WriteLine("The passwords you have entered do not match \nPlease try again");
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="codeName"></param>
        /// <returns></returns>
        public static bool FlightCode(string codeName)
        {
            //string array of all flight codes
            string[] flightCode = new string[6] { "WMA001", "WMA002", "WMA003", "WMA101", "WMA102", "WMA103" };

            //check if user input is a valid code
            if (flightCode.Contains(codeName))
            {
                return true;
            }
            else
            {
                DisplayFlight.RetryMenu();

                //does while user's input is not valid (ValidateNumber = false)
                do
                {
                    userInput = Console.ReadLine();
                    userInput = userInput.Trim();

                } while (!Number(userInput, 3));

                switch (userInput)
                {
                    //userInput = 1) retry entry of flight code
                    case "1":
                        {
                            return false;
                        }
                    //userInput = 2) prints Flight Timetable and retry entry of flight code
                    case "2":
                        {
                            DisplayFlight.Timetable();
                            return false;
                        }
                    //default retry entry of flight code
                    default:
                        {
                            return false;
                        }
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="departure"></param>
        /// <param name="arrival"></param>
        /// <returns></returns>
        public static bool Airports(string departure, string arrival)
        {
            //string array of all locations
            string[] locations = new string[3] { "LUTON", "EDINBURGH", "GLASGOW" };

            //check if user has entered valid locations and they are not the same
            if (locations.Contains(departure) && locations.Contains(arrival) && departure != arrival)
            {
                return true;
            }
            //user inputs are not a correct location or they are the same as each other
            else
            {
                DisplayFlight.RetryMenu();

                //does while user's input is not valid (ValidateNumber = false)
                do
                {
                    userInput = Console.ReadLine();
                    userInput = userInput.Trim();

                } while (!Validate.Number(userInput, 3));

                switch (userInput)
                {
                    //userInput = 1) retry entry of flyingFrom/To
                    case "1":
                        {
                            return false;
                        }
                    //userInput = 2) prints Flight Timetable and retry entry of flyingFrom/To
                    case "2":
                        {
                            DisplayFlight.Timetable();
                            return false;
                        }
                    //retry entry of flight code
                    default:
                        {
                            return false;
                        }
                }
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Assessment
{
    class GetSeat
    {
        static string seat;
        static int seatsBookedFC = 0;
        static int seatsBookedBC = 0;
        static int seatsBookedEC = 0;
        static string row;
        static string number;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="travellers"></param>
        public static void FirstClass(int travellers, string flightInformation)
        {
            //string arrays for rows and columns of seats in first class
            string[] seatRows = new string[5] { "A", "B", "C", "D", "E" };
            string[] seatNumbers = new string[4] { "1", "2", "3", "4" };
            int capacity = 20;

            //instantiate new class given user inputs on the flight they have chosen
            Planes myObject = new Planes(5, 6, 12);


           // myObject = (Planes)Activator.CreateInstance(Type.GetType(flightInformation), flightInformation);

            /*
            var container = Activator.CreateInstance(Assessment, Assessment.Planes.myObject);
            myObject obj = (myObject)container.Unwrap();

            string typex = typeof(Planes).AssemblyQualifiedName;
            var type = Type.GetType(typex);
            var myObject = (Planes)Activator.CreateInstance(type);*/



            //check if there would be enough seats
            if (travellers + seatsBookedFC > capacity)
            {
                Console.WriteLine("Sorry there is not enough space in first class, please try a different class or flight.");
            }

            //else there is enough space and add one to the number of seats that have been booked in this seating class
            else
            {
                Console.WriteLine("Your seat(s):");

                for (int i = 0; i < travellers; i++)
                {
                    //does while the seat has already been booked 
                    do
                    {
                        row = RandomIndex(seatRows, 5);
                        number = RandomIndex(seatNumbers, 4);
                        seatsBookedFC++;
                        

                    } while (!myObject.SeatValidFC(row, number));

                    seat = row + number;
                    Console.WriteLine(seat);
                    string createText = seat + Environment.NewLine;
                    File.WriteAllText(@"F:\Assessment\PlaneBookings", createText);
                }

                //if booking more than one seat, bunch seats together
                /*if (travellers >= 2)
                {
                    int tempNumber = Convert.ToInt32(number) - 1;
                    bool tempBool;
                    //for the number of seats being booked by the user
                    for (int index = 2; index <= travellers; index++)
                    {
                        int counter = 1;
                        //does while the seat is not booked or counter reaches 5
                        do
                        {
                            //the number of seats in a row
                            if (tempNumber == 4)
                            {
                                tempNumber = 1;
                            }
                            else
                            {
                                tempNumber = tempNumber + 1;
                            }
                            number = Convert.ToString(tempNumber);
                            tempBool = !myObject.SeatValidFC(row, number);
                            counter++;

                        } while (!tempBool || counter != 5);

                        //if seat was booked
                        if (tempBool == true)
                        {
                            seat = row + number;
                            Console.WriteLine(seat);
                        }
                    }
                }*/
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="travellers"></param>
        public static void BusinessClass(int travellers, string flightInformation)
        {
            //string arrays for rows and columns of seats in business class
            string[] seatRows = new string[6] { "F", "G", "H", "I", "J", "K" };
            string[] seatNumbers = new string[6] { "1", "2", "3", "4", "5", "6" };
            int capacity = 36;

            //instantiate new class given user inputs on the flight they have chosen
            Planes myObject = new Planes(5, 6, 12);
            //Planes flightInformation = new Planes(5, 6, 12);

            //myObject = (Planes)Activator.CreateInstance(null, flightInformation);

            //check if there would be enough seats
            if (travellers + seatsBookedBC > capacity)
            {
                Console.WriteLine("Sorry there is not enough space in business class, please try a different class or flight.");
            }

            //else there is enough space and add one to the number of seats that have been booked in this seating class
            else
            {
                Console.WriteLine("Your seat(s):");
                //for the number of seats being booked by the user
                for (int i = 1; i <= travellers; i++)
                {
                    //does while the seat has already been booked 
                    do
                    {
                        row = RandomIndex(seatRows, 6);
                        number = RandomIndex(seatNumbers, 6);
                        seatsBookedFC++;

                    } while (!myObject.SeatValidBC(row, number));

                    seat = row + number;
                    Console.WriteLine(seat);
                    File.WriteAllText(@"E:\Uni\Assessment\PlaneBookings", seat);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="travellers"></param>
        public static void EconomyClass(int travellers, string flightInformation)
        {
            //string arrays for rows and columns of seats in economy class
            string[] seatRows = new string[12] { "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W" };
            string[] seatNumbers = new string[9] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            int capacity = 108;

            //instantiate new class given user inputs on the flight they have chosen
            Planes myObject = new Planes(5, 6, 12);

            //myObject = (Planes)Activator.CreateInstance(null, flightInformation);

            //check if there would be enough seats
            if (travellers + seatsBookedEC > capacity)
            {
                Console.WriteLine("Sorry there is not enough space in economy class, please try a different class or flight.");
            }

            //else there is enough space and add one to the number of seats that have been booked in this seating class
            else
            {
                Console.WriteLine("Your seat(s):");
                //for the number of seats being booked by the user
                for (int i = 1; i <= travellers; i++)
                {
                    //does while the seat has already been booked 
                    do
                    {
                        row = RandomIndex(seatRows,12);
                        number = RandomIndex(seatNumbers, 9);
                        seatsBookedFC++;

                    } while (!myObject.SeatValidEC(row, number));

                    seat = row + number;
                    Console.WriteLine(seat);
                    File.WriteAllText(@"E:\Uni\Assessment\PlaneBookings", seat);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        static int randomIndex(int length)
        {
            Random r = new Random();
            int index = r.Next(0, length);
            return index;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="seat"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static string RandomIndex(string[] seat, int index)
        {
            string randomSeat = seat[randomIndex(index)];
            return randomSeat;
        }
    }
}

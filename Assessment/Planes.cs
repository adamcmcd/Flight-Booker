using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment
{
    class Planes
    {
        bool[,] firstClass;
        bool[,] businessClass;
        bool[,] economyClass;

        int firstClassRow, businessClassRow, economyClassRow;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_firstClass"></param>
        /// <param name="_businessClass"></param>
        /// <param name="_economyClass"></param>
        public Planes(int _firstClass, int _businessClass, int _economyClass)
        {
            firstClass = new bool[_firstClass, 4];
            businessClass = new bool[_businessClass, 6];
            economyClass = new bool[_economyClass, 9];

            firstClassRow = _firstClass;
            businessClassRow = _businessClass;
            economyClassRow = _economyClass;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="seatRow"></param>
        /// <param name="seatNumber"></param>
        /// <returns></returns>
        public bool SeatValidFC(string seatRow, string seatNumber)
        {
            int row = (int)Char.ToUpper(seatRow[0]) - 65;
            int number = Convert.ToInt32(seatNumber) - 1;

            //verifies if seat is set to false (not booked)
            if (!firstClass[row, number])
            {
                firstClass[row, number] = true;
                return true;
            }
            //else the seat is set to true (booked)
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="seatRow"></param>
        /// <param name="seatNumber"></param>
        /// <returns></returns>
        public bool SeatValidBC(string seatRow, string seatNumber)
        {
            int row = (int)Char.ToUpper(seatRow[0]) - 70;
            int number = Convert.ToInt32(seatNumber) - 1;

            //verifies if seat is set to false (not booked)
            if (!businessClass[row, number])
            {
                businessClass[row, number] = true;
                return true;
            }
            //else the seat is set to true (booked)
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="seatRow"></param>
        /// <param name="seatNumber"></param>
        /// <returns></returns>
        public bool SeatValidEC(string seatRow, string seatNumber)
        {
            int row = (int)Char.ToUpper(seatRow[0]) - 76;
            int number = Convert.ToInt32(seatNumber) - 1;

            //verifies if seat is set to false (not booked)
            if (!economyClass[row, number])
            {
                economyClass[row, number] = true;
                return true;
            }
            //else the seat is set to true (booked)
            else
            {
                return false;
            }
        }
    }
}

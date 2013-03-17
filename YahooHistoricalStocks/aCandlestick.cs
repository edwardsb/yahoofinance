/************
Authors:
 Ben Edwards
 Guido Giron
*************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace YahooHistoricalaCandlesticks
{
    class aCandlestick
    {
        //Private Data Members
        private string aCandlestickName;
        private string dateFromDay;
        private string dateFromMonth;
        private string dateFromYear;
        private string dateToDay;
        private string dateToMonth;
        private string dateToYear;
        private string interval;
        private string url;
        Dictionary<string, string> test = new Dictionary<string, string>();

        /// <summary>
        /// Defines a dictionary with predefined (key,value) pairs
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, string> dictionary()
        {
            test.Add("", "");
            test.Add("GOOGLE", "GOOG");
            test.Add("APPLE", "AAPL");
            test.Add("INTEL", "INTC");
            test.Add("ADVANCED MICRO DEVICES", "AMD");
            test.Add("DELL", "DELL");
            test.Add("ORACLE", "ORCL");
            test.Add("CISCO", "CSCO");
            test.Add("RAYTHEON", "RTN");
            test.Add("FACEBOOK", "FB");
            test.Add("NETFLIX", "NFLX");
            test.Add("BANK OF AMERICA", "BAC");
            test.Add("AMAZON", "AMZN");
            test.Add("ADOBE SYSTEMS INC.", "ADBE");
            return test;
        }

        /// <summary>
        ///  Converts the start date: Day, Month, and Year from int string values
        /// </summary>
        /// <param name="day">int day</param>
        /// <param name="month">int month</param>
        /// <param name="year">int year</param>
        public void setDateFrom(int day, int month, int year)
        {
            dateFromDay = day.ToString();
            dateFromMonth = (month - 1).ToString();
            dateFromYear = year.ToString();
        }

        /// <summary>
        /// Converts the end date: Day, Month, and Year from int string values
        /// </summary>
        /// <param name="day">int day</param>
        /// <param name="month">int month</param>
        /// <param name="year">int year</param>
        public void setDateTo(int day, int month, int year)
        {
            dateToDay = day.ToString();
            dateToMonth = (month - 1).ToString();
            dateToYear = year.ToString();
        }

        /// <summary>
        /// Sets aCandlestick name
        /// </summary>
        /// <param name="name">string name</param>
        public void setaCandlestickName(string name)
        {
            aCandlestickName = name;
        }

        /// <summary>
        /// Sets the appropiate interval letter to find a quote using Yahoo Finance API
        /// </summary>
        /// <param name="interval_">int interval_</param>
        public void setInterval(int interval_)
        {
            switch (interval_)
            {
                case 0:
                    interval = "d"; // Daily quote
                    break;
                case 1:
                    interval = "w"; // Weekly quote
                    break;
                case 2:
                    interval = "m"; // Monthly quote
                    break;
                default:
                    interval = "d"; // Dividend
                    break;
            }
        }

        /// <summary>
        /// Builds an URI using Yahoo Finance API 
        /// </summary>
        /// <returns></returns>
        public Uri buildURL()
        {

            url = "http://ichart.yahoo.com/table.csv?s=" + aCandlestickName + "&a=" + dateFromMonth + "&b=" + dateFromDay +
                "&c=" + dateFromYear + "&d=" + dateToMonth + "&e=" + dateToDay + "&f=" + dateToYear + "&g=" + interval +
                "&ignore=.cvs";

            Uri uri = new Uri(url);

            return uri;
        }

        /// <summary>
        /// Takes a string array and creates a Datatable with seven columns: Date, Open, High, Low, Close, Avg Vol, Adj Close.
        /// </summary>
        /// <param name="array">String Array</param>
        /// <returns></returns>
        public DataTable ArrayToDataTable(string[] array)
        {
            DataTable dt = new DataTable();            // Creates Datatable and adds seven columns. 
            dt.Columns.Add("Date", typeof(DateTime));
            dt.Columns.Add("Open", typeof(decimal));
            dt.Columns.Add("High", typeof(decimal));
            dt.Columns.Add("Low", typeof(decimal));
            dt.Columns.Add("Close", typeof(decimal));
            dt.Columns.Add("Avg Vol", typeof(decimal));
            dt.Columns.Add("Adj Close", typeof(decimal));

            for (int row = 0; row < array.Length - 1; row++) // For loop to fill Datatable with array content
            {
                if (row != 0)
                {
                    string str = array[row];          //Each element row in array gets assigned to str
                    string[] item = str.Split(',');
                    DataRow dr = dt.NewRow();        //New datarow gets instantiated
                    for (int col = 0; col < item.Length; col++)
                    {
                        if (col == 0)
                        {
                            dr[col] = DateTime.Parse(item[col]); //Column 0 gets parsed as Datetime
                        }
                        else
                        {
                            dr[col] = Decimal.Parse(item[col]); ////The rest of columns gets parsed as Decimal
                        }

                    }
                    dt.Rows.Add(dr);
                }
            }

            return dt;
        }
    }

}

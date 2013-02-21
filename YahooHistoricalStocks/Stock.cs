using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace YahooHistoricalStocks
{
    class Stock
    {
        public string stockName;
        public string dateFromDay;
        public string dateFromMonth;
        public string dateFromYear;
        public string dateToDay;
        public string dateToMonth;
        public string dateToYear;
        public string interval;
        public string url;
        Dictionary<string, string>test = new Dictionary<string, string>();

        public Dictionary<string , string> dictionary()
        {
            test.Add("","");
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

        public void setDateFrom(int day, int month, int year){
            dateFromDay = day.ToString();
            dateFromMonth = (month - 1).ToString();
            dateFromYear = year.ToString();
        }

        public void setDateTo(int day, int month, int year){
            dateToDay = day.ToString();
            dateToMonth = (month - 1).ToString();
            dateToYear = year.ToString();
        }

        public void setStockName(string name){
            stockName = name;
        }

        public void setInterval(int interval_){
            switch(interval_){
                case 0:
                    interval = "d";
                    break;
                case 1:
                    interval = "w";
                    break;
                case 2:
                    interval = "m";
                    break;
                default:
                    interval = "d";
                    break;
            }
        }

        public Uri buildURL(){

            url = "http://ichart.yahoo.com/table.csv?s=" + stockName + "&a=" + dateFromMonth + "&b=" + dateFromDay +
                "&c=" + dateFromYear + "&d=" + dateToMonth + "&e=" + dateToDay + "&f=" + dateToYear + "&g=" + interval +
                "&ignore=.cvs";

            Uri uri = new Uri(url);

            return uri;
        }

        public DataTable ArrayToDataTable(string[] arr)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Date", typeof(DateTime));
            dt.Columns.Add("Open", typeof(decimal));
            dt.Columns.Add("High", typeof(decimal));
            dt.Columns.Add("Low", typeof(decimal));
            dt.Columns.Add("Close", typeof(decimal));
            dt.Columns.Add("Avg Vol", typeof(decimal));
            dt.Columns.Add("Adj Close", typeof(decimal));

            for (int row = 0; row < arr.Length - 1; row++)
            {
                if (row != 0)
                {
                    string str = arr[row];
                    string[] item = str.Split(',');
                    DataRow dr = dt.NewRow();
                    for (int col = 0; col < item.Length; col++)
                    {
                        if (col == 0)
                        {
                            dr[col] = DateTime.Parse(item[col]);
                        }
                        else
                        {
                            dr[col] = Decimal.Parse(item[col]);
                        }

                    }
                    dt.Rows.Add(dr);
                }
            }

            return dt;
        }
    }

}

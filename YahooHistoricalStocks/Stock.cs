using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
            test.Add("GOOGLE", "GOOG");
            test.Add("APPLE", "AAPL");
            test.Add("BANK OF AMERICA", "BAC");
            test.Add("AMAZON", "AMZN");
            test.Add("Adobe Systems Inc.", "ADBE");
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
    }

}

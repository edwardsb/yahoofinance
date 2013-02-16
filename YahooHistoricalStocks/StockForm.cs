using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace YahooHistoricalStocks
{
    public partial class StockForm : Form
    {
        Stock stocks = new Stock();
        TimeSpan diff;
        int? selectedInterval = null;
        public StockForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            diff = dateTimePickerTo.Value.Subtract(dateTimePickerFrom.Value);
           
            if (textBoxStockName.Text != "")
            {
                if (diff.Days > 0)
                {
                   if(selectedInterval!=null)
                   {
                       downloadFile();
                   }
                   else
                   {
                       MessageBox.Show("Select Interval");
                   }
                }
                else
                {
                    MessageBox.Show("Date range is negative");
                }
            }
            else {
                MessageBox.Show("Stock name is not entered");
            }
        }

        private void downloadFile(){

            stocks.setStockName(textBoxStockName.Text);
            stocks.setDateFrom(dateTimePickerFrom.Value.Day, dateTimePickerFrom.Value.Month, dateTimePickerFrom.Value.Year);
            stocks.setDateTo(dateTimePickerTo.Value.Day, dateTimePickerTo.Value.Month, dateTimePickerTo.Value.Year);
            stocks.setInterval(comboBoxInterval.SelectedIndex);
            Uri uri = stocks.buildURL();
            WebClient webclient = new WebClient();
            try
            {
                string mystring = webclient.DownloadString(uri);
                MessageBox.Show("Stock Downloaded");
                Console.Out.Write(mystring);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Downloading File");
               
            }

        }

        private void comboBoxInterval_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedInterval = comboBoxInterval.SelectedIndex;
        }

    }

        

   
}

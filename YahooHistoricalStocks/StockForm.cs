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
using System.Text.RegularExpressions;

namespace YahooHistoricalStocks
{
    public partial class StockForm : Form
    {
        Stock stocks = new Stock();
        TimeSpan diff;
        int? selectedInterval = null;
        string ddlvalue = string.Empty;
        public StockForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<DateTime> datelist = getWeekendDays();
            foreach (DateTime date in datelist)
            {
                System.Console.WriteLine("this date is blacked out: " + date);
            }
            diff = dateTimePickerTo.Value.Subtract(dateTimePickerFrom.Value);
            DayOfWeek from = dateTimePickerFrom.Value.DayOfWeek;
            DayOfWeek to = dateTimePickerTo.Value.DayOfWeek;
            if (textBoxStockName.Text != "" || ddl.SelectedIndex != 0)
            {
                if (diff.Days > 0)
                {
                    if (selectedInterval != null && to != DayOfWeek.Saturday && to != DayOfWeek.Sunday && from != DayOfWeek.Saturday && from != DayOfWeek.Sunday)
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        downloadFile();
                        Cursor.Current = Cursors.Default;
                    }
                    else
                    {
                        MessageBox.Show("Select Interval. Monday to Frinday Only!");
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

        private string downloadFile(){
            string mystring = String.Empty;
            if (textBoxStockName.Text !="")
            {
                stocks.setStockName(textBoxStockName.Text);
            }
            if (ddlvalue != "")
            {
                stocks.setStockName(ddlvalue);
                textBoxStockName.Text = "";
            }
            stocks.setDateFrom(dateTimePickerFrom.Value.Day, dateTimePickerFrom.Value.Month, dateTimePickerFrom.Value.Year);
            stocks.setDateTo(dateTimePickerTo.Value.Day, dateTimePickerTo.Value.Month, dateTimePickerTo.Value.Year);
            stocks.setInterval(comboBoxInterval.SelectedIndex);
            Uri uri = stocks.buildURL();
            WebClient webclient = new WebClient();
            DataTable table = new DataTable();
            try
            {
                mystring = webclient.DownloadString(uri);
                MessageBox.Show("Stock Downloaded");
                string[] split = mystring.Split(new[] { '\n' });
                table = stocks.ArrayToDataTable(split);

                //Block to query MAX and MIN in all decimal type columns ***MAY BE HELPFUL IN THE FUTURE***
                //var values = table.Rows
                //              .Cast<DataRow>()
                //              .SelectMany(row => row.ItemArray.Skip(1), (row, value) => (decimal)value)
                //              .ToList();
                //decimal min = values.Min();
                //decimal max = values.Max();


                var maxValue = table.Rows.OfType<DataRow>().Select(row => row["High"]).Max();
                var minValue = table.Rows.OfType<DataRow>().Select(row => row["Low"]).Min();
                labelHighValue.Text = maxValue.ToString();
                labelLowValue.Text = minValue.ToString();
                ddl.SelectedIndex = 0;
                
            } 

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Downloading File");

            }

            return mystring;

        }

      

        private void comboBoxInterval_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedInterval = comboBoxInterval.SelectedIndex;
        }

        private void StockForm_Load(object sender, EventArgs e)
        {
            ddl.DataSource = new BindingSource(stocks.dictionary(), null);
            ddl.DisplayMember = "Key";
            ddl.ValueMember = "Value";

       }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
   

            // Get combobox selection (in handler)
            ddlvalue = ((KeyValuePair<string, string>)ddl.SelectedItem).Value;
        }

        private List<DateTime> getWeekendDays()
        {
            List<DateTime> list = new List<DateTime>();
            int days = DateTime.DaysInMonth(dateTimePickerFrom.Value.Year, dateTimePickerFrom.Value.Month);
            for (int i = 0; i < days; i++)
            {
                DateTime datetime = new DateTime(dateTimePickerFrom.Value.Year, dateTimePickerFrom.Value.Month, i + 1);
                if (datetime.DayOfWeek == DayOfWeek.Saturday || datetime.DayOfWeek == DayOfWeek.Sunday)
                {
                    list.Add(datetime);
                }
            }
            return list;
        }

    }

        

   
}

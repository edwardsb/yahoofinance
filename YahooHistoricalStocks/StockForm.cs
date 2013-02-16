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

        private string downloadFile(){
            string mystring = String.Empty;
            stocks.setStockName(ddlvalue);
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
                table = ArrayToDataTable(split);

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

                Console.Out.Write(mystring);

            } 

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Downloading File");

            }

            return mystring;

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

        private void comboBoxInterval_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedInterval = comboBoxInterval.SelectedIndex;
        }

        private void StockForm_Load(object sender, EventArgs e)
        {
            ddl.DataSource = new BindingSource(stocks.dictionary(), null);
            ddl.DisplayMember = "Value";
            ddl.ValueMember = "Key";

       }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
   

            // Get combobox selection (in handler)
            ddlvalue = ((KeyValuePair<string, string>)ddl.SelectedItem).Value;
        }

    }

        

   
}

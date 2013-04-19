/************
Authors:
 Ben Edwards
 Guido Giron
*************/
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;
using System.Net;




namespace YahooHistoricalaCandlesticks
{
    

    public partial class stockForm : Form
    {
        aCandlestick aCandlesticks = new aCandlestick(); //aCandlestick Default Constructor
        TimeSpan diff;                                   //Declares a TimeSpan variable which allows for calculation with time
        int? selectedInterval = null;                    //Declares a nullable int variable
        string ddlvalue = string.Empty;                  //Stores dropdownlist item selected
        DataTable table = new DataTable();


        public stockForm()                               //Initializes Windows form
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)  //on_Click EventListener for Get Data button
        {

            diff = dateTimePickerTo.Value.Subtract(dateTimePickerFrom.Value); // Substract dateTo from dateFrom 
            DayOfWeek from = dateTimePickerFrom.Value.DayOfWeek;              //Gets the day of the week for variable from
            DayOfWeek to = dateTimePickerTo.Value.DayOfWeek;                  //Gets the day of the week for variable to
            if (textBoxaCandlestickName.Text != "" || ddl.SelectedIndex != 0)
            {
                if (diff.Days > 0) // Checks for a valid interval 
                {
                    // Check for days between Monday to Friday in the interval
                    if (to != DayOfWeek.Saturday && to != DayOfWeek.Sunday && from != DayOfWeek.Saturday && from != DayOfWeek.Sunday)
                    {
                        if (selectedInterval != null)
                        {
                            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;  //Sets cursor busy
                            downloadFile();                                            //Calls main function
                            System.Windows.Forms.Cursor.Current = Cursors.Default;     //Sets cursor default
                        }
                        else
                        {
                            MessageBox.Show("Select Interval");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Monday to Friday Only!");
                    }
                }
                else
                {
                    MessageBox.Show("Date range is negative");
                }
            }
            else
            {
                MessageBox.Show("Stock name is not entered");
            }

        }

        private void downloadFile() //Downloads quote using Yahoo Finance API
        {
            string mystring = String.Empty;
            if (textBoxaCandlestickName.Text != "")   // Logic makes stock name textbox and dropdownlist mutually exclusive.
            {
                aCandlesticks.setaCandlestickName(textBoxaCandlestickName.Text);
                lblTicker.Text = textBoxaCandlestickName.Text;
                textBoxaCandlestickName.Text = "";
            }
            if (ddlvalue != "")       //Dropdownlist takes precedence over Textbox
            {
                aCandlesticks.setaCandlestickName(ddlvalue);
                lblTicker.Text = ddlvalue;
                textBoxaCandlestickName.Text = "";
            }
            aCandlesticks.setDateFrom(dateTimePickerFrom.Value.Day, dateTimePickerFrom.Value.Month, dateTimePickerFrom.Value.Year);//Uses properties from aCandlesticks to validate values
            aCandlesticks.setDateTo(dateTimePickerTo.Value.Day, dateTimePickerTo.Value.Month, dateTimePickerTo.Value.Year);
            aCandlesticks.setInterval(comboBoxInterval.SelectedIndex);
            Uri uri = aCandlesticks.buildURL();    //Calls buildURL method in aCandlesticks class
            WebClient webclient = new WebClient(); //Instantiates WebClient object to download quote

            try
            {
                mystring = webclient.DownloadString(uri); //Downloads content of URI
                MessageBox.Show("Stock Downloaded");
                string[] split = mystring.Split(new[] { '\n' }); //Splits mystring at every new line into split array
                table = aCandlesticks.ArrayToDataTable(split);   //Calls ArrayToDataTable method in aCandlesticks class
                dataGridView1.DataSource = null;
                dataGridView2.DataSource = null;
                if (table.Rows.Count != 0)
                {
                    var maxValue = table.Rows.OfType<DataRow>().Select(row => row["High"]).Max(); //Uses LINQ statement to query Datatable for highest price
                    var minValue = table.Rows.OfType<DataRow>().Select(row => row["Low"]).Min(); //Uses LINQ statement to query Datatable for highest lowest
                    labelHighValue.Text = maxValue.ToString();                                   //Sets Max value to labelHighValue
                    labelLowValue.Text = minValue.ToString();                                    //Sets Min value to   labelLowValue
                    ddl.SelectedIndex = 0;                                                       //Sets Index in dropdownlist back to 0

                    var labels = table.Rows.OfType<DataRow>().Select(dr => dr.Field<DateTime>("Date")).ToList(); // Creates a list from the column "Date" in Datatable
                    var open = table.Rows.OfType<DataRow>().Select(dr => dr.Field<Decimal>("Open")).ToList();    // Creates a list from the column "Open" in Datatable
                    var high = table.Rows.OfType<DataRow>().Select(dr => dr.Field<Decimal>("High")).ToList();    // Creates a list from the column "High" in Datatable
                    var low = table.Rows.OfType<DataRow>().Select(dr => dr.Field<Decimal>("Low")).ToList();      // Creates a list from the column "Low"  in Datatable
                    var close = table.Rows.OfType<DataRow>().Select(dr => dr.Field<Decimal>("Close")).ToList();  // Creates a list from the column "Close" in Datatable

                    //////////////////////////////////////////////////////////////// New Addition to the Application (3 porject) 

                    dataGridView1.DataSource = table;               //Creates first dataGridView, all Candlesticks
                    var avg = table.Compute("Avg([Close])", "");    //Finds Average closing price using LINQ statement
                    decimal roundAvg = Math.Round((decimal)avg, 2); //Rounds Average result 2 decimal places
                    var sum = table.Compute("Sum([Volume])", "");   //Finds Sum of the volumes
                    labelCloseAvg.Text = roundAvg.ToString();       //Sets Average to labelCloseAvg
                    labelSumVol.Text = sum.ToString();              //Sets Sum to labelSumVol
                    var Table = table.AsEnumerable();               //Converts Datatable into IEnumerable object to be used in LINQ
                    IEnumerable<DataRow> query = from row in Table  //Find dates (rows) where close price is greater than open price
                                                 where row.Field<decimal>("Open") < row.Field<decimal>("Close")
                                                 select row;
                    if (query.IsAny())  //Checks if query is null
                    {
                        DataTable HighCloseTable = query.CopyToDataTable<DataRow>(); //Converts IEnumerable object back to Datatable
                        dataGridView2.DataSource = HighCloseTable;                   //Creates secound dataGridView with Candlesticks where close price is greater than open price
                    }
                    
                    //////////////////////////////////////////////////////////////////

                    if (seriesExist(chart1, "Price")) //Check is Series "Price" exists
                    {
                        chart1.Series.Clear();         //if True Clear the Series
                    }

                    Series Price = new Series("Price"); // Creates a Series named "Price"
                    chart1.Series.Add(Price);           // Adds Series to chart1


                    chart1.Series["Price"].ChartType = SeriesChartType.Candlestick; // Set Series chart-type to Candlestick

                    chart1.Series["Price"]["OpenCloseStyle"] = "Triangle"; // Set the style of the open-close marks

                    chart1.Series["Price"]["ShowOpenClose"] = "Both";  // Show both open and close marks

                    chart1.Series["Price"]["PointWidth"] = "1.0"; // Set point width

                    chart1.Series["Price"]["PriceUpColor"] = "Green"; // Set colors bars
                    chart1.Series["Price"]["PriceDownColor"] = "Red";

                    for (int i = 0; i < labels.Count; i++)
                    {
                        chart1.Series["Price"].Points.AddXY(labels[i], high[i]); // Adding date and high
                        chart1.Series["Price"].Points[i].YValues[1] = Convert.ToDouble(low[i]);   // Adding low                   
                        chart1.Series["Price"].Points[i].YValues[2] = Convert.ToDouble(open[i]);  // Adding open                       
                        chart1.Series["Price"].Points[i].YValues[3] = Convert.ToDouble(close[i]); // Adding close
                    }

                    ////////////////////////////////////////////////////////////// Enables Zoom functionality to chart
                    button1_Click_1(new object(), new EventArgs());           
                    chart1.ChartAreas[0].CursorX.IsUserEnabled = true;
                    chart1.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
                    chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
                    chart1.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;

                    chart1.ChartAreas[0].CursorY.IsUserEnabled = true;
                    chart1.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
                    chart1.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
                    chart1.ChartAreas[0].AxisY.ScrollBar.IsPositionedInside = true;
                    ////////////////////////////////////////////////////////////////
            }
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Downloading File");

            }
             
        }

        private void comboBoxInterval_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedInterval = comboBoxInterval.SelectedIndex; //Reads the new value of dropodownlist for interval
        }

        private void aCandlestickForm_Load(object sender, EventArgs e)
        {
            ddl.DataSource = new BindingSource(aCandlesticks.dictionary(), null);//Binds dictionary to dropdownlist datasource 
            ddl.DisplayMember = "Key";     //Assigns <key,value> pair to ddl
            ddl.ValueMember = "Value";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Get combobox selection
            ddlvalue = ((KeyValuePair<string, string>)ddl.SelectedItem).Value;
        }

        private bool seriesExist(Chart chart, String seriesName)
        {
            foreach (Series s in chart.Series)     //Check if series exist
            {
                if (s.Name == seriesName)
                    return true;
            }
            return false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            while (chart1.ChartAreas[0].AxisX.ScaleView.IsZoomed) //Resets Zoom
                chart1.ChartAreas[0].AxisX.ScaleView.ZoomReset();

            while (chart1.ChartAreas[0].AxisY.ScaleView.IsZoomed)
                chart1.ChartAreas[0].AxisY.ScaleView.ZoomReset();
        }

    }

    public static class Utils
    {
        public static bool IsAny<T>(this IEnumerable<T> data) //Checks if IEnumerable is null
        {
            return data != null && data.Any();
        }
    }

}

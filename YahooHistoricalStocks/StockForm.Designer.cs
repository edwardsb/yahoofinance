namespace YahooHistoricalaCandlesticks
{
    partial class stockForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stockForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.labelDatePickerFrom = new System.Windows.Forms.Label();
            this.labelDatePickerTo = new System.Windows.Forms.Label();
            this.buttonGetData = new System.Windows.Forms.Button();
            this.textBoxaCandlestickName = new System.Windows.Forms.TextBox();
            this.labelaCandlestickName = new System.Windows.Forms.Label();
            this.comboBoxInterval = new System.Windows.Forms.ComboBox();
            this.labelInterval = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ddl = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelHigh = new System.Windows.Forms.Label();
            this.labelLow = new System.Windows.Forms.Label();
            this.labelHighValue = new System.Windows.Forms.Label();
            this.labelLowValue = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTicker = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCloseAvg = new System.Windows.Forms.Label();
            this.labelSumVol = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(81, 118);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFrom.TabIndex = 0;
            this.toolTip1.SetToolTip(this.dateTimePickerFrom, "Set Date Range -> Start Date");
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(81, 157);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerTo.TabIndex = 1;
            this.toolTip1.SetToolTip(this.dateTimePickerTo, "Set Date Range -> End Date");
            // 
            // labelDatePickerFrom
            // 
            this.labelDatePickerFrom.AutoSize = true;
            this.labelDatePickerFrom.Location = new System.Drawing.Point(44, 121);
            this.labelDatePickerFrom.Name = "labelDatePickerFrom";
            this.labelDatePickerFrom.Size = new System.Drawing.Size(33, 13);
            this.labelDatePickerFrom.TabIndex = 2;
            this.labelDatePickerFrom.Text = "From:";
            // 
            // labelDatePickerTo
            // 
            this.labelDatePickerTo.AutoSize = true;
            this.labelDatePickerTo.Location = new System.Drawing.Point(53, 162);
            this.labelDatePickerTo.Name = "labelDatePickerTo";
            this.labelDatePickerTo.Size = new System.Drawing.Size(23, 13);
            this.labelDatePickerTo.TabIndex = 3;
            this.labelDatePickerTo.Text = "To:";
            // 
            // buttonGetData
            // 
            this.buttonGetData.Location = new System.Drawing.Point(230, 418);
            this.buttonGetData.Name = "buttonGetData";
            this.buttonGetData.Size = new System.Drawing.Size(74, 34);
            this.buttonGetData.TabIndex = 4;
            this.buttonGetData.Text = "GET DATA";
            this.buttonGetData.UseVisualStyleBackColor = true;
            this.buttonGetData.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxaCandlestickName
            // 
            this.textBoxaCandlestickName.Location = new System.Drawing.Point(81, 58);
            this.textBoxaCandlestickName.Name = "textBoxaCandlestickName";
            this.textBoxaCandlestickName.Size = new System.Drawing.Size(100, 20);
            this.textBoxaCandlestickName.TabIndex = 5;
            this.toolTip1.SetToolTip(this.textBoxaCandlestickName, "Type a Ticker or Select one from DropDown List");
            // 
            // labelaCandlestickName
            // 
            this.labelaCandlestickName.AutoSize = true;
            this.labelaCandlestickName.Location = new System.Drawing.Point(6, 61);
            this.labelaCandlestickName.Name = "labelaCandlestickName";
            this.labelaCandlestickName.Size = new System.Drawing.Size(69, 13);
            this.labelaCandlestickName.TabIndex = 6;
            this.labelaCandlestickName.Text = "Stock Name:";
            // 
            // comboBoxInterval
            // 
            this.comboBoxInterval.FormattingEnabled = true;
            this.comboBoxInterval.Items.AddRange(new object[] {
            "Daily",
            "Weekly",
            "Monthly"});
            this.comboBoxInterval.Location = new System.Drawing.Point(83, 213);
            this.comboBoxInterval.Name = "comboBoxInterval";
            this.comboBoxInterval.Size = new System.Drawing.Size(121, 21);
            this.comboBoxInterval.TabIndex = 12;
            this.toolTip1.SetToolTip(this.comboBoxInterval, "Set Interval");
            this.comboBoxInterval.SelectedIndexChanged += new System.EventHandler(this.comboBoxInterval_SelectedIndexChanged);
            // 
            // labelInterval
            // 
            this.labelInterval.AutoSize = true;
            this.labelInterval.Location = new System.Drawing.Point(38, 218);
            this.labelInterval.Name = "labelInterval";
            this.labelInterval.Size = new System.Drawing.Size(45, 13);
            this.labelInterval.TabIndex = 13;
            this.labelInterval.Text = "Interval:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 40);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // ddl
            // 
            this.ddl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl.FormattingEnabled = true;
            this.ddl.Location = new System.Drawing.Point(187, 57);
            this.ddl.Name = "ddl";
            this.ddl.Size = new System.Drawing.Size(121, 21);
            this.ddl.TabIndex = 15;
            this.toolTip1.SetToolTip(this.ddl, "Ticker from Dropdown List takes precedence over textbox");
            this.ddl.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ddl);
            this.groupBox1.Controls.Add(this.labelInterval);
            this.groupBox1.Controls.Add(this.comboBoxInterval);
            this.groupBox1.Controls.Add(this.labelaCandlestickName);
            this.groupBox1.Controls.Add(this.textBoxaCandlestickName);
            this.groupBox1.Controls.Add(this.labelDatePickerTo);
            this.groupBox1.Controls.Add(this.labelDatePickerFrom);
            this.groupBox1.Controls.Add(this.dateTimePickerTo);
            this.groupBox1.Controls.Add(this.dateTimePickerFrom);
            this.groupBox1.Location = new System.Drawing.Point(7, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 281);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // labelHigh
            // 
            this.labelHigh.AutoSize = true;
            this.labelHigh.Location = new System.Drawing.Point(28, 63);
            this.labelHigh.Name = "labelHigh";
            this.labelHigh.Size = new System.Drawing.Size(37, 13);
            this.labelHigh.TabIndex = 7;
            this.labelHigh.Text = "HIGH:";
            // 
            // labelLow
            // 
            this.labelLow.AutoSize = true;
            this.labelLow.Location = new System.Drawing.Point(28, 91);
            this.labelLow.Name = "labelLow";
            this.labelLow.Size = new System.Drawing.Size(35, 13);
            this.labelLow.TabIndex = 8;
            this.labelLow.Text = "LOW:";
            // 
            // labelHighValue
            // 
            this.labelHighValue.AutoSize = true;
            this.labelHighValue.BackColor = System.Drawing.SystemColors.Info;
            this.labelHighValue.Location = new System.Drawing.Point(119, 62);
            this.labelHighValue.Name = "labelHighValue";
            this.labelHighValue.Size = new System.Drawing.Size(23, 13);
            this.labelHighValue.TabIndex = 9;
            this.labelHighValue.Text = "null";
            // 
            // labelLowValue
            // 
            this.labelLowValue.AutoSize = true;
            this.labelLowValue.BackColor = System.Drawing.SystemColors.Info;
            this.labelLowValue.Location = new System.Drawing.Point(119, 92);
            this.labelLowValue.Name = "labelLowValue";
            this.labelLowValue.Size = new System.Drawing.Size(23, 13);
            this.labelLowValue.TabIndex = 10;
            this.labelLowValue.Text = "null";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.labelSumVol);
            this.groupBox2.Controls.Add(this.labelCloseAvg);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblTicker);
            this.groupBox2.Controls.Add(this.labelLowValue);
            this.groupBox2.Controls.Add(this.labelHighValue);
            this.groupBox2.Controls.Add(this.labelLow);
            this.groupBox2.Controls.Add(this.labelHigh);
            this.groupBox2.Location = new System.Drawing.Point(8, 418);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(203, 203);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Result";
            // 
            // lblTicker
            // 
            this.lblTicker.AutoSize = true;
            this.lblTicker.Location = new System.Drawing.Point(119, 35);
            this.lblTicker.Name = "lblTicker";
            this.lblTicker.Size = new System.Drawing.Size(0, 13);
            this.lblTicker.TabIndex = 11;
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(342, 13);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(770, 361);
            this.chart1.TabIndex = 18;
            this.chart1.Text = "chart1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(342, 397);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(770, 180);
            this.dataGridView1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "CLOSE AVG:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "SUM VOL:";
            // 
            // labelCloseAvg
            // 
            this.labelCloseAvg.AutoSize = true;
            this.labelCloseAvg.BackColor = System.Drawing.SystemColors.Info;
            this.labelCloseAvg.Location = new System.Drawing.Point(119, 118);
            this.labelCloseAvg.Name = "labelCloseAvg";
            this.labelCloseAvg.Size = new System.Drawing.Size(23, 13);
            this.labelCloseAvg.TabIndex = 14;
            this.labelCloseAvg.Text = "null";
            // 
            // labelSumVol
            // 
            this.labelSumVol.AutoSize = true;
            this.labelSumVol.BackColor = System.Drawing.SystemColors.Info;
            this.labelSumVol.Location = new System.Drawing.Point(119, 145);
            this.labelSumVol.Name = "labelSumVol";
            this.labelSumVol.Size = new System.Drawing.Size(23, 13);
            this.labelSumVol.TabIndex = 15;
            this.labelSumVol.Text = "null";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(342, 607);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(770, 131);
            this.dataGridView2.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(339, 591);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Closing price greater than Opening price Candlesticks";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Candlesticks within range";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "TICKER:";
            // 
            // stockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 750);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonGetData);
            this.Name = "stockForm";
            this.Text = "Historical Prices";
            this.Load += new System.EventHandler(this.aCandlestickForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Label labelDatePickerFrom;
        private System.Windows.Forms.Label labelDatePickerTo;
        private System.Windows.Forms.Button buttonGetData;
        private System.Windows.Forms.TextBox textBoxaCandlestickName;
        private System.Windows.Forms.Label labelaCandlestickName;
        private System.Windows.Forms.ComboBox comboBoxInterval;
        private System.Windows.Forms.Label labelInterval;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox ddl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelHigh;
        private System.Windows.Forms.Label labelLow;
        private System.Windows.Forms.Label labelHighValue;
        private System.Windows.Forms.Label labelLowValue;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblTicker;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSumVol;
        private System.Windows.Forms.Label labelCloseAvg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}


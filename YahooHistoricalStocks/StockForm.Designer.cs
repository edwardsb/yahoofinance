﻿namespace YahooHistoricalaCandlesticks
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(53, 70);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFrom.TabIndex = 0;
            this.toolTip1.SetToolTip(this.dateTimePickerFrom, "Set Date Range -> Start Date");
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(305, 69);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerTo.TabIndex = 1;
            this.toolTip1.SetToolTip(this.dateTimePickerTo, "Set Date Range -> End Date");
            // 
            // labelDatePickerFrom
            // 
            this.labelDatePickerFrom.AutoSize = true;
            this.labelDatePickerFrom.Location = new System.Drawing.Point(16, 73);
            this.labelDatePickerFrom.Name = "labelDatePickerFrom";
            this.labelDatePickerFrom.Size = new System.Drawing.Size(33, 13);
            this.labelDatePickerFrom.TabIndex = 2;
            this.labelDatePickerFrom.Text = "From:";
            // 
            // labelDatePickerTo
            // 
            this.labelDatePickerTo.AutoSize = true;
            this.labelDatePickerTo.Location = new System.Drawing.Point(277, 74);
            this.labelDatePickerTo.Name = "labelDatePickerTo";
            this.labelDatePickerTo.Size = new System.Drawing.Size(23, 13);
            this.labelDatePickerTo.TabIndex = 3;
            this.labelDatePickerTo.Text = "To:";
            // 
            // buttonGetData
            // 
            this.buttonGetData.Location = new System.Drawing.Point(240, 286);
            this.buttonGetData.Name = "buttonGetData";
            this.buttonGetData.Size = new System.Drawing.Size(74, 28);
            this.buttonGetData.TabIndex = 4;
            this.buttonGetData.Text = "GET DATA";
            this.buttonGetData.UseVisualStyleBackColor = true;
            this.buttonGetData.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxaCandlestickName
            // 
            this.textBoxaCandlestickName.Location = new System.Drawing.Point(90, 29);
            this.textBoxaCandlestickName.Name = "textBoxaCandlestickName";
            this.textBoxaCandlestickName.Size = new System.Drawing.Size(100, 20);
            this.textBoxaCandlestickName.TabIndex = 5;
            this.toolTip1.SetToolTip(this.textBoxaCandlestickName, "Type a Ticker or Select one from DropDown List");
            // 
            // labelaCandlestickName
            // 
            this.labelaCandlestickName.AutoSize = true;
            this.labelaCandlestickName.Location = new System.Drawing.Point(15, 32);
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
            this.comboBoxInterval.Location = new System.Drawing.Point(62, 115);
            this.comboBoxInterval.Name = "comboBoxInterval";
            this.comboBoxInterval.Size = new System.Drawing.Size(121, 21);
            this.comboBoxInterval.TabIndex = 12;
            this.toolTip1.SetToolTip(this.comboBoxInterval, "Set Interval");
            this.comboBoxInterval.SelectedIndexChanged += new System.EventHandler(this.comboBoxInterval_SelectedIndexChanged);
            // 
            // labelInterval
            // 
            this.labelInterval.AutoSize = true;
            this.labelInterval.Location = new System.Drawing.Point(17, 120);
            this.labelInterval.Name = "labelInterval";
            this.labelInterval.Size = new System.Drawing.Size(45, 13);
            this.labelInterval.TabIndex = 13;
            this.labelInterval.Text = "Interval:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(264, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 40);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // ddl
            // 
            this.ddl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl.FormattingEnabled = true;
            this.ddl.Location = new System.Drawing.Point(196, 28);
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
            this.groupBox1.Location = new System.Drawing.Point(7, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 165);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // labelHigh
            // 
            this.labelHigh.AutoSize = true;
            this.labelHigh.Location = new System.Drawing.Point(19, 45);
            this.labelHigh.Name = "labelHigh";
            this.labelHigh.Size = new System.Drawing.Size(37, 13);
            this.labelHigh.TabIndex = 7;
            this.labelHigh.Text = "HIGH:";
            // 
            // labelLow
            // 
            this.labelLow.AutoSize = true;
            this.labelLow.Location = new System.Drawing.Point(19, 77);
            this.labelLow.Name = "labelLow";
            this.labelLow.Size = new System.Drawing.Size(35, 13);
            this.labelLow.TabIndex = 8;
            this.labelLow.Text = "LOW:";
            // 
            // labelHighValue
            // 
            this.labelHighValue.AutoSize = true;
            this.labelHighValue.BackColor = System.Drawing.SystemColors.Info;
            this.labelHighValue.Location = new System.Drawing.Point(91, 44);
            this.labelHighValue.Name = "labelHighValue";
            this.labelHighValue.Size = new System.Drawing.Size(23, 13);
            this.labelHighValue.TabIndex = 9;
            this.labelHighValue.Text = "null";
            // 
            // labelLowValue
            // 
            this.labelLowValue.AutoSize = true;
            this.labelLowValue.BackColor = System.Drawing.SystemColors.Info;
            this.labelLowValue.Location = new System.Drawing.Point(91, 77);
            this.labelLowValue.Name = "labelLowValue";
            this.labelLowValue.Size = new System.Drawing.Size(23, 13);
            this.labelLowValue.TabIndex = 10;
            this.labelLowValue.Text = "null";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTicker);
            this.groupBox2.Controls.Add(this.labelLowValue);
            this.groupBox2.Controls.Add(this.labelHighValue);
            this.groupBox2.Controls.Add(this.labelLow);
            this.groupBox2.Controls.Add(this.labelHigh);
            this.groupBox2.Location = new System.Drawing.Point(9, 255);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(147, 97);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Result";
            // 
            // lblTicker
            // 
            this.lblTicker.AutoSize = true;
            this.lblTicker.Location = new System.Drawing.Point(85, 16);
            this.lblTicker.Name = "lblTicker";
            this.lblTicker.Size = new System.Drawing.Size(0, 13);
            this.lblTicker.TabIndex = 11;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(538, 13);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(471, 449);
            this.chart1.TabIndex = 18;
            this.chart1.Text = "chart1";
            // 
            // stockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 474);
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
            this.ResumeLayout(false);

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
    }
}


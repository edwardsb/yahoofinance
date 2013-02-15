namespace YahooHistoricalStocks
{
    partial class StockForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockForm));
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.labelDatePickerFrom = new System.Windows.Forms.Label();
            this.labelDatePickerTo = new System.Windows.Forms.Label();
            this.buttonGetData = new System.Windows.Forms.Button();
            this.textBoxStockName = new System.Windows.Forms.TextBox();
            this.labelStockName = new System.Windows.Forms.Label();
            this.labelHigh = new System.Windows.Forms.Label();
            this.labelLow = new System.Windows.Forms.Label();
            this.labelHighValue = new System.Windows.Forms.Label();
            this.labelLowValue = new System.Windows.Forms.Label();
            this.comboBoxInterval = new System.Windows.Forms.ComboBox();
            this.labelInterval = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(60, 79);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFrom.TabIndex = 0;
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(365, 80);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerTo.TabIndex = 1;
            // 
            // labelDatePickerFrom
            // 
            this.labelDatePickerFrom.AutoSize = true;
            this.labelDatePickerFrom.Location = new System.Drawing.Point(13, 86);
            this.labelDatePickerFrom.Name = "labelDatePickerFrom";
            this.labelDatePickerFrom.Size = new System.Drawing.Size(41, 13);
            this.labelDatePickerFrom.TabIndex = 2;
            this.labelDatePickerFrom.Text = "FROM:";
            // 
            // labelDatePickerTo
            // 
            this.labelDatePickerTo.AutoSize = true;
            this.labelDatePickerTo.Location = new System.Drawing.Point(334, 86);
            this.labelDatePickerTo.Name = "labelDatePickerTo";
            this.labelDatePickerTo.Size = new System.Drawing.Size(25, 13);
            this.labelDatePickerTo.TabIndex = 3;
            this.labelDatePickerTo.Text = "TO:";
            // 
            // buttonGetData
            // 
            this.buttonGetData.Location = new System.Drawing.Point(262, 202);
            this.buttonGetData.Name = "buttonGetData";
            this.buttonGetData.Size = new System.Drawing.Size(75, 23);
            this.buttonGetData.TabIndex = 4;
            this.buttonGetData.Text = "GET DATA";
            this.buttonGetData.UseVisualStyleBackColor = true;
            this.buttonGetData.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxStockName
            // 
            this.textBoxStockName.Location = new System.Drawing.Point(88, 34);
            this.textBoxStockName.Name = "textBoxStockName";
            this.textBoxStockName.Size = new System.Drawing.Size(100, 20);
            this.textBoxStockName.TabIndex = 5;
            // 
            // labelStockName
            // 
            this.labelStockName.AutoSize = true;
            this.labelStockName.Location = new System.Drawing.Point(13, 37);
            this.labelStockName.Name = "labelStockName";
            this.labelStockName.Size = new System.Drawing.Size(69, 13);
            this.labelStockName.TabIndex = 6;
            this.labelStockName.Text = "Stock Name:";
            // 
            // labelHigh
            // 
            this.labelHigh.AutoSize = true;
            this.labelHigh.Location = new System.Drawing.Point(16, 249);
            this.labelHigh.Name = "labelHigh";
            this.labelHigh.Size = new System.Drawing.Size(37, 13);
            this.labelHigh.TabIndex = 7;
            this.labelHigh.Text = "HIGH:";
            // 
            // labelLow
            // 
            this.labelLow.AutoSize = true;
            this.labelLow.Location = new System.Drawing.Point(16, 281);
            this.labelLow.Name = "labelLow";
            this.labelLow.Size = new System.Drawing.Size(35, 13);
            this.labelLow.TabIndex = 8;
            this.labelLow.Text = "LOW:";
            // 
            // labelHighValue
            // 
            this.labelHighValue.AutoSize = true;
            this.labelHighValue.BackColor = System.Drawing.SystemColors.Info;
            this.labelHighValue.Location = new System.Drawing.Point(88, 248);
            this.labelHighValue.Name = "labelHighValue";
            this.labelHighValue.Size = new System.Drawing.Size(23, 13);
            this.labelHighValue.TabIndex = 9;
            this.labelHighValue.Text = "null";
            // 
            // labelLowValue
            // 
            this.labelLowValue.AutoSize = true;
            this.labelLowValue.BackColor = System.Drawing.SystemColors.Info;
            this.labelLowValue.Location = new System.Drawing.Point(88, 281);
            this.labelLowValue.Name = "labelLowValue";
            this.labelLowValue.Size = new System.Drawing.Size(23, 13);
            this.labelLowValue.TabIndex = 10;
            this.labelLowValue.Text = "null";
            // 
            // comboBoxInterval
            // 
            this.comboBoxInterval.FormattingEnabled = true;
            this.comboBoxInterval.Items.AddRange(new object[] {
            "Daily",
            "Weekly",
            "Monthly"});
            this.comboBoxInterval.Location = new System.Drawing.Point(60, 141);
            this.comboBoxInterval.Name = "comboBoxInterval";
            this.comboBoxInterval.Size = new System.Drawing.Size(121, 21);
            this.comboBoxInterval.TabIndex = 12;
            this.comboBoxInterval.SelectedIndexChanged += new System.EventHandler(this.comboBoxInterval_SelectedIndexChanged);
            // 
            // labelInterval
            // 
            this.labelInterval.AutoSize = true;
            this.labelInterval.Location = new System.Drawing.Point(16, 148);
            this.labelInterval.Name = "labelInterval";
            this.labelInterval.Size = new System.Drawing.Size(42, 13);
            this.labelInterval.TabIndex = 13;
            this.labelInterval.Text = "Interval";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(304, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 40);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // StockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 333);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelInterval);
            this.Controls.Add(this.comboBoxInterval);
            this.Controls.Add(this.labelLowValue);
            this.Controls.Add(this.labelHighValue);
            this.Controls.Add(this.labelLow);
            this.Controls.Add(this.labelHigh);
            this.Controls.Add(this.labelStockName);
            this.Controls.Add(this.textBoxStockName);
            this.Controls.Add(this.buttonGetData);
            this.Controls.Add(this.labelDatePickerTo);
            this.Controls.Add(this.labelDatePickerFrom);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Name = "StockForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Label labelDatePickerFrom;
        private System.Windows.Forms.Label labelDatePickerTo;
        private System.Windows.Forms.Button buttonGetData;
        private System.Windows.Forms.TextBox textBoxStockName;
        private System.Windows.Forms.Label labelStockName;
        private System.Windows.Forms.Label labelHigh;
        private System.Windows.Forms.Label labelLow;
        private System.Windows.Forms.Label labelHighValue;
        private System.Windows.Forms.Label labelLowValue;
        private System.Windows.Forms.ComboBox comboBoxInterval;
        private System.Windows.Forms.Label labelInterval;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


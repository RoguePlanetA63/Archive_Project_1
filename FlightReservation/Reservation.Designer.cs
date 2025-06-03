namespace FlightReservation
{
    partial class Reservation
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
            this.lblReserve = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.YearCmbBox = new System.Windows.Forms.ComboBox();
            this.DayCmbBox = new System.Windows.Forms.ComboBox();
            this.MonthCmbBox = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.lblDateofBirth = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReserve
            // 
            this.lblReserve.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblReserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblReserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReserve.Location = new System.Drawing.Point(12, 151);
            this.lblReserve.Name = "lblReserve";
            this.lblReserve.Size = new System.Drawing.Size(476, 61);
            this.lblReserve.TabIndex = 1;
            this.lblReserve.Text = " Flight Reservation";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.SkyBlue;
            this.lbl1.Location = new System.Drawing.Point(26, 184);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(451, 18);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Please make sure that you fill in the name which is in your passport.";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.lblMonth);
            this.panel1.Controls.Add(this.lblYear);
            this.panel1.Controls.Add(this.lblDay);
            this.panel1.Controls.Add(this.YearCmbBox);
            this.panel1.Controls.Add(this.DayCmbBox);
            this.panel1.Controls.Add(this.MonthCmbBox);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.txtLastName);
            this.panel1.Controls.Add(this.lblLastName);
            this.panel1.Controls.Add(this.lblFirstname);
            this.panel1.Controls.Add(this.lblDateofBirth);
            this.panel1.Controls.Add(this.txtFirstName);
            this.panel1.Controls.Add(this.txtTitle);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Location = new System.Drawing.Point(1, 215);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 266);
            this.panel1.TabIndex = 3;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNext.Location = new System.Drawing.Point(372, 195);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(85, 36);
            this.btnNext.TabIndex = 14;
            this.btnNext.Text = "NEXT";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(25, 153);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(37, 13);
            this.lblMonth.TabIndex = 13;
            this.lblMonth.Text = "Month";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(329, 153);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(29, 13);
            this.lblYear.TabIndex = 12;
            this.lblYear.Text = "Year";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(177, 153);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(26, 13);
            this.lblDay.TabIndex = 11;
            this.lblDay.Text = "Day";
            // 
            // YearCmbBox
            // 
            this.YearCmbBox.BackColor = System.Drawing.Color.AliceBlue;
            this.YearCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.YearCmbBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.YearCmbBox.FormattingEnabled = true;
            this.YearCmbBox.Items.AddRange(new object[] {
            "1900",
            "1901",
            "1902",
            "1903",
            "1904",
            "1905",
            "1906",
            "1907",
            "1908",
            "1909",
            "1910",
            "1911",
            "1912",
            "1913",
            "1914",
            "1915",
            "1916",
            "1917",
            "1918",
            "1919",
            "1920",
            "1921",
            "1922",
            "1923",
            "1924",
            "1925",
            "1926",
            "1927",
            "1928",
            "1929",
            "1930",
            "1931",
            "1932",
            "1933",
            "1934",
            "1935",
            "1936",
            "1937",
            "1938",
            "1939",
            "1940",
            "1941",
            "1942",
            "1943",
            "1944",
            "1945",
            "1946",
            "1947",
            "1948",
            "1949",
            "1950",
            "1951",
            "1952",
            "1953",
            "1954",
            "1955",
            "1956",
            "1957",
            "1958",
            "1959",
            "1960",
            "1961",
            "1962",
            "1963",
            "1964",
            "1965",
            "1966",
            "1967",
            "1968",
            "1969",
            "1970",
            "1971",
            "1972",
            "1973",
            "1974",
            "1975",
            "1976",
            "1977",
            "1978",
            "1979",
            "1980",
            "1981",
            "1982",
            "1983",
            "1984",
            "1985",
            "1986",
            "1987",
            "1988",
            "1989",
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034",
            "2035",
            "2036",
            "2037",
            "2038",
            "2039",
            "2040",
            "2041",
            "2042",
            "2043",
            "2044",
            "2045",
            "2046",
            "2047",
            "2048",
            "2049",
            "2050",
            "2051",
            "2052",
            "2053",
            "2054",
            "2055",
            "2056",
            "2057",
            "2058",
            "2059",
            "2060",
            "2061",
            "2062",
            "2063",
            "2064",
            "2065",
            "2066",
            "2067",
            "2068",
            "2069",
            "2070",
            "2071",
            "2072",
            "2073",
            "2074",
            "2075",
            "2076",
            "2077",
            "2078",
            "2079",
            "2080",
            "2081",
            "2082",
            "2083",
            "2084",
            "2085",
            "2086",
            "2087",
            "2088",
            "2089",
            "2090",
            "2091",
            "2092",
            "2093",
            "2094",
            "2095",
            "2096",
            "2097",
            "2098",
            "2099",
            "2100"});
            this.YearCmbBox.Location = new System.Drawing.Point(332, 129);
            this.YearCmbBox.Name = "YearCmbBox";
            this.YearCmbBox.Size = new System.Drawing.Size(146, 21);
            this.YearCmbBox.TabIndex = 10;
            // 
            // DayCmbBox
            // 
            this.DayCmbBox.BackColor = System.Drawing.Color.AliceBlue;
            this.DayCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DayCmbBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DayCmbBox.FormattingEnabled = true;
            this.DayCmbBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.DayCmbBox.Location = new System.Drawing.Point(180, 129);
            this.DayCmbBox.Name = "DayCmbBox";
            this.DayCmbBox.Size = new System.Drawing.Size(146, 21);
            this.DayCmbBox.TabIndex = 9;
            // 
            // MonthCmbBox
            // 
            this.MonthCmbBox.BackColor = System.Drawing.Color.AliceBlue;
            this.MonthCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MonthCmbBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MonthCmbBox.FormattingEnabled = true;
            this.MonthCmbBox.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "November",
            "December"});
            this.MonthCmbBox.Location = new System.Drawing.Point(28, 129);
            this.MonthCmbBox.Name = "MonthCmbBox";
            this.MonthCmbBox.Size = new System.Drawing.Size(146, 21);
            this.MonthCmbBox.TabIndex = 8;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(25, 71);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Title";
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.AliceBlue;
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastName.Location = new System.Drawing.Point(331, 48);
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(146, 20);
            this.txtLastName.TabIndex = 6;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(328, 71);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 5;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Location = new System.Drawing.Point(177, 71);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(57, 13);
            this.lblFirstname.TabIndex = 4;
            this.lblFirstname.Text = "First Name";
            // 
            // lblDateofBirth
            // 
            this.lblDateofBirth.AutoSize = true;
            this.lblDateofBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateofBirth.Location = new System.Drawing.Point(25, 100);
            this.lblDateofBirth.Name = "lblDateofBirth";
            this.lblDateofBirth.Size = new System.Drawing.Size(92, 16);
            this.lblDateofBirth.TabIndex = 3;
            this.lblDateofBirth.Text = "Date of Birth";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.AliceBlue;
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirstName.Location = new System.Drawing.Point(180, 48);
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(146, 20);
            this.txtFirstName.TabIndex = 2;
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.AliceBlue;
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitle.Location = new System.Drawing.Point(28, 48);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(146, 20);
            this.txtTitle.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(25, 19);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(127, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Passenger Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FlightReservation.Properties.Resources.plane;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(513, 475);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lblReserve);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Reservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ReservationForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblReserve;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.Label lblDateofBirth;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox YearCmbBox;
        private System.Windows.Forms.ComboBox DayCmbBox;
        private System.Windows.Forms.ComboBox MonthCmbBox;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblDay;
    }
}
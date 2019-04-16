namespace WeatherCalculator
{
    partial class Form1
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
            this.inputValues = new System.Windows.Forms.GroupBox();
            this.cboHighTemp = new System.Windows.Forms.ComboBox();
            this.cboLowTemp = new System.Windows.Forms.ComboBox();
            this.cboWindSpeed = new System.Windows.Forms.ComboBox();
            this.cboSkyCondition = new System.Windows.Forms.ComboBox();
            this.btnPost = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.weatherPic = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblHighTemp = new System.Windows.Forms.Label();
            this.lblLowTemp = new System.Windows.Forms.Label();
            this.lblWindSpeed = new System.Windows.Forms.Label();
            this.lblWindChill = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.inputValues.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weatherPic)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputValues
            // 
            this.inputValues.Controls.Add(this.label4);
            this.inputValues.Controls.Add(this.label3);
            this.inputValues.Controls.Add(this.label2);
            this.inputValues.Controls.Add(this.label1);
            this.inputValues.Controls.Add(this.btnPost);
            this.inputValues.Controls.Add(this.cboSkyCondition);
            this.inputValues.Controls.Add(this.cboWindSpeed);
            this.inputValues.Controls.Add(this.cboLowTemp);
            this.inputValues.Controls.Add(this.cboHighTemp);
            this.inputValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputValues.Location = new System.Drawing.Point(41, 23);
            this.inputValues.Name = "inputValues";
            this.inputValues.Size = new System.Drawing.Size(330, 361);
            this.inputValues.TabIndex = 0;
            this.inputValues.TabStop = false;
            this.inputValues.Text = "Input Values";
            // 
            // cboHighTemp
            // 
            this.cboHighTemp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHighTemp.FormattingEnabled = true;
            this.cboHighTemp.Items.AddRange(new object[] {
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
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100"});
            this.cboHighTemp.Location = new System.Drawing.Point(168, 35);
            this.cboHighTemp.Name = "cboHighTemp";
            this.cboHighTemp.Size = new System.Drawing.Size(121, 23);
            this.cboHighTemp.TabIndex = 0;
            // 
            // cboLowTemp
            // 
            this.cboLowTemp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLowTemp.FormattingEnabled = true;
            this.cboLowTemp.Items.AddRange(new object[] {
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
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100"});
            this.cboLowTemp.Location = new System.Drawing.Point(168, 88);
            this.cboLowTemp.Name = "cboLowTemp";
            this.cboLowTemp.Size = new System.Drawing.Size(121, 23);
            this.cboLowTemp.TabIndex = 1;
            // 
            // cboWindSpeed
            // 
            this.cboWindSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboWindSpeed.FormattingEnabled = true;
            this.cboWindSpeed.Items.AddRange(new object[] {
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
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100"});
            this.cboWindSpeed.Location = new System.Drawing.Point(168, 146);
            this.cboWindSpeed.Name = "cboWindSpeed";
            this.cboWindSpeed.Size = new System.Drawing.Size(121, 23);
            this.cboWindSpeed.TabIndex = 2;
            // 
            // cboSkyCondition
            // 
            this.cboSkyCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSkyCondition.FormattingEnabled = true;
            this.cboSkyCondition.Items.AddRange(new object[] {
            "Sunny",
            "Cloudy",
            "Rainy"});
            this.cboSkyCondition.Location = new System.Drawing.Point(168, 197);
            this.cboSkyCondition.Name = "cboSkyCondition";
            this.cboSkyCondition.Size = new System.Drawing.Size(121, 23);
            this.cboSkyCondition.TabIndex = 3;
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(214, 245);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(75, 23);
            this.btnPost.TabIndex = 4;
            this.btnPost.Text = "Post";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Predicted High Temp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Predicted Low Temp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Wind Speed";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sky Condition";
            // 
            // weatherPic
            // 
            this.weatherPic.Location = new System.Drawing.Point(221, 26);
            this.weatherPic.Name = "weatherPic";
            this.weatherPic.Size = new System.Drawing.Size(132, 103);
            this.weatherPic.TabIndex = 1;
            this.weatherPic.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblWindChill);
            this.groupBox1.Controls.Add(this.lblWindSpeed);
            this.groupBox1.Controls.Add(this.lblLowTemp);
            this.groupBox1.Controls.Add(this.lblHighTemp);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.weatherPic);
            this.groupBox1.Location = new System.Drawing.Point(386, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 394);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Today\'s Forcast";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "High Temperature";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Low Temperature";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Wind Speed";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(252, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Sky Condition";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(252, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Wind Chill";
            // 
            // lblHighTemp
            // 
            this.lblHighTemp.AutoSize = true;
            this.lblHighTemp.Location = new System.Drawing.Point(72, 79);
            this.lblHighTemp.Name = "lblHighTemp";
            this.lblHighTemp.Size = new System.Drawing.Size(41, 13);
            this.lblHighTemp.TabIndex = 15;
            this.lblHighTemp.Text = "label10";
            // 
            // lblLowTemp
            // 
            this.lblLowTemp.AutoSize = true;
            this.lblLowTemp.Location = new System.Drawing.Point(72, 188);
            this.lblLowTemp.Name = "lblLowTemp";
            this.lblLowTemp.Size = new System.Drawing.Size(41, 13);
            this.lblLowTemp.TabIndex = 16;
            this.lblLowTemp.Text = "label11";
            // 
            // lblWindSpeed
            // 
            this.lblWindSpeed.AutoSize = true;
            this.lblWindSpeed.Location = new System.Drawing.Point(72, 282);
            this.lblWindSpeed.Name = "lblWindSpeed";
            this.lblWindSpeed.Size = new System.Drawing.Size(41, 13);
            this.lblWindSpeed.TabIndex = 17;
            this.lblWindSpeed.Text = "label12";
            // 
            // lblWindChill
            // 
            this.lblWindChill.AutoSize = true;
            this.lblWindChill.Location = new System.Drawing.Point(272, 282);
            this.lblWindChill.Name = "lblWindChill";
            this.lblWindChill.Size = new System.Drawing.Size(41, 13);
            this.lblWindChill.TabIndex = 18;
            this.lblWindChill.Text = "label13";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(160, 402);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(170, 24);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.inputValues);
            this.Name = "Form1";
            this.Text = "Form1";
            this.inputValues.ResumeLayout(false);
            this.inputValues.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weatherPic)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox inputValues;
        private System.Windows.Forms.ComboBox cboHighTemp;
        private System.Windows.Forms.ComboBox cboLowTemp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.ComboBox cboSkyCondition;
        private System.Windows.Forms.ComboBox cboWindSpeed;
        private System.Windows.Forms.PictureBox weatherPic;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblLowTemp;
        private System.Windows.Forms.Label lblHighTemp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblWindChill;
        private System.Windows.Forms.Label lblWindSpeed;
        private System.Windows.Forms.Button btnExit;
    }
}


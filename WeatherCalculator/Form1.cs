using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherCalculator
{
    public partial class Form1 : Form
    {
        private Weather _weather = new Weather();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();// this closes the weather app
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            loadWeatherObjectFromForm();
            loadFormFromWeatherObject();
        }

        /// <summary>
        /// copies values from screen into weather object
        /// </summary>
        private void loadWeatherObjectFromForm()
        {
            _weather.highTemp = Convert.ToInt32(cboHighTemp.SelectedItem.ToString());
            _weather.lowTemp = Convert.ToInt32(cboLowTemp.SelectedItem.ToString());
            _weather.windSpeed = Convert.ToInt32(cboWindSpeed.SelectedItem.ToString());
            _weather.skyCondition = cboSkyCondition.SelectedItem.ToString();
        }

   
        /// <summary>
        /// loads right side of form with values from object
        /// </summary>
        private void loadFormFromWeatherObject()
        {
          lblHighTemp.Text =   _weather.highTemp.ToString();
          lblLowTemp.Text =   _weather.lowTemp.ToString();
            //_weather.windSpeed = Convert.ToInt32(cboWindSpeed.SelectedItem.ToString());
            lblWindSpeed.Text = _weather.windSpeed.ToString();
            lblWindChill.Text = _weather.windChill.ToString();
            weatherPic.Load(_weather.skyUrl);
        }
    }
}

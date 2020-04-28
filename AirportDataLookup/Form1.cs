/*
	Project Name: Airport Lookup
	Written By: Thomas Ruigrok
    
    Copyright 2019-2020 By Computery. Some Rights Reserved
    
	This Source Code Form is subject to the terms of the Mozilla Public
    License, v. 2.0. If a copy of the MPL was not distributed with this
    file, You can obtain one at http://mozilla.org/MPL/2.0/.
    This Source Code Form is "Incompatible With Secondary Licenses", as
    defined by the Mozilla Public License, v. 2.0.
*/
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Airports;

namespace AirportDataLookup
{
    public partial class Form1 : Form
    {
        private const string ICAO_API_KEY = "[Redacted]";
        private const string GMAPS_API_KEY = "[Redacted]";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TxtBox_CodeType.SelectedIndex = 0;
            TxtBox_AirportCode.Focus();
        }

        private void aboutAirportLookupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
            about.BringToFront();
            about.Focus();

        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="System.IO.InvalidDataException"> Thrown when requested Code is invalid format for requested code type</exception>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Search_Click(object sender, EventArgs e)
        {
            bool valid = true;
            AirportInfo airportInfo = new AirportInfo(ICAO_API_KEY);
            Airport airportData;
            string JsonData = "";

            //Disable alternate inputs as it would throw a NotImplementedException otherwize
            if(this.TxtBox_CodeType.SelectedIndex != 0)
            {
                return;
            }

            switch (this.TxtBox_CodeType.SelectedIndex)
            {
                case 0:
                    {
                        JsonData = airportInfo.Find_By_ICAO(TxtBox_AirportCode.Text);
                        break;
                    }
                case 1:
                    {
                        JsonData = airportInfo.Find_By_IATA(TxtBox_AirportCode.Text);
                        break;
                    }
                case 2:
                    {
                        JsonData = airportInfo.Find_By_Lid(TxtBox_AirportCode.Text, "TC");
                        break;
                    }
                case 3:
                    {
                        JsonData = airportInfo.Find_By_Lid(TxtBox_AirportCode.Text, "FAA");
                        break;
                    }
                default:
                    {
                        MessageBox.Show("Invalid Code Type Selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        valid = false;
                        break;
                    }
            }
            
            if(valid)
            {
                airportData = new Airport(JsonData);

                PopulateResults(airportData);
            }

        }

        private void PopulateResults(Airport pAirport)
        {
            TxtBox_AirportName.Text = pAirport.ToString();

            TxtBox_Region.Text = pAirport.Region;

            string airportCountry = pAirport.CountryCode + " - " + pAirport.Country;

            TxtBox_AirportCountry.Text = airportCountry;

            DownloadMapsImage(pAirport);

        }

        private void DownloadMapsImage(Airport pAirport)
        {
            //Remove Spaces from location string using Regex
            string location = Regex.Replace(pAirport.Location, @"s", "");

            String url = "https://maps.googleapis.com/maps/api/staticmap?center=" + location + "&zoom=13&size=266x135&key=" + GMAPS_API_KEY;

            pictureBox2.LoadAsync(url);
        }
    }
}

/*
 * This work is licensed under a
 * Creative Commons Attribution-NonCommercial-ShareAlike 4.0
 * International License.
 * 
 * Learn More: https://creativecommons.org/licenses/by-nc-sa/4.0/
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Device.Location;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.IO;

namespace AirportDataLookup
{
    /*
     "Terr_code": "CY",
    "State_Name": "CANADA",
    "ICAO_Code": "CYOW",
    "AFTN": "",
    "Location_Name": "OTTAWA/MACDONALD-CARTIER INTL, ON",
    "Lat": "45:19:2100N",
    "Long": "075:40:0900W",
    "Latitude": 45.322500000000005,
    "Longitude": -75.66916666666667,
    "codcoun": "CYCanad",
    "IATA_Code": "YOW",
    "ctry_code": "CAN"
    */
    class Airport
    {
        private string terr_code;
        private string ICAO;
        private GeoCoordinate location;
        private string IATA;
        private string ctry_code;

        //For Future use
        private string tC_Lid = "";
        private string fAA_Lid = "";
        private bool hasTC_LID = false;
        private bool hasFAA_LID = false;

        public Airport(string JSONData)
        {
            //MessageBox.Show(JSONData);
            JSONData = JSONData.Replace("[", String.Empty);
            JSONData = JSONData.Replace("]", String.Empty);
            
            if(JSONData.Length > 0)
            {
                dynamic parsedData = JObject.Parse(JSONData);

                Region = parsedData.Terr_code;
                Country = parsedData.State_Name;
                ICAOcode = parsedData.ICAO_Code;
                Aftn = parsedData.AFTN;
                Name = parsedData.Location_Name;

                string locationStr = parsedData.Latitude + "," + parsedData.Longitude;
                Location = locationStr;

                CodeCoun = parsedData.codcoun;
                IATAcode = parsedData.IATA_Code;
                CountryCode = parsedData.ctry_code;
            }
            else
            {
                MessageBox.Show("Airport Not Found");
            }
            


        }

        //Properties
        public string Region
        {
            get
            {
                return terr_code;
            }

            set
            {
                if (value.Length == 2)
                {
                    terr_code = value;
                }
                else
                {
                    string message = "Invalid Region Specifier: " + value;
                    throw new InvalidDataException(message);
                }
            }
        }
        public string Country { get; set; }
        public string ICAOcode
        {
            get
            {
                return ICAO;
            }

            set
            {
                if(value.Length == 4)
                {
                    ICAO = value;
                }
                else
                {
                    string message = "ICAO Codes must be 4 Characters long";
                    throw new InvalidDataException(message);
                }

            }
        }
        public string Aftn { get; set; }
        public string Name { get; set; }
        public string Location
        {
            get
            {
                return location.ToString();
            }

            set
            {
                int totalParams = 0;
                string[] lat_long = value.Split(',');
                double[] lat_long_double = new double[2];

                foreach (string str in lat_long)
                {
                    lat_long_double[totalParams] = Convert.ToDouble(lat_long[totalParams]);
                    totalParams += 1;
                }

                if(totalParams == 2)
                {
                    location = new GeoCoordinate(lat_long_double[0], lat_long_double[1]);
                }
                else if(totalParams == 3)
                {
                    location = new GeoCoordinate(lat_long_double[0], lat_long_double[1], lat_long_double[2]);
                }
                else
                {
                    location = new GeoCoordinate();
                }
            }
        }
        public string CodeCoun { get; set; }
        public string IATAcode
        {
            get
            {
                return IATA;
            }

            set
            {
                if (value.Length == 3)
                {
                    IATA = value;
                }
                else
                {
                    string message = "IATA Codes must be 3 Characters long";
                    throw new InvalidDataException(message);
                }
            }
        }
        public string CountryCode
        {
            get
            {
                return ctry_code;
            }
            set
            {
                if(value.Length == 3)
                {
                    ctry_code = value;
                }
                else
                {
                    string message = "Invalid Country Code";
                    throw new InvalidDataException(message);
                }
            }
        }
        
        //For future use
        public bool HasTC_LID
        {
            get
            {
                return hasTC_LID;
            }
            set
            {
                hasTC_LID = value;
            }
        }
        public bool HasDAA_LID
        {
            get
            {
                return hasFAA_LID;
            }
            set
            {
                hasFAA_LID = value;
            }
        }

        //Overide toString
        public override string ToString()
        {
            StringBuilder airport = new StringBuilder();
            airport.Append(Name);
            AppendCodes(ref airport);

            return airport.ToString();
        }

        private void AppendCodes(ref StringBuilder builder)
        {
            string startStr = Environment.NewLine + "(";
            StringBuilder codeLine = new StringBuilder(startStr);

            //Check if airport has IATA Code
            if (IATA != "")
            {
                string str = " IATA: " + IATA;
                codeLine.Append(str);
            }

            //Check if airport has ICAO Code
            if(ICAO != "")
            {
                //Check if comma is needed
                AppendComma(ref codeLine);

                string str = " ICAO: " + ICAO;
                codeLine.Append(str);
            }
            //string codeLine = " - (IATA: " + IATA + ", ICAO: " + ICAO + ") ";

            if (hasTC_LID == true)
            {
                //Check if comma is needed
                AppendComma(ref codeLine);

                string str = "TC LID: " + tC_Lid;
                codeLine.Append(str);
            }

            if(hasFAA_LID == true)
            {
                //Check if commma is needed
                AppendComma(ref codeLine);

                string str = " FAA LID: " + fAA_Lid;
                codeLine.Append(str);
            }

            //End Of LINE
            codeLine.Append(")");

            //Decide if we are adding the codeline or not
            if(codeLine.ToString().Length < 3)
            {
                codeLine.Clear();
            }
            else
            {
                builder.Append(codeLine);
            }
        }

        //Decides if a comma is needed in the codeline
        private void AppendComma(ref StringBuilder builder)
        {
            if (builder.ToString().Length > 1)
            {
                builder.Append(',');
            }
        }
    }
}

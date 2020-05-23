using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Timers;

namespace WcfServiceLibrary
{
    public class Service1 : IService1
    {
        //private Cache cache = new Cache();
        private string apiKey = "63083ad99eacfd753e9e2eda682406279ba2606e";

        /*public List<Composite_Stations> GetInformation(string contract)
        {
            return cache.GetDataForContract(contract);
        }*/

        public List<Composite_Cities> GetContracts()
        {
            OperationContext current = OperationContext.Current;

            DateTime reqTime = DateTime.Now;
            WebRequest request = WebRequest.Create("https://api.jcdecaux.com/vls/v1/contracts" + "?apiKey=" + apiKey);
            // If required by the server, set the credentials.
            // request.Credentials = CredentialCache.DefaultCredentials;
            // Get the response.
            WebResponse response = request.GetResponse();
            // Display the status.
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access
            StreamReader reader = new StreamReader(dataStream);
            // Read the content. string
            string responseFromServer = reader.ReadToEnd();
            // Display the content.
            Console.WriteLine(responseFromServer);
            reader.Close();
            response.Close();
            return JsonConvert.DeserializeObject<List<Composite_Cities>>(responseFromServer);
        }

        public List<Composite_Stations> GetCityStations(string cityStations)
        {
            if (Cache.isEmpty) {
                OperationContext current = OperationContext.Current;

                DateTime reqTime = DateTime.Now;
                WebRequest request = WebRequest.Create("https://api.jcdecaux.com/vls/v1/stations?contract=" + cityStations + "&apiKey=" + apiKey);
                WebResponse response = request.GetResponse();

                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                JArray ja = JArray.Parse(responseFromServer);
                List<Composite_Stations> stations = new List<Composite_Stations>();
                for (int i = 0; i < ja.Count; i++)
                {
                    Composite_Stations station = new Composite_Stations();
                    Position position = new Position();
                    station.Position = position;
                    position.Lat = (double)JObject.Parse(ja[i]["position"].ToString())["lat"];
                    position.Lng = (double)JObject.Parse(ja[i]["position"].ToString())["lng"];
                    station.Available_bikes = (int)ja[i]["available_bikes"];
                    station.Available_bike_stands = (int)ja[i]["available_bike_stands"];
                    stations.Add(station);
                }
                Cache.SetJCDCacheStations(ja, cityStations);
                reader.Close();
                response.Close();
                return stations;
                    }
       
            else
                return Cache.getJCDCacheStations();
        }



        internal static class Cache
        {
            private static Timer t;
            public static bool isEmpty = true;
            public static string cityName = "";
            static List<Composite_Stations> stations = new List<Composite_Stations>();
            public static List<Composite_Stations> getJCDCacheStations()
            {
                return stations;
            }


            public static void SetJCDCacheStations(JArray ja, string city)
            {
                cityName = city;
                for (int i = 0; i < ja.Count; i++)
                {
                    Composite_Stations station = new Composite_Stations();
                    Position position = new Position();
                    position.Lat = (double)JObject.Parse(ja[i]["position"].ToString())["lat"];
                    position.Lng = (double)JObject.Parse(ja[i]["position"].ToString())["lng"];
                    station.Name = (string)ja[i]["name"];
                    station.Position = position;
                    station.Available_bikes = (int)ja[i]["available_bikes"];
                    station.Available_bike_stands = (int)ja[i]["available_bike_stands"];
                    stations.Add(station);
                }
                isEmpty = false;
                SetTimer();


            }

            private static void SetTimer()
            {
                t = new Timer(10000);
                t.AutoReset = false;
                t.Enabled = true;
                t.Elapsed += TimerFinish;
            }

            private static void TimerFinish(object o, ElapsedEventArgs e)
            {
                ClearJCDCacheStations();
                t.Stop();
                t.Dispose();
            }

            public static void ClearJCDCacheStations()
            {
                isEmpty = true;
                cityName = "";
                stations.Clear();
            }

        }
    }
}

        
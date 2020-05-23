using MapService.ServiceReference1;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MapService
{
    public class Service1 : IService1
    {
        private Service1Client service1Client;
        private string apiKey = "AIzaSyAGHfrUxm3Z186Eh8e4zquiTBruEqygKmU";

        public Position GetLocation(string address)
        {
            string[] myAddress;
            myAddress = address.Split(' ');
            string answer = "";
            foreach (string i in myAddress)
            {
                answer = answer + i + "+";
            }
            answer = answer.Substring(0, answer.Length - 1);
            WebRequest request = WebRequest.Create("https://maps.googleapis.com/maps/api/geocode/json?address=" + answer + "&key=" + apiKey);
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            reader.Close();
            response.Close();
            JObject temp = JObject.Parse(responseFromServer);
            JArray tempArr = JArray.Parse(temp["results"].ToString());
            Position position = new Position();
            position.Lat = (double)tempArr[0]["geometry"]["location"]["lat"];
            position.Lng = (double)tempArr[0]["geometry"]["location"]["lng"];
            return position;
        }



        public Position FindNearestStationPosition(string address, string contract)
        {
            service1Client = new Service1Client();
            Position location = GetLocation(address);
            double lat = location.Lat;
            double lng = location.Lng;
            List<Composite_MyStation> stations = new List<Composite_MyStation>();
            foreach (Composite_Stations i in service1Client.GetCityStations(contract))
            {
                Composite_MyStation myStation = new Composite_MyStation();
                myStation.Name = i.Name;
                myStation.Available_bikes = i.Available_bikes;
                myStation.Contract_name = i.Contract_name;
                double mylat = i.Position.Lat;
                double mylng = i.Position.Lng;
                Position p = new Position();
                p.Lat = mylat;
                p.Lng = mylng;
                myStation.Position = p;
                double myDistance = Math.Sqrt((lat - mylat) * (lat - mylat) + (lng - mylng) * (lng - mylng));
                myStation.Distance = myDistance;
                stations.Add(myStation);
            }
            GFG gfg = new GFG();
            stations.Sort(gfg);
            Position position = new Position();
            foreach (Composite_MyStation i in stations)
            {
                if (i.Available_bikes > 0)
                {
                    position.Lat = i.Position.Lat;
                    position.Lng = i.Position.Lng;
                    //nearestStationInfomation = "Nearest Station Name:" + i.Name + "\nAvailable bikes:" + i.Available_bikes;
                    //nearestStationInfomation = "Nearest Station Name:";
                    return position;
                }
            }
            return null;
        }
        /*public string NearestStationInformation()
        {
            return nearestStationInfomation;
        }*/
        
        public Position FindNearestDestinationStationPosition(string address, string contract)
        {
            service1Client = new Service1Client();
            Position location = GetLocation(address);
            double lat = location.Lat;
            double lng = location.Lng;
            List<Composite_MyStation> stations = new List<Composite_MyStation>();
            foreach (ServiceReference1.Composite_Stations i in service1Client.GetCityStations(contract))
            {
                Composite_MyStation myStation = new Composite_MyStation();
                myStation.Name = i.Name;
                myStation.Available_bikes = i.Available_bikes;
                myStation.Available_bike_stands = i.Available_bike_stands;
                myStation.Contract_name = i.Contract_name;
                double mylat = i.Position.Lat;
                double mylng = i.Position.Lng;
                Position po = new Position();
                po.Lat = mylat;
                po.Lng = mylng;
                myStation.Position = po;
                double myDistance = Math.Sqrt((lat - mylat) * (lat - mylat) + (lng - mylng) * (lng - mylng));
                myStation.Distance = myDistance;
                stations.Add(myStation);
            }
            GFG gfg = new GFG();
            stations.Sort(gfg);
            Position position = new Position();
            foreach (Composite_MyStation i in stations)
            {
                if (i.Available_bike_stands != 0)
                {
                    position.Lat = i.Position.Lat;
                    position.Lng = i.Position.Lng;
                    //nearestDestinationStationInformation = "Nearest Destination Station Name:" + i.Name + "\nAvailable bikes:" + i.Available_bikes;
                    //nearestStationInfomation = "Nearest Destination Station Name:";
                    return position;
                }
            }
            return null;
        }

        /*public string NearestDestinationStationInformation()
        {
            return nearestDestinationStationInformation;
        }*/

        public List<Position> FindRoute(string contract, string startPoint, string endPoint)
        {
            List<Position> positions = new List<Position>();
            Position startLocation = GetLocation(startPoint);
            positions.Add(startLocation);
            Position startStation = FindNearestStationPosition(startPoint, contract);
            positions.Add(startStation);
            Position endStation = FindNearestDestinationStationPosition(endPoint, contract);
            positions.Add(endStation);
            Position endLocation = GetLocation(endPoint);
            positions.Add(endLocation);
            return positions;
        }


    }
    class GFG : IComparer<Composite_MyStation>
    {
        public int Compare(Composite_MyStation x, Composite_MyStation y)
        {
            if (x.Distance == 0 || y.Distance == 0)
            {
                return 0;
            }
            return x.Distance.CompareTo(y.Distance);

        }
    }
}

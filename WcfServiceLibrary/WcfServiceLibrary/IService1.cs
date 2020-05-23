using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceLibrary
{
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        List<Composite_Cities> GetContracts();

        [OperationContract]

        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped,
            UriTemplate = "GetContractStations/{cityStations}")]
        List<Composite_Stations> GetCityStations(string cityStations);

        // TODO: 在此添加您的服务操作
    }


    [DataContract]
    public class Composite_Cities
    {
        string name;
        [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        List<string> cities;
        [DataMember]
        public List<string> Cities
        {
            get { return cities; }
            set { cities = value; }
        }

        string country_code;
        [DataMember]
        public string Country_code
        {
            get { return country_code; }
            set { country_code = value; }
        }

        public override string ToString()
        {
            return name + " [" + country_code + "]";
        }
    }

    [DataContract]
    public class Composite_Stations
    {
        int number { get; set; }
        [DataMember]
        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        string contract_name { get; set; }
        [DataMember]
        public string Contract_name
        {
            get { return contract_name; }
            set { contract_name = value; }
        }

        string name { get; set; }
        [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        string address { get; set; }
        [DataMember]
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        Position position { get; set; }
        [DataMember]
        public Position Position
        {
            get { return position; }
            set { position = value; }
        }

        bool banking { get; set; }
        [DataMember]
        public bool Banking
        {
            get { return banking; }
            set { banking = value; }
        }

        bool bonus { get; set; }
        [DataMember]
        public bool Bonus
        {
            get { return bonus; }
            set { bonus = value; }
        }

        string status { get; set; }
        [DataMember]
        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        int bike_stands { get; set; }
        [DataMember]
        public int Bike_stands
        {
            get { return bike_stands; }
            set { bike_stands = value; }
        }

        int available_bike_stands { get; set; }
        [DataMember]
        public int Available_bike_stands
        {
            get { return available_bike_stands; }
            set { available_bike_stands = value; }
        }

        int available_bikes { get; set; }
        [DataMember]
        public int Available_bikes
        {
            get { return available_bikes; }
            set { available_bikes = value; }
        }

        string last_update { get; set; }
        [DataMember]
        public string Last_update
        {
            get { return last_update; }
            set { last_update = value; }
        }
    }

    [DataContract]
    public class Position
    {
        double lat;
        [DataMember]
        public double Lat
        {
            get { return lat; }
            set { lat = value; }
        }

        double lng;
        [DataMember]
        public double Lng
        {
            get { return lng; }
            set { lng = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MapService
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        Position GetLocation(string address);
        [OperationContract]
        Position FindNearestStationPosition(string address, string contract);
        [OperationContract]
        Position FindNearestDestinationStationPosition(string address, string contract);
        [OperationContract]
        List<Position> FindRoute(string contract, string startPoint, string endPoint);
        // TODO: 在此添加您的服务操作
        /*[OperationContract]
        string NearestStationInformation();
        [OperationContract]
        string NearestDestinationStationInformation();*/
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

    public class Composite_MyStation
    {
        double distance { get; set; }
        [DataMember]
        public double Distance
        {
            get { return distance; }
            set { distance = value; }
        }

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

    }
}

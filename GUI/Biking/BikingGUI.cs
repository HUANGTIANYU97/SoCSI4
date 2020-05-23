using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System;
using System.IO;
using System.Net;
using System.Text;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using Biking.ServiceReference1;
using Biking.ServiceReference2;

namespace Biking
{
    public partial class BikingGUI : Form
    {
        private ServiceReference1.Service1Client service1Client1;
        private ServiceReference2.Service1Client service1Client2;
        public BikingGUI()
        {
            /*InitializeComponent();
            WebRequest request = WebRequest.Create("https://api.jcdecaux.com/vls/v1/contracts?&apiKey=63083ad99eacfd753e9e2eda682406279ba2606e");
            // If required by the server, set the credentials.
            // request.Credentials = CredentialCache.DefaultCredentials;
            // Get the response.
            WebResponse response = request.GetResponse();
            // Display the status.
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content. string
            String responseFromServer = reader.ReadToEnd();
            // Display the content.
            Console.WriteLine(responseFromServer);
            JArray ja = (JArray)JsonConvert.DeserializeObject(responseFromServer);
            ListBox cb = this.CityList;
            //this.richTextBox1.Text = "Hello, please enter or select a city and a station.";
            for (int i = 0; i < ja.Count; i++)
            {
                cb.Items.Add(ja[i]["name"].ToString());
            }
            reader.Close();
            response.Close();*/
            InitializeComponent();
            service1Client1 = new ServiceReference1.Service1Client();
            service1Client2 = new ServiceReference2.Service1Client();
            foreach (Composite_Cities i in service1Client1.GetContracts())
            {
                this.CityList.Items.Add(i.Name);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CityList_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Departure_TextChanged(object sender, EventArgs e)
        {


        }

        private void Destination_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string city = "";
            string departure = "";
            string destination = "";
            string address = "";
            city = this.CityList.SelectedItem.ToString();
            departure = this.Departure.Text;
            destination = this.Destination.Text;

            try
            {
                ServiceReference2.Position[] positionList = service1Client2.FindRoute(city, departure, destination);
                address = "https://www.google.com/maps/dir/";
                foreach (ServiceReference2.Position i in positionList)
                {
                    address = address + i.Lat.ToString() + "," + i.Lng.ToString() + "/";
                }
                Map.Navigate(address);
                //service1Client2 = new ServiceReference2.Service1Client();
                //string info = service1Client2.NearestStationInformation() + "\n" + service1Client2.NearestDestinationStationInformation();
                //richTextBox1.Text = info;
                //richTextBox1.Text = "111";
            }
            catch (Exception err)
            {
                MessageBox.Show("Fail: " + err.ToString());

            }
        }

        private void Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1.Choose the city where you are.\n" +
                "2.Enter your departure and destinaton.\n" +
                "3.Click the search button to get the route.\n" +
                "4.Click the monitor button to see the monitoring functionnalities.\n" +
                "If you have any questions, you can contact me with e-mail:huangtianyu97@gmail.com\n","Help"
           );
        }

        private void Map_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void BikingGUI_Load(object sender, EventArgs e)
        {

        }
    }
}

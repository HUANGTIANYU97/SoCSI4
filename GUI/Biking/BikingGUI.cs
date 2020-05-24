﻿using System;
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
        private ServiceReference1.Service1Client service1ClientJCD;
        private ServiceReference2.Service1Client service1ClientGoogle;
        private ServiceReference3.Service1Client service1ClientMonitor;
        //private int number = 0;
        private string period = "";
        private int periodInt = -1;
        private int ifCurrentHour = -1;

        public BikingGUI()
        {
            InitializeComponent();
            service1ClientJCD = new ServiceReference1.Service1Client();
            service1ClientGoogle = new ServiceReference2.Service1Client();
            service1ClientMonitor = new ServiceReference3.Service1Client();
            int currentHour1 = DateTime.Now.Hour;
            service1ClientMonitor.UpdateNumberClientRequests(currentHour1);
            foreach (Composite_Cities i in service1ClientJCD.GetContracts())
            {
                this.CityList.Items.Add(i.Name);
            }
            ComboBox cbPeriod = this.comboBox2;
            for(int i = 0;i <= 23; i++)
            {
                period = i + ":00-" + (i + 1) + ":00";
                cbPeriod.Items.Add(period);
            }

            int currentHour2 = DateTime.Now.Hour;
            if (ifCurrentHour != currentHour2)
            {
                ifCurrentHour = currentHour2;
                service1ClientMonitor.UpdateNumberClients(currentHour2);
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
            city = this.CityList.Text;
            if (city.Equals("")){
                MessageBox.Show("Please choose a city!");
                return;
            }
            departure = this.Departure.Text;
            destination = this.Destination.Text;
            try
            {
                int currentHour = DateTime.Now.Hour;
                service1ClientMonitor.UpdateNumberClientRequests(currentHour);
                ServiceReference2.Position[] positionList = service1ClientGoogle.FindRoute(city, departure, destination);
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int currentHour = DateTime.Now.Hour;
            if (ifCurrentHour != currentHour)
            {
                ifCurrentHour = currentHour;
                service1ClientMonitor.UpdateNumberClients(currentHour);
            }
            if (periodInt == -1) {
                this.richTextBox1.Text = "Please choose a period";
                return;
            }
            string monitorMessage = "";
            string numberClientsLabel = "number of clients in this period: ";
            string numberClientRequestsLabel = "number of clients requests in this period: ";
            string currenAverageDelayLabel = "current average delay: ";
            string numberRequestsVelibLabel = "number of requests Velib in this period: ";
            string numberRequestsGoogleLabel = "number of requests Google Map in this period: ";
            string numberClients = "\n";
            string numberClientRequests = "\n";
            string currenAverageDelay = "\n";
            string numberRequestsVelib = "\n";
            string numberRequestsGoogle = "\n";
            //service1Client3.UpdateCurrentAverageDelay(number);
            //number++;
            //Console.WriteLine(number);
            numberClients = service1ClientMonitor.GetNumberClients(periodInt) + numberClients;
            numberClientRequests = service1ClientMonitor.GetNumberClientRequests(periodInt) + numberClientRequests;
            currenAverageDelay = service1ClientMonitor.GetCurrentAverageDelay() + "s" + currenAverageDelay;
            numberRequestsVelib = service1ClientMonitor.GetNumberRequestsVelib(periodInt) + numberRequestsVelib;
            numberRequestsGoogle = service1ClientMonitor.GetNumberRequestsGoogle(periodInt) + numberRequestsGoogle;


            monitorMessage = numberClientsLabel + numberClients
                + numberClientRequestsLabel + numberClientRequests
                + currenAverageDelayLabel + currenAverageDelay
                + numberRequestsVelibLabel + numberRequestsVelib
                + numberRequestsGoogleLabel + numberRequestsGoogle;


            this.richTextBox1.Text = monitorMessage;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            period = this.comboBox2.Text;
            if (period.Substring(1, 1).Equals(":"))
            {
                periodInt = int.Parse(period.Substring(0, 1));
            }
            else
            {
                periodInt = int.Parse(period.Substring(0, 2));
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


    }
}

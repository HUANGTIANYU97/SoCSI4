using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MonitorForm
{
    public partial class MonitorGUI : Form
    {
        private ServiceReference1.Service1Client service1ClientMonitor;
        private string period = "";
        private int periodInt = -1;
        public MonitorGUI()
        {
            InitializeComponent();
            service1ClientMonitor = new ServiceReference1.Service1Client();
            ComboBox cbPeriod = this.comboBox1;
            for (int i = 0; i <= 23; i++)
            {
                period = i + ":00-" + (i + 1) + ":00";
                cbPeriod.Items.Add(period);
            }

            int currentHour2 = DateTime.Now.Hour;
            /*if (ifCurrentHour != currentHour2)
            {
                ifCurrentHour = currentHour2;
                service1ClientMonitor.UpdateNumberClients(currentHour2);
            }*/
            InitChart();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1.Choose a period.\n" +
                "2.Click the <show all the monitering information> button to see the monitoring functionnalities.\n" +
                "2.Click the <update the chart> button to update the chart data.\n" +
                "If you have any questions, you can contact me with e-mail:huangtianyu97@gmail.com\n", "Help"
           );
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            period = this.comboBox1.Text;
            if (period.Substring(1, 1).Equals(":"))
            {
                periodInt = int.Parse(period.Substring(0, 1));
            }
            else
            {
                periodInt = int.Parse(period.Substring(0, 2));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (periodInt == -1)
            {
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

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void InitChart()
        {
            var chart = chart1.ChartAreas[0];
            chart.AxisX.IntervalType = DateTimeIntervalType.Number;

            chart.AxisX.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.IsEndLabelVisible = true;

            chart.AxisX.Minimum = 1;
            chart.AxisX.Maximum = 24;
            chart.AxisY.Minimum = 0;
            chart.AxisY.Maximum = 20;
            chart.AxisX.Interval = 1;
            chart.AxisY.Interval = 5;

            chart1.Series.Add("number of clients");
            chart1.Series.Add("number of client requests");
            chart1.Series.Add("number of requests Velib");
            chart1.Series.Add("number of requests Google");

            chart1.Series["number of clients"].ChartType = SeriesChartType.Line;
            //chart1.Series["number of clients"].ChartType = SeriesChartType.Spline;
            chart1.Series["number of clients"].Color = Color.Red;
            chart1.Series[0].IsVisibleInLegend = false;
            chart1.Series["number of client requests"].ChartType = SeriesChartType.Line;
            //chart1.Series["number of clients"].ChartType = SeriesChartType.Spline;
            chart1.Series["number of client requests"].Color = Color.Yellow;
            chart1.Series[0].IsVisibleInLegend = false;
            chart1.Series["number of requests Velib"].ChartType = SeriesChartType.Line;
            //chart1.Series["number of clients"].ChartType = SeriesChartType.Spline;
            chart1.Series["number of requests Velib"].Color = Color.Blue;
            chart1.Series[0].IsVisibleInLegend = false;
            chart1.Series["number of requests Google"].ChartType = SeriesChartType.Line;
            //chart1.Series["number of clients"].ChartType = SeriesChartType.Spline;
            chart1.Series["number of requests Google"].Color = Color.Green;
            chart1.Series[0].IsVisibleInLegend = false;
            string xName = "";
            for(int i = 0;i < 24; i++)
            {
                xName = i + ":00-" + (i + 1) + ":00";
                chart1.Series["number of clients"].Points.AddXY(xName, 0);
                chart1.Series["number of client requests"].Points.AddXY(xName, 0);
                chart1.Series["number of requests Velib"].Points.AddXY(xName, 0);
                chart1.Series["number of requests Google"].Points.AddXY(xName, 0);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //chart1.ChartAreas[0].AxisX
            string xName = "";
            chart1.Series["number of clients"].Points.Clear();
            chart1.Series["number of client requests"].Points.Clear();
            chart1.Series["number of requests Velib"].Points.Clear();
            chart1.Series["number of requests Google"].Points.Clear();
            for (int i = 0; i < 24; i++)
            {
                xName = i + ":00-" + (i + 1) + ":00";
                chart1.Series["number of clients"].Points.AddXY(xName, service1ClientMonitor.GetNumberClients(i));
                chart1.Series["number of client requests"].Points.AddXY(xName, service1ClientMonitor.GetNumberClientRequests(i));
                chart1.Series["number of requests Velib"].Points.AddXY(xName, service1ClientMonitor.GetNumberRequestsVelib(i));
                chart1.Series["number of requests Google"].Points.AddXY(xName, service1ClientMonitor.GetNumberRequestsGoogle(i));
                //chart1.Series["number of clients"].Points.InsertY(i, service1ClientMonitor.GetNumberClients(i));
                //chart1.Series["number of client requests"].Points.InsertY(i, service1ClientMonitor.GetNumberClientRequests(i));
                //chart1.Series["number of requests Velib"].Points.InsertY(i, service1ClientMonitor.GetNumberRequestsVelib(i));
                //chart1.Series["number of requests Google"].Points.InsertY(i, service1ClientMonitor.GetNumberRequestsGoogle(i));

            }
        }
    }
}

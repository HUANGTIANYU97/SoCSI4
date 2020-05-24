using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Monitoring
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的类名“Service1”。
    public class Service1 : IService1
    {
        static Dictionary<int, CompositePeriodMonitor> MonitorInformation = new Dictionary<int, CompositePeriodMonitor>();
        static double currentAverageDelay = 0;
        static int counter = 0;
        public CompositePeriodMonitor GetCompositePeriodMonitor(int period)
        {
            return MonitorInformation[period];
        }

        public CompositePeriodMonitor CheckPeriod(int period)
        {
            if (MonitorInformation.ContainsKey(period))
            {
                return MonitorInformation[period];
            }
            else
            {
                CompositePeriodMonitor value = new CompositePeriodMonitor();
                value.NumberClients = 0;
                value.NumberClientRequests = 0;
                value.NumberRequestsVelib = 0;
                value.NumberRequestsGoogle = 0;
                MonitorInformation.Add(period, value);
                return MonitorInformation[period];
            }
        }
        public void UpdateNumberClients(int period)
        {
            CheckPeriod(period).NumberClients++; 
        }

        public int GetNumberClients(int period)
        {
            return CheckPeriod(period).NumberClients;
        }

        public void UpdateNumberClientRequests(int period)
        {
            CheckPeriod(period).NumberClientRequests++;
        }

        public int GetNumberClientRequests(int period)
        {
            return CheckPeriod(period).NumberClientRequests;
        }

        public void UpdateNumberRequestsVelib(int period)
        {
            CheckPeriod(period).NumberRequestsVelib++;
        }

        public int GetNumberRequestsVelib(int period)
        {
            return CheckPeriod(period).NumberRequestsVelib;
        }

        public void UpdateNumberRequestsGoogle(int period)
        {
            CheckPeriod(period).NumberRequestsGoogle++;
        }

        public int GetNumberRequestsGoogle(int period)
        {
            return CheckPeriod(period).NumberRequestsGoogle;
        }

        public void UpdateCurrentAverageDelay(double delay)
        {
            currentAverageDelay = (currentAverageDelay * counter + delay)/ (counter + 1);
            counter++;
        }

        public double GetCurrentAverageDelay() { return currentAverageDelay; }


    }
}

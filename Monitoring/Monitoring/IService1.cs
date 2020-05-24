using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Monitoring
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IService1”。
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        CompositePeriodMonitor GetCompositePeriodMonitor(int period);

        [OperationContract]
        int GetNumberClients(int period);

        [OperationContract]
        int GetNumberClientRequests(int period);

        [OperationContract]
        int GetNumberRequestsVelib(int period);

        [OperationContract]
        int GetNumberRequestsGoogle(int period);

        [OperationContract]
        double GetCurrentAverageDelay();

        [OperationContract]
        void UpdateNumberClients(int period);

        [OperationContract]
        void UpdateNumberClientRequests(int period);

        [OperationContract]
        void UpdateNumberRequestsVelib(int period);

        [OperationContract]
        void UpdateNumberRequestsGoogle(int period);

        [OperationContract]
        void UpdateCurrentAverageDelay(double delay);


        // TODO: 在此添加您的服务操作
    }

    // 使用下面示例中说明的数据约定将复合类型添加到服务操作。
    // 可以将 XSD 文件添加到项目中。在生成项目后，可以通过命名空间“Monitoring.ContractType”直接使用其中定义的数据类型。
    [DataContract]
    public class CompositePeriodMonitor
    {
        int numberClients;

        [DataMember]
        public int NumberClients
        {
            get { return numberClients; }
            set { numberClients = value; }
        }

        int numberClientRequests;

        [DataMember]
        public int NumberClientRequests
        {
            get { return numberClientRequests; }
            set { numberClientRequests = value; }
        }

        int numberRequestsVelib;

        [DataMember]
        public int NumberRequestsVelib
        {
            get { return numberRequestsVelib; }
            set { numberRequestsVelib = value; }
        }

        int numberRequestsGoogle;

        [DataMember]
        public int NumberRequestsGoogle
        {
            get { return numberRequestsGoogle; }
            set { numberRequestsGoogle = value; }
        }

        /*int currentAverageDelay;

        [DataMember]
        public int CurrentAverageDelay
        {
            get { return currentAverageDelay; }
            set { currentAverageDelay = value; }
        }*/
    }
}

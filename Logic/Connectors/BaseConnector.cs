using CentralData.Logic.Connectors.Interface;

namespace CentralData.Logic.Connectors
{
    internal abstract class BaseConnector : IConnector
    {
        public BaseConnector()
        {
            SetConnector();
        }

        public abstract dynamic RetrieveData();

        public abstract void SendData(dynamic pData);

        internal abstract void SetConnector();
    }
}
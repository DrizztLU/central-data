namespace CentralData.Logic.Connectors.Interface
{
    public interface IConnector
    {
        dynamic RetrieveData();

        void SendData(dynamic pData);
        
    }

}
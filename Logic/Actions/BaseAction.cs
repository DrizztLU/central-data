using CentralData.Logic.Actions.Interface;
using CentralData.Logic.Connectors.Enum;
using CentralData.Logic.Connectors.Factory;
using CentralData.Logic.Connectors.Interface;

namespace CentralData.Actions
{
    public abstract class BaseAction:IAction
    {
        private readonly ConnectorFactory _connectorFactory = new ConnectorFactory();

        private bool _done = false;
        private bool _connectorSet = false;
        public virtual bool Done { get{ return _done; } }
        private IConnector _inConnector;
        private IConnector _outConnector;
        private dynamic _data;

        public BaseAction()
        {

        }

        public void SetConnectors(ConnectorEnum pInConnector, ConnectorEnum pOutConnector)
        {
            SetInput(pInConnector);
            SetOutput(pOutConnector);

            _connectorSet = true;
        }

        private void SetInput(ConnectorEnum pInConnector)
        {
            _inConnector = _connectorFactory.GetConnector(pInConnector);
        }

        private void SetOutput(ConnectorEnum pOutConnector)
        {
            _outConnector = _connectorFactory.GetConnector(pOutConnector);
        }

        private dynamic RetrieveData() 
        {
            return _inConnector.RetrieveData();
        }

        private void SendData(dynamic pData)
        {
            _outConnector.SendData(_data);
        }

        private void ProcessData(dynamic pData)
        {

        }

        public void Do()
        {
            if(_connectorSet)
            {
                _data = RetrieveData();
                ProcessData(_data);
                SendData(_data);

                _done = true;
            }
        }
    }
}
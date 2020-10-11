using CentralData.Logic.Connectors.Enum;

namespace CentralData.Logic.Actions.Interface
{
    public interface IAction
    {
        void SetConnectors(ConnectorEnum pInConnector, ConnectorEnum pOutConnector);
        void Do();
    }
}
using System;
using CentralData.Logic.Connectors.Enum;
using CentralData.Logic.Connectors.Interface;

namespace CentralData.Logic.Connectors.Factory
{
    public class ConnectorFactory
    {
        public IConnector GetConnector(ConnectorEnum pConnectorType)
        {
            switch(pConnectorType)
            {
                case ConnectorEnum.Console:
                    return new ConsoleConnector();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
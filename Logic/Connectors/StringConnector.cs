using System;

namespace CentralData.Logic.Connectors
{
    internal class StringConnector : BaseConnector
    {
        public StringConnector():base()
        {
            
        }

        public override dynamic RetrieveData()
        {
            return "This is a string returned by the StringConnector";
        }

        public override void SendData(dynamic pData)
        {
            throw new NotImplementedException();
        }

        internal override void SetConnector()
        {
            // Nothing to set up
        }
    }
}
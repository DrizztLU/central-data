using System;

namespace CentralData.Logic.Connectors
{
    internal class ConsoleConnector : BaseConnector
    {
        public ConsoleConnector():base()
        {
            
        }

        public override dynamic RetrieveData()
        {
            Console.WriteLine("Awaiting user input");
            return Console.ReadLine();
        }

        public override void SendData(dynamic pData)
        {
            Console.Write(pData.ToString());
        }

        internal override void SetConnector()
        {
            // Nothing to set up
        }
    }
}
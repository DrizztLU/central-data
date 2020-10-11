using System.Collections.Generic;
using CentralData.Data.Entity;
using CentralData.Enum;
using CentralData.Logic.Actions.Enum;
using CentralData.Logic.Connectors.Enum;

namespace CentralData.Data
{
    public static class Config
    {
        public static List<Schedule> GetSchedules(){

            var theSchedules = new List<Schedule>()
            {
                new Schedule()
                {
                    Interval = 10,
                    IntervalStepId = (int)DateInterval.Second,
                    ScheduleActions = new List<ScheduleAction>()
                    {
                        new ScheduleAction()
                        {
                            ActionId = (int)ActionEnum.Pass,
                            InConnectorId = (int)ConnectorEnum.String,
                            OutConnectorId = (int)ConnectorEnum.Console
                        }
                    }
                }
            };

            return theSchedules;
        }
    }
}
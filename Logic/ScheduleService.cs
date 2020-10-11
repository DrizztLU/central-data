using System.Collections.Generic;
using System.Timers;
using CentralData.Data;
using CentralData.Data.Entity;
using CentralData.Enum;
using CentralData.Logic.Actions.Enum;
using CentralData.Logic.Actions.Factory;
using CentralData.Logic.Actions.Interface;
using CentralData.Logic.Connectors.Enum;
using CentralData.Models;

namespace CentralData.Logic
{
    public class ScheduleService
    {
        private readonly ActionFactory _actionFactory = new ActionFactory();
        private List<ScheduleModel> _schedules = new List<ScheduleModel>();

        public ScheduleService()
        {
            List<Schedule> theSchedules = Config.GetSchedules();

            foreach(var theSchedule in theSchedules) 
            {
                var theActions = new List<IAction>();

                foreach(var theScheduleAction in theSchedule.ScheduleActions)
                {
                    var theAction = _actionFactory.GetAction((ActionEnum)theScheduleAction.ActionId);
                    theAction.SetConnectors((ConnectorEnum)theScheduleAction.InConnectorId, (ConnectorEnum)theScheduleAction.OutConnectorId);
                    theActions.Add(theAction);
                }

                var theScheduleModel = new ScheduleModel(theSchedule.Interval, (DateInterval)theSchedule.IntervalStepId, theActions);

                _schedules.Add(theScheduleModel);
            }
        }

        public void StartSchedules()
        {
            List<Timer> theTimers = new List<Timer>();

            foreach (var theSchedule in _schedules)
            {
                var theTimer = new Timer();
                var theMSInterval = 0;

                switch (theSchedule.IntervalStep)
                {
                    case DateInterval.Second:
                        theMSInterval = theSchedule.Interval * 1000;
                        break;
                    case DateInterval.Minute:
                        theMSInterval = theSchedule.Interval * 60 * 1000;
                        break;
                    default:
                        theMSInterval = theSchedule.Interval * 1000;
                        break;
                }

            }
        }
    }
}
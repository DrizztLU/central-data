using System.Collections.Generic;
using CentralData.Enum;
using CentralData.Logic.Actions.Enum;
using CentralData.Logic.Actions.Factory;
using CentralData.Logic.Actions.Interface;
using CentralData.Logic.Connectors.Enum;

namespace CentralData.Models
{
    public class ScheduleModel
    {
        private int _interval;
        public virtual int Interval { get { return _interval; } }

        
        private DateInterval _intervalStep;
        public virtual DateInterval IntervalStep { get { return _intervalStep; } }

        private List<IAction> _actions;
        public virtual List<IAction> Actions { get { return _actions; } }

        public ScheduleModel(int pInterval, DateInterval pIntervalStep, List<IAction> pActions){
            _interval = pInterval;
            _intervalStep = pIntervalStep;
            _actions = pActions;
        }

        public void Tick()
        {
            foreach (var theAction in _actions)
            {
                theAction.Do();
            }
        }
    }
}
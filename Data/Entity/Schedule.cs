
using System.Collections.Generic;

namespace CentralData.Data.Entity
{
    public class Schedule
    {
        public int Interval;
        public int IntervalStepId;

        public List<ScheduleAction> ScheduleActions;
    }
}
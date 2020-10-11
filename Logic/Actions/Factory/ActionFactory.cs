using System;
using CentralData.Actions;
using CentralData.Logic.Actions.Enum;
using CentralData.Logic.Actions.Interface;

namespace CentralData.Logic.Actions.Factory
{
    public class ActionFactory
    {
        public IAction GetAction(ActionEnum pActionType)
        {
            switch(pActionType)
            {
                case ActionEnum.Pass:
                    return new PassAction();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace StateExample
{

    public class Context
    {
        public string State { get; set; }
    }

    public interface State
    {
        public void DoAction(Context context);
        public string GetStateName();
    }

    public class StartState : State
    {
        public void DoAction(Context context)
        {
            context.State = GetStateName(); 
        }

        public string GetStateName()
        {
            return "Start";
        }
    }

    public class StopState : State
    {
        public void DoAction(Context context)
        {
            context.State = GetStateName();
        }

        public string GetStateName()
        {
            return "Stop";
        }
    }
}

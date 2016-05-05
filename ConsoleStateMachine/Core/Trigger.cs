using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStateMachine.Core
{
    public abstract class Trigger
    {
        public abstract Type State { get; }
    }

    public class Trigger<TState> : Trigger where TState : ViewModelState
    {
        public override Type State => typeof (TState);
    }
}

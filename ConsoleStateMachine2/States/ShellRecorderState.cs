using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Events;

namespace ConsoleStateMachine2.States
{
    public class ShellRecorderState : ShellState
    {
        public ShellRecorderState(IEventAggregator eventAggregator) : base(eventAggregator)
        {
            Title = "Recorder";
        }

        public override void SwitchToPlayer()
        {
            Console.WriteLine("change state to Player");
            ChangeState<ShellPlayerState>();
        }
    }
}

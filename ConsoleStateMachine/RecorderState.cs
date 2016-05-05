using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStateMachine
{
    using Prism.Events;

    public class RecorderState : ShellState
    {
        public RecorderState(IEventAggregator eventAggregator) : base(eventAggregator)
        {
            Title = "[recorder state]";
        }

        public override void SwitchToPlayer()
        {
            Console.WriteLine("switch to player");
            ChangeState(new Trigger(typeof(PlayerState)));
        }

        public override void SwitchToRecorder()
        {
            Console.WriteLine("...");
        }
    }
}

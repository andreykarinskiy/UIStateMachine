using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStateMachine
{
    using Prism.Events;

    public class PlayerState : ShellState
    {
        public PlayerState(IEventAggregator eventAggregator) : base(eventAggregator)
        {
        }

        public override void SwitchToRecorder()
        {
            Console.WriteLine("switch to Recorder");
            ChangeState(new Trigger(typeof(RecorderState)));
        }

        public override void SwitchToPlayer()
        {
            Console.WriteLine("...");
        }
    }
}

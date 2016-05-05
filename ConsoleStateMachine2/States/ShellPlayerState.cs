using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Events;

namespace ConsoleStateMachine2.States
{
    public class ShellPlayerState : ShellState
    {
        public ShellPlayerState(IEventAggregator eventAggregator) : base(eventAggregator)
        {
            Title = "Player";
        }

        public override void SwitchToRecorder()
        {
            Console.WriteLine("change state to Recorder");
            ChangeState<ShellRecorderState>();
        }
    }
}

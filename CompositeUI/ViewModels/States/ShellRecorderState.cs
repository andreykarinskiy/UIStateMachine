using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeUI.ViewModels.States
{
    using System.Windows;

    using Prism.Events;

    public class ShellRecorderState : ShellState
    {
        public ShellRecorderState(IEventAggregator eventAggregator) : base(eventAggregator)
        {
            Title = "Recorder";
        }

        public override void SwitchToRecorder()
        {
        }

        public override void SwitchToPlayer()
        {
            ChangeState<ShellPlayerState>();
        }
    }
}

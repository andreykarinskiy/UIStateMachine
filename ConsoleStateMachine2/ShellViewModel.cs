using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleStateMachine2.Core;
using ConsoleStateMachine2.States;
using Microsoft.Practices.Unity;
using Prism.Events;

namespace ConsoleStateMachine2
{
    public class ShellViewModel : StateableViewModel<ShellState>, IShellViewModel
    {
        public ShellViewModel(ShellState[] allStates, [Dependency("Recorder")] ShellState currentState, IEventAggregator eventAggregator) : base(allStates, currentState, eventAggregator)
        {
        }

        public string Title => currentState.Title;

        public void SwitchToRecorder()
        {
            currentState.SwitchToRecorder();
        }

        public void SwitchToPlayer()
        {
            currentState.SwitchToPlayer();
        }
    }
}

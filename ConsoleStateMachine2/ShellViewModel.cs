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
        public ShellViewModel([Dependency("Recorder")] ShellState currentState, ShellState[] allStates, IEventAggregator eventAggregator) : base(currentState, allStates, eventAggregator)
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

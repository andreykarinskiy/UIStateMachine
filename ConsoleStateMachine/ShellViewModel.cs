using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStateMachine
{
    using ConsoleStateMachine.Core;

    using Microsoft.Practices.Unity;

    using Prism.Events;

    public class ShellViewModel : IShellViewModel
    {
        private ShellState currentState;

        private readonly ShellState[] states;

        public ShellViewModel([Dependency("Recorder")]ShellState initialState, ShellState[] states, IEventAggregator eventAggregator)
        {
            this.states = states;
            this.currentState = initialState;

            eventAggregator.GetEvent<PubSubEvent<Trigger>>().Subscribe(ChangeState);
        }

        public string Title
        {
            get { return currentState.Title; }
        }

        public void SwitchToRecorder()
        {
            currentState.SwitchToRecorder();
        }

        public void SwitchToPlayer()
        {
            currentState.SwitchToPlayer();
        }

        private void ChangeState(Trigger trigger)
        {
            currentState?.Exit();

            currentState = states.Single(o => o.GetType() == trigger.State);

            currentState.Enter();
        }
    }
}

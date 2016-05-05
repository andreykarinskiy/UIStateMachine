using ConsoleStateMachine2.States;
using Prism.Events;
using Prism.Mvvm;

namespace ConsoleStateMachine2.Core
{
    public abstract class ViewModelState : BindableBase
    {
        private readonly IEventAggregator eventAggregator;

        protected ViewModelState(IEventAggregator eventAggregator)
        {
            this.eventAggregator = eventAggregator;
        }

        internal virtual void Enter()
        {
        }

        internal virtual void Exit()
        {
        }

        protected void ChangeState(Trigger trigger)
        {
            eventAggregator
                .GetEvent<PubSubEvent<Trigger>>()
                .Publish(trigger);
        }

        protected void ChangeState<TState>() where TState : ShellState
        {
            ChangeState(new Trigger<TState>());
        }
    }
}

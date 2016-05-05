namespace ConsoleStateMachine.Core
{
    using Prism.Events;

    public abstract class ViewModelState
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

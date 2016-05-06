namespace CompositeUI.Core
{
    using CompositeUI.ViewModels.States;

    using Prism.Events;
    using Prism.Mvvm;

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

        protected void ChangeState<TState>() where TState : ViewModelState
        {
            this.ChangeState(new Trigger<TState>());
        }
    }
}

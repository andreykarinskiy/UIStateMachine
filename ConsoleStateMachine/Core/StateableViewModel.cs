namespace ConsoleStateMachine.Core
{
    using Prism.Events;
    using Prism.Mvvm;

    public abstract class StateableViewModel : BindableBase
    {
        private readonly IEventAggregator eventAggregator;

        protected StateableViewModel(IEventAggregator eventAggregator)
        {
            this.eventAggregator = eventAggregator;
        }

        protected void ChangeState(Trigger trigger)
        {
            eventAggregator.GetEvent<PubSubEvent<Trigger>>().Publish(trigger);
        }
    }
}

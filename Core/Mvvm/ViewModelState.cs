using Prism.Events;
using Prism.Mvvm;

namespace Core.Mvvm
{
    public abstract class ViewModelState : ViewModel
    {
        private readonly IEventAggregator eventAggregator;

        protected ViewModelState(IEventAggregator eventAggregator)
        {
            this.eventAggregator = eventAggregator;
        }

        public virtual void Enter()
        {
        }

        public virtual void Exit()
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

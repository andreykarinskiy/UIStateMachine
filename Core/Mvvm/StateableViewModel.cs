using System.Linq;
using Prism.Events;
using Prism.Mvvm;

namespace Core.Mvvm
{
    public abstract class StateableViewModel<TViewModelState> : BindableBase
        where TViewModelState : ViewModelState
    {
        private readonly TViewModelState[] allStates;

        protected TViewModelState CurrentState { get; private set; }

        protected StateableViewModel(TViewModelState currentState, TViewModelState[] allStates, IEventAggregator eventAggregator)
        {
            CurrentState = currentState;
            this.allStates = allStates;

            eventAggregator
                .GetEvent<PubSubEvent<Trigger>>()
                .Subscribe(ChangeState);
        }

        private void ChangeState(Trigger trigger)
        {
            CurrentState?.Exit();

            CurrentState = FindState(trigger);

            CurrentState.Enter();
        }

        private TViewModelState FindState(Trigger trigger)
        {
            var stateTrigger = trigger;
            return allStates.Single(o => o.GetType() == stateTrigger.State);
        }
    }
}

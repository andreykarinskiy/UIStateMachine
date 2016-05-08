using System.Linq;
using Prism.Events;
using Prism.Mvvm;

namespace Core.Mvvm
{
    public abstract class StateableViewModel<TViewModelState> : ViewModel
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
            var newState = FindState(trigger);

            if (newState == null)
            {
                return;
            }

            CurrentState?.Exit();

            CurrentState = newState;

            CurrentState.Enter();
        }

        private TViewModelState FindState(Trigger trigger)
        {
            var stateTrigger = trigger;
            return allStates.SingleOrDefault(o => o.GetType() == stateTrigger.State);
        }
    }
}

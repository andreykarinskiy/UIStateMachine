namespace ConsoleStateMachine.Core
{
    using System.Linq;
    using Prism.Events;
    using Prism.Mvvm;

    public abstract class StateableViewModel<TViewModelState> : BindableBase
        where TViewModelState : ViewModelState
    {
        private readonly TViewModelState[] allStates;

        protected TViewModelState currentState;

        protected StateableViewModel(TViewModelState[] allStates, TViewModelState currentState, IEventAggregator eventAggregator)
        {
            this.allStates = allStates;
            this.currentState = currentState;

            eventAggregator
                .GetEvent<PubSubEvent<Trigger>>()
                .Subscribe(ChangeState);
        }

        private void ChangeState(Trigger trigger)
        {
            currentState?.Exit();

            currentState = allStates.Single(o => o.GetType() == trigger.State);

            currentState.Enter();
        }
    }
}

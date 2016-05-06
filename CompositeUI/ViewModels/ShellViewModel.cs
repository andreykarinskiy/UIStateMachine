namespace CompositeUI.ViewModels
{
    using CompositeUI.Core;
    using CompositeUI.ViewModels.States;
    using Microsoft.Practices.Unity;
    using Prism.Events;


    public class ShellViewModel : StateableViewModel<ShellState>, IShellViewModel
    {
        public ShellViewModel([Dependency("Recorder")]ShellState currentState, ShellState[] allStates, IEventAggregator eventAggregator) : base(currentState, allStates, eventAggregator)
        {
        }

        public string Title => CurrentState.Title;

        public void SwitchToRecorder()
        {
            CurrentState.SwitchToRecorder();
        }

        public void SwitchToPlayer()
        {
            CurrentState.SwitchToRecorder();
        }
    }
}

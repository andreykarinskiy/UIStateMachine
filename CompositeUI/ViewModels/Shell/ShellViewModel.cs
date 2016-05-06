namespace CompositeUI.ViewModels.Shell
{
    using CompositeUI.Core;
    using CompositeUI.ViewModels.Shell.States;

    using Microsoft.Practices.Unity;

    using Prism.Events;

    public class ShellViewModel : StateableViewModel<ShellState>, IShellViewModel
    {
        public ShellViewModel([Dependency("Recorder")]ShellState currentState, ShellState[] allStates, IEventAggregator eventAggregator) : base(currentState, allStates, eventAggregator)
        {
        }

        public string Title => this.CurrentState.Title;

        public void SwitchToRecorder()
        {
            this.CurrentState.SwitchToRecorder();
        }

        public void SwitchToPlayer()
        {
            this.CurrentState.SwitchToRecorder();
        }
    }
}

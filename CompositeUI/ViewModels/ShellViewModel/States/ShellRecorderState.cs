namespace CompositeUI.ViewModels.ShellViewModel.States
{
    using Prism.Events;

    public class ShellRecorderState : ShellState
    {
        public ShellRecorderState(IEventAggregator eventAggregator) : base(eventAggregator)
        {
            this.Title = "Recorder";
        }

        public override void SwitchToRecorder()
        {
        }

        public override void SwitchToPlayer()
        {
            this.ChangeState<ShellPlayerState>();
        }
    }
}

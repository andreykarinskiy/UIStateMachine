namespace CompositeUI.ViewModels.Shell.States
{
    using Prism.Events;

    public class ShellPlayerState : ShellState
    {
        public ShellPlayerState(IEventAggregator eventAggregator) : base(eventAggregator)
        {
            this.Title = "Player";
        }

        public override void SwitchToRecorder()
        {
            this.ChangeState<ShellRecorderState>();
        }

        public override void SwitchToPlayer()
        {
        }
    }
}

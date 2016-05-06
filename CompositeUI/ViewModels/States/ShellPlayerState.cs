namespace CompositeUI.ViewModels.States
{
    using Prism.Events;

    public class ShellPlayerState : ShellState
    {
        public ShellPlayerState(IEventAggregator eventAggregator) : base(eventAggregator)
        {
            Title = "Player";
        }

        public override void SwitchToRecorder()
        {
            ChangeState<ShellRecorderState>();
        }

        public override void SwitchToPlayer()
        {
        }
    }
}

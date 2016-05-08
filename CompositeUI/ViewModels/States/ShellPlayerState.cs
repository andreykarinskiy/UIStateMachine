using Prism.Events;

namespace CompositeUI.ViewModels.States
{
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

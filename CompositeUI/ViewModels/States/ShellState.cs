using Core.Mvvm;
using Prism.Events;

namespace CompositeUI.ViewModels.States
{
    public abstract class ShellState : ViewModelState, IShellViewModel
    {
        protected ShellState(IEventAggregator eventAggregator) : base(eventAggregator)
        {
        }

        public string Title { get; set; }

        public abstract void SwitchToRecorder();

        public abstract void SwitchToPlayer();
    }
}

namespace UIStateMachine.ViewModels
{
    using System.Windows.Input;
    using Prism.Commands;
    using Prism.Events;
    using Prism.Mvvm;
    using Prism.Regions;

    using UIStateMachine.Events;

    public class MacroRecorderViewModel : BindableBase
    {
        private readonly IEventAggregator eventAggregator;

        public MacroRecorderViewModel(IEventAggregator eventAggregator)
        {
            this.eventAggregator = eventAggregator;
            Stop = new DelegateCommand(ToPlayer, () => true);
        }

        public ICommand Stop { get; }

        private void ToPlayer()
        {
            eventAggregator.GetEvent<PubSubEvent<PlayerSelected>>().Publish(new PlayerSelected());
        }
    }
}

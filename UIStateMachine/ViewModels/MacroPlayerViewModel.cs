namespace UIStateMachine.ViewModels
{
    using System.Windows.Input;

    using Prism.Commands;
    using Prism.Events;
    using Prism.Mvvm;
    using Prism.Regions;

    using UIStateMachine.Core;
    using UIStateMachine.Events;
    using UIStateMachine.Views;

    public class MacroPlayerViewModel : BindableBase
    {
        private readonly IEventAggregator eventAggregator;

        public MacroPlayerViewModel(IEventAggregator eventAggregator)
        {
            this.eventAggregator = eventAggregator;
            ToRecorder = new DelegateCommand(GoToRecorder, () => true);
        }

        public ICommand ToRecorder { get; }

        private void GoToRecorder()
        {
            eventAggregator.Publish(new RecorderSelected());
        }
    }
}

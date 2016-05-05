namespace UIStateMachine.ViewModels
{
    using System.Windows.Input;
    using Prism.Commands;
    using Prism.Events;
    using Prism.Mvvm;

    using UIStateMachine.Core;
    using UIStateMachine.Events;

    public class MacroRecorderViewModel : BindableBase, IRecorderViewModel
    {
        private readonly IEventAggregator eventAggregator;

        public MacroRecorderViewModel(IEventAggregator eventAggregator)
        {
            this.eventAggregator = eventAggregator;

            Start = new DelegateCommand(StartRecording, CanStart);

            Pause = new DelegateCommand(PauseRecording, CanPause);

            Stop = new DelegateCommand(StopRecording, CanStop);
        }

        private void StartRecording()
        {
            throw new System.NotImplementedException();
        }

        private void PauseRecording()
        {
            throw new System.NotImplementedException();
        }

        private void StopRecording()
        {
            eventAggregator.Publish(new PlayerSelected());
        }

        public ICommand Start { get; }

        public bool CanStart()
        {
            return false;
        }

        public ICommand Pause { get; }

        public bool CanPause()
        {
            return false;
        }

        public ICommand Stop { get; }

        public bool CanStop()
        {
            return true;
        }
    }
}

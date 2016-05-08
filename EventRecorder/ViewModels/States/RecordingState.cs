using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.Practices.Unity;
using Prism.Commands;
using Prism.Events;

namespace EventRecorder.ViewModels.States
{
    public class RecordingState : RecorderState
    {
        private readonly IEventAggregator eventAggregator;

        public RecordingState(IEventAggregator eventAggregator) : base(eventAggregator)
        {
            this.eventAggregator = eventAggregator;
        }

        public override void Enter()
        {
            Status = "recording";

            eventAggregator.GetEvent<PubSubEvent<string>>().Publish("Status");

            //((DelegateCommand)Start).RaiseCanExecuteChanged();
        }

        public override bool CanStart()
        {
            return false;
        }

        public override bool CanPause()
        {
            return true;
        }

        protected override void PauseRecording()
        {
        }

        public override bool CanStop()
        {
            return true;
        }

        protected override void StopRecording()
        {
        }
    }
}

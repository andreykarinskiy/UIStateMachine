using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Events;

namespace EventRecorder.ViewModels.States
{
    public class ReadyRecorderState : RecorderState
    {
        public ReadyRecorderState(IEventAggregator eventAggregator) : base(eventAggregator)
        {
            Status = "ready...";
        }

        public override bool CanStart()
        {
            return true;
        }

        protected override void StartRecording()
        {
            ChangeState<RecordingState>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Core.Mvvm;
using EventRecorder.ViewModels.States;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;

namespace EventRecorder.ViewModels
{
    public class EventRecorderViewModel : StateableViewModel<RecorderState>, IEventRecorderViewModel
    {
        public EventRecorderViewModel([Microsoft.Practices.Unity.DependencyAttribute("Recorder.Ready")]RecorderState currentState, RecorderState[] allStates, IEventAggregator eventAggregator) : base(currentState, allStates, eventAggregator)
        {
        }

        public string Status => CurrentState.Status;

        public ICommand Start => CurrentState.Start;

        public bool CanStart()
        {
            return CurrentState.CanStart();
        }

        public ICommand Pause => CurrentState.Pause;

        public bool CanPause()
        {
            return CurrentState.CanPause();
        }

        public ICommand Stop => CurrentState.Stop;

        public bool CanStop()
        {
            return CurrentState.CanStop();
        }
    }
}

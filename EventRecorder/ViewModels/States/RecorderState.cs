using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Core.Mvvm;
using Prism.Commands;
using Prism.Events;

namespace EventRecorder.ViewModels.States
{
    public abstract class RecorderState : ViewModelState, IEventRecorderViewModel
    {
        protected RecorderState(IEventAggregator eventAggregator) : base(eventAggregator)
        {
            Start = new DelegateCommand(StartRecording, CanStart);
            Pause = new DelegateCommand(PauseRecording, CanPause);
            Stop = new DelegateCommand(StopRecording, CanStop);
        }

        public string Status
        {
            get { return Get<string>(); }
            set { Set(value); }
        }

        public ICommand Start { get; }

        public virtual bool CanStart()
        {
            return false;
        }

        protected virtual void StartRecording()
        {
        }

        public ICommand Pause { get; }

        public virtual bool CanPause()
        {
            return false;
        }

        protected virtual void PauseRecording()
        {
        }

        public ICommand Stop { get; }

        public virtual bool CanStop()
        {
            return false;
        }

        protected virtual void StopRecording()
        {
        }
    }
}

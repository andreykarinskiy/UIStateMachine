using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Core.Mvvm;
using Prism.Commands;
using Prism.Mvvm;

namespace EventRecorder.ViewModels
{
    public class EventRecorderViewModel : ViewModel, IEventRecorderViewModel
    {
        public EventRecorderViewModel()
        {
            Start = new DelegateCommand(StartRecording, CanStart);
            Stop = new DelegateCommand(StopRecording, CanStop);
        }

        public string Status
        {
            get { return Get<string>(); }
            set { Set(value); }
        }

        public ICommand Start { get; }

        public bool CanStart()
        {
            return true;
        }

        private void StartRecording()
        {
            Status = "recording started";
        }

        public ICommand Pause { get; }

        public bool CanPause()
        {
            return false;
        }

        public ICommand Stop { get; }

        public bool CanStop()
        {
            return false;
        }

        private void StopRecording()
        {
            
        }
    }
}

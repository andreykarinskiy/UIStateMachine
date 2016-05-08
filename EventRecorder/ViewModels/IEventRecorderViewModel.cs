using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EventRecorder.ViewModels
{
    public interface IEventRecorderViewModel
    {
        string Status { get; }

        ICommand Start { get; }

        bool CanStart();

        ICommand Pause { get; }

        bool CanPause();

        ICommand Stop { get; }

        bool CanStop();
    }
}

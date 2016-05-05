using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIStateMachine.ViewModels
{
    using System.Windows.Input;

    public interface IRecorderViewModel
    {
        ICommand Start { get; }

        bool CanStart();

        ICommand Pause { get; }

        bool CanPause();

        ICommand Stop { get; }

        bool CanStop();
    }
}

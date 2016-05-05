using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIStateMachine.ViewModels
{
    public interface IShellViewModel
    {
        void SwitchToRecorder();

        void SwitchToPlayer();

        string Title { get; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStateMachine
{
    public interface IShellViewModel
    {
        string Title { get; }

        void SwitchToRecorder();

        void SwitchToPlayer();
    }
}

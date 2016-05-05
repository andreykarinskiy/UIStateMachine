using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStateMachine2
{
    public interface IShellViewModel
    {
        string Title { get; }

        void SwitchToRecorder();

        void SwitchToPlayer();
    }
}

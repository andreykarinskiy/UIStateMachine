using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleStateMachine2.Core;
using Prism.Events;

namespace ConsoleStateMachine2.States
{
    public abstract class ShellState : ViewModelState, IShellViewModel
    {
        private string title;

        protected ShellState(IEventAggregator eventAggregator) : base(eventAggregator)
        {
        }

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                SetProperty(ref title, value);
            }
        }

        public virtual void SwitchToRecorder()
        {
            throw new InvalidOperationException();
        }

        public virtual void SwitchToPlayer()
        {
            throw new InvalidOperationException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeUI.ViewModels.States
{
    using CompositeUI.Core;

    using Prism.Events;

    public abstract class ShellState : ViewModelState, IShellViewModel
    {
        protected ShellState(IEventAggregator eventAggregator) : base(eventAggregator)
        {
        }

        public string Title { get; set; }

        public abstract void SwitchToRecorder();

        public abstract void SwitchToPlayer();
    }
}

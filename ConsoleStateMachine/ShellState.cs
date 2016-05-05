using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStateMachine
{
    using Prism.Events;
    using Prism.Mvvm;

    public abstract class ShellState : BindableBase, IShellViewModel
    {
        private readonly IEventAggregator eventAggregator;

        protected ShellState(IEventAggregator eventAggregator)
        {
            this.eventAggregator = eventAggregator;
        }

        private string title;

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
                OnPropertyChanged();
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

        public virtual void Enter()
        {
            Console.WriteLine(this.GetType().Name + " enter");
        }

        public virtual void Exit()
        {
            Console.WriteLine(this.GetType().Name + " exit");
        }

        protected void ChangeState(Trigger trigger)
        {
            eventAggregator.GetEvent<PubSubEvent<Trigger>>().Publish(trigger);
        }
    }
}

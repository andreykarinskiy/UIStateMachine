using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStateMachine
{
    public class Trigger
    {
        public Trigger(string name)
        {
            this.Name = name;
        }

        public Trigger(Type state)
        {
            this.State = state;
        }

        public readonly string Name;

        public readonly Type State;
    }
}

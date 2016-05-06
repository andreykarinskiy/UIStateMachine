namespace CompositeUI.Core
{
    using System;

    public abstract class Trigger
    {
        public abstract Type State { get; }
    }

    public class Trigger<TState> : Trigger where TState : ViewModelState
    {
        public override Type State => typeof (TState);
    }
}

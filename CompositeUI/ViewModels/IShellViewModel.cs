namespace CompositeUI.ViewModels
{
    public interface IShellViewModel
    {
        string Title { get; }

        void SwitchToRecorder();

        void SwitchToPlayer();
    }
}

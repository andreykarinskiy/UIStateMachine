namespace CompositeUI.ViewModels.Shell
{
    public interface IShellViewModel
    {
        string Title { get; }

        void SwitchToRecorder();

        void SwitchToPlayer();
    }
}

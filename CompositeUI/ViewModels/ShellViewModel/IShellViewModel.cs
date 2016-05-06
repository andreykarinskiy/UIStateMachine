namespace CompositeUI.ViewModels.ShellViewModel
{
    public interface IShellViewModel
    {
        string Title { get; }

        void SwitchToRecorder();

        void SwitchToPlayer();
    }
}

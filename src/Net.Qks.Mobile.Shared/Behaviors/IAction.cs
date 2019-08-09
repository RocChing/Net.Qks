using Xamarin.Forms.Internals;

namespace Net.Qks.Behaviors
{
    [Preserve(AllMembers = true)]
    public interface IAction
    {
        bool Execute(object sender, object parameter);
    }
}
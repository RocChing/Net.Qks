using System.Threading.Tasks;

namespace Net.Qks.Net.Sms
{
    public interface ISmsSender
    {
        Task SendAsync(string number, string message);
    }
}
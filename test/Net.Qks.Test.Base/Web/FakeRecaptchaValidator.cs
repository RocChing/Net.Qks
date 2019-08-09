using System.Threading.Tasks;
using Net.Qks.Security.Recaptcha;

namespace Net.Qks.Test.Base.Web
{
    public class FakeRecaptchaValidator : IRecaptchaValidator
    {
        public Task ValidateAsync(string captchaResponse)
        {
            return Task.CompletedTask;
        }
    }
}

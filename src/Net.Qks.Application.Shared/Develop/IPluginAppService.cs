using Abp.Application.Services;

namespace Net.Qks.Develop
{
    public interface IPluginAppService : IApplicationService
    {
        /// <summary>
        /// 更新插件
        /// </summary>
        void Update();

        string AddMigrations(string name, bool update = true);

        string RemoveMigrations(bool update = true);
    }
}

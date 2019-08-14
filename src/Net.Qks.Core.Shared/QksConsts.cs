namespace Net.Qks
{
    using Abp.Localization;
    public static class QksConsts
    {
        static ILocalizationManager _localMgr;
        static QksConsts()
        {

        }
        public const string Name = "Qks";
        public const string LocalizationSourceName = "Qks";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;

        public const bool AllowTenantsToChangeEmailSettings = false;

        public const string Currency = "USD";

        public const string CurrencySign = "$";

        public const string Admin = "Admin";

        public const int DefaultOrderValue = 100;

        public const string NetQksApplication = "Net.Qks.Application";
        public const string NetQksCore = "Net.Qks.Core";
        public const string NetQksApplicationShared = "Net.Qks.Application.Shared";
        public const string NetQksCoreShared = "Net.Qks.Core.Shared";
        public const string NetQksWebHost = "Qks.Web.Host";

        public const string AdminAreaName = "Admin";
        public const string AdminMenuName = "MainMenu";

        public class Field
        {
            public const int Len50 = 50;
            public const int Len100 = 100;
            public const int Len200 = 200;
        }

        public class Plugin
        {
            public const string Name = "Plugin";
            public const string AllDll = "*.dll";
            public const string Plugins = "Plugins";
            public const string QksPlugin = "Qks.Plugin";
            public const string Core = "Qks.Plugin.Core";
            public const string Application = "Qks.Plugin.Application";
            public const string EFCore = "Qks.Plugin.EFCore";

            public const string EFCoreInit = EFCore + ".QksPluginEFCoreInit";
            public const string EFCoreInitDbContext = "InitDbContext";
            public const string EFCoreRegisterAssembly = "RegisterAssembly";
        }

        public class ErrorMsg
        {
            public const string Required = "{0}不能为空";
            public const string MaxLength = "{0}允许的最大长度是{1}";
        }

        public class Action
        {
            public const string Create = "Create";
            public const string Update = "Update";
            public const string Delete = "Delete";
        }
    }
}
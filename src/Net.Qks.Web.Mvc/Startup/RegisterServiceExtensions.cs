using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.AspNetCore.Hosting;

using Net.Qks.Develop;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Net.Qks.Web.Startup
{
    public static class RegisterServiceExtensions
    {
        public static void RegisterQksService(this IServiceCollection services)
        {
            services.AddTransient(s => new CmdExecutor());

            services.Replace(ServiceDescriptor.Transient<IHtmlHelper, MyHtmlHelper>());
            services.Replace(ServiceDescriptor.Transient(typeof(IHtmlHelper<>), typeof(MyHtmlHelper<>)));
        }

        public static bool RegisterQksPlugin(this IServiceCollection services, IHostingEnvironment hostingEnvironment)
        {
            var pluginOpt = new PluginOptions
            {
                Environment = hostingEnvironment
            };

            PluginHelper.LoadPlugins(pluginOpt);
            services.AddSingleton(pluginOpt);
            return pluginOpt.Loaded;
        }
    }
}

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SMS.Class.Adapter;
using SMS.Repository;
using SMS.Views.Accounts;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.Run(new frmUser());

            //var services = new ServiceCollection();
            
            //ConfigureServices(services);

            //using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            //{
            //    var frm = serviceProvider.GetRequiredService<frmUser>();
            //    Application.Run(frm);
            //}

            
        }
        //public static IConfiguration config { get; }
        //private static void ConfigureServices(IServiceCollection services)
        //{
        //    services.AddLogging(configure => configure.AddConsole())
        //            .AddSingleton<IAdapter, AdapterClass>();
        //    services.AddScoped<frmUser>();
        //    //services.AddMvc();
        //    //services.AddSingleton<IConfiguration>(Configuration);

        //}
    }
}

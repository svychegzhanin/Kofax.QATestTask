//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="Kofax Inc.">
//     Copyright (c) Kofax Inc. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Kofax.QATestTask
{
    using Microsoft.AspNetCore;
    using Microsoft.AspNetCore.Hosting;

    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}

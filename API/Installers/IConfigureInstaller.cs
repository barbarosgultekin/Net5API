﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

namespace API.Installers
{
    public interface IConfigureInstaller
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        void InstallConfigure(IApplicationBuilder app, IWebHostEnvironment env);
    }
}
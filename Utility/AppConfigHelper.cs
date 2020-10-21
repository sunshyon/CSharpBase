using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Utility
{
    /*
     添加依赖
      Microsoft.Extensions.Configuration
　　  Microsoft.Extensions.Configuration.FileExtensions
　　  Microsoft.Extensions.Configuration.Json
    */
    public class AppConfigHelper
    {
        public static string GetFactoryName(string settingKey)
        {
            var builder = new ConfigurationBuilder()
              .AddJsonFile(Directory.GetCurrentDirectory()+"//AppConfig.json", false, true);
            var config = builder.Build();
            var factoryName = config.GetSection(settingKey).Value;
            
            return factoryName;
        }

        public static object GetFactoryInstance(string settingKey)
        {
            string assemblyName = AppConfigHelper.GetFactoryName(settingKey);
            Type type = Type.GetType(assemblyName);

            var instance = Activator.CreateInstance(type);
            return instance;
        }
    }
}

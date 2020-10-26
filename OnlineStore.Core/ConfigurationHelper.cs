using System;
using OnlineStore.Core.Common.Contracts;
using System.Configuration;

namespace OnlineStore.Core
{
    public class ConfigurationHelper : IConfigurationHelper
    {
        public int DefaultProductListCount
        {
            get { return Convert.ToInt32(ConfigurationManager.AppSettings["DefaultProductListCount"]); }
        }
    }
}
using System;
using System.Collections.Generic;
using AppConfig.Interfaces;
using Foundation;
using Xamarin.Forms;

[assembly: Dependency(typeof(AppConfig.iOS.Services.ConfigurationService))]
namespace AppConfig.iOS.Services
{
	public class ConfigurationService : IConfigurationService
	{
        #region module level declarations

        NSDictionary _appConfig = null;

        #endregion

        #region ctors

        public ConfigurationService ()
        {
            _appConfig = (NSDictionary)NSBundle.MainBundle.ObjectForInfoDictionary("AppConfig");
        }

        #endregion

        #region helpers

        private string ReadStringValue(String key)
        {
            if (!_appConfig.ContainsKey(new NSString(key)))
                throw new KeyNotFoundException($"Unable to find {key} in the Info.plist file.");

            return (_appConfig[key] as NSString).ToString();
        }

        #endregion

        #region interface implementations

        public string GetAPIEndpoint()
        {
            return ReadStringValue("APIEndpoint");
        }

        public string GetEnvironment()
        {
            return ReadStringValue("Environment");
        }

        #endregion

    }


}


using System;
namespace AppConfig.Interfaces
{
    public interface IConfigurationService
    {
        string GetEnvironment();
        string GetAPIEndpoint();
    }
}


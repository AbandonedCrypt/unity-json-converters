using Newtonsoft.Json;

namespace AbandonedCrypt.JSON
{
  public static class JsonConfiguration
  {
    public static void ConfigureNewtonsoftDefaults()
    {
      JsonConvert.DefaultSettings = () => SettingsProvider.Settings;
    }
  }
}
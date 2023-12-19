using Newtonsoft.Json;

namespace AbandonedCrypt.JSON
{
  public static class JsonConfiguration
  {
    public static void ConfigureNewtonsoftDefaults()
    {
      JsonConvert.DefaultSettings = () =>
      {
        var settings = new JsonSerializerSettings
        {
          TypeNameHandling = TypeNameHandling.Auto
        };
        settings.Converters.Add(new ColorConverter());
        settings.Converters.Add(new Vector2Converter());
        settings.Converters.Add(new Vector3Converter());
        return settings;
      };
    }
  }
}
using Newtonsoft.Json;

namespace AbandonedCrypt.JSON
{
  public static class SettingsProvider
  {
    public static JsonSerializerSettings Settings { get; }

    static SettingsProvider()
    {
      var settings = new JsonSerializerSettings
      {
        TypeNameHandling = TypeNameHandling.Auto
      };
      settings.Converters.Add(new ColorConverter());
      settings.Converters.Add(new Vector2Converter());
      settings.Converters.Add(new Vector3Converter());
      settings.Converters.Add(new Vector4Converter());
      Settings = settings;
    }
  }
}
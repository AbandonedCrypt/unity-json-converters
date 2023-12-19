using Newtonsoft.Json;

namespace AbandonedCrypt.JSON
{
  public static class SettingsProvider
  {
    public static JsonSerializerSettings Settings { get; }

    static SettingsProvider()
    {
      var settings = JsonConvert.DefaultSettings?.Invoke();
      if (settings == null)
        settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
      else
        settings.TypeNameHandling = TypeNameHandling.Auto;

      settings.Converters.AddIfUnoccupied(new ColorConverter());
      settings.Converters.AddIfUnoccupied(new Vector2Converter());
      settings.Converters.AddIfUnoccupied(new Vector3Converter());
      settings.Converters.AddIfUnoccupied(new Vector4Converter());

      Settings = settings;
    }
  }
}
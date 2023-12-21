using Newtonsoft.Json;

namespace AbandonedCrypt.JSON
{
  public static class SettingsProvider
  {
    public static JsonSerializerSettings Settings { get; }

    static SettingsProvider()
    {
      var settings = JsonConvert.DefaultSettings?.Invoke() ?? new JsonSerializerSettings();

      settings.Converters.AddIfUnoccupied(new ColorConverter());
      settings.Converters.AddIfUnoccupied(new Vector2Converter());
      settings.Converters.AddIfUnoccupied(new Vector3Converter());
      settings.Converters.AddIfUnoccupied(new Vector4Converter());

      Settings = settings;
    }
  }
}
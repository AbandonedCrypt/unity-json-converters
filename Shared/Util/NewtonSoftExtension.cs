using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace AbandonedCrypt.JSON
{
  public static class NewtonsoftExtension
  {
    /// <summary>
    /// Only adds the converter, if no converter targeting the same type is present.
    /// </summary>
    internal static void AddIfUnoccupied(this IList<JsonConverter> list, JsonConverter converter)
    {
      if (!list.Any(item => item.CanConvert(converter.GetType())))
        list.Add(converter);
    }

    /// <summary>
    /// Adds a converter and removes all other converters targeting the same type.
    /// </summary>
    public static void OverwriteAll(this IList<JsonConverter> list, JsonConverter converter)
    {
      if (list.Any(item => item.CanConvert(converter.GetType())))
        ((List<JsonConverter>)list).RemoveAll(item => item.CanConvert(converter.GetType()));
      list.Add(converter);
    }
  }
}
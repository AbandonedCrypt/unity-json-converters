#if UNITY_EDITOR
using UnityEditor;

namespace AbandonedCrypt.JSON
{
  public static class EditorConfiguration
  {
    [InitializeOnLoadMethod]
    public static void ApplyConfiguration()
    {
      JsonConfiguration.ConfigureNewtonsoftDefaults();
    }
  }
}
#endif
using UnityEngine;

namespace AbandonedCrypt.JSON
{
  public static class RuntimeConfiguration
  {
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    public static void ApplyConfiguration()
    {
      JsonConfiguration.ConfigureNewtonsoftDefaults();
    }
  }
}
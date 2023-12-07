using BepInEx;
using HarmonyLib;

namespace LCCE
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        private const string modGUID = "Stoneman.LCCE";
        private const string modName = "Lethal Company Community Edition";
        private const string modVersion = "1.0.0";
        private const string modAuthor = "Stoneman";
        public static bool Initialized { get; private set; }
        internal static ManualLogSource Log;
        private void Awake()
        {
            Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");

            Log = Logger;
        }

        internal void Start()
        {
            Initialized = true;

            GameObject gameObject = new GameObject("LCCE");
            DontDestroyOnLoad(gameObject);
        }
    }
}
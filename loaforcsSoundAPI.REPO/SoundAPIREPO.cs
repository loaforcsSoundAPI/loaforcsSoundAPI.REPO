using System.Reflection;
using BepInEx;
using BepInEx.Logging;
using HarmonyLib;

namespace loaforcsSoundAPI.REPO;

[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
public class SoundAPIREPO : BaseUnityPlugin {
	public static SoundAPIREPO Instance { get; private set; }
	internal new static ManualLogSource Logger { get; private set; }

	private void Awake() {
		Logger = BepInEx.Logging.Logger.CreateLogSource(MyPluginInfo.PLUGIN_GUID);
		Instance = this;

		Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), MyPluginInfo.PLUGIN_GUID);
		
		Logger.LogInfo($"{MyPluginInfo.PLUGIN_GUID} has loaded :3");
	}
}
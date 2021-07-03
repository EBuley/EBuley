using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using HarmonyLib;
using QModManager.API.ModLoading;
using Logger = QModManager.Utility.Logger;

namespace SubnauticaModding
{
    public class QMod
    {
    }
}
[QModPatch]
public static void Patch()
{
    var assembly = Assembly.GetExecutingAssembly();
    var SubnauticaModding = ($"Strands_{assembly.GetName().name}");
    Logger.Log(Logger.Level.Info, $"Patching {SubnauticaModding}");
    Harmony harmony = new Harmony(SubnauticaModding);
    harmony.PatchAll(assembly);
    Logger.Log(Logger.Level.Info, "Patched Successfully");
}
var SubnauticaModding = ($"Strands{Assembly.GetName().name}");
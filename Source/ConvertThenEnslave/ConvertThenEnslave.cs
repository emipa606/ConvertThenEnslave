using System.Reflection;
using HarmonyLib;
using RimWorld;
using Verse;

namespace ConvertThenEnslave;

[StaticConstructorOnStartup]
public static class ConvertThenEnslave
{
    public static readonly PrisonerInteractionModeDef ConvertThenEnslaveMode;

    static ConvertThenEnslave()
    {
        var harmony = new Harmony("Mlie.ConvertThenEnslave");

        harmony.PatchAll(Assembly.GetExecutingAssembly());
        ConvertThenEnslaveMode = DefDatabase<PrisonerInteractionModeDef>.GetNamedSilentFail("ConvertThenEnslave");
    }
}
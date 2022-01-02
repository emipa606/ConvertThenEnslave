using Verse;

namespace ConvertThenEnslave;

/// <summary>
///     Definition of the settings for the mod
/// </summary>
internal class ConvertThenEnslaveSettings : ModSettings
{
    public bool ReduceResistance = true;

    /// <summary>
    ///     Saving and loading the values
    /// </summary>
    public override void ExposeData()
    {
        base.ExposeData();
        Scribe_Values.Look(ref ReduceResistance, "ReduceResistance", true);
    }
}
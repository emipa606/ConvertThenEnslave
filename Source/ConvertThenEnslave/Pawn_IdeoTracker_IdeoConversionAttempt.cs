﻿using HarmonyLib;
using RimWorld;
using Verse;

namespace ConvertThenEnslave;

[HarmonyPatch(typeof(Pawn_IdeoTracker), "IdeoConversionAttempt")]
public static class Pawn_IdeoTracker_IdeoConversionAttempt
{
    public static void Postfix(bool __result, Pawn ___pawn)
    {
        if (!__result)
        {
            return;
        }

        if (___pawn.guest.interactionMode != ConvertThenEnslave.ConvertThenEnslaveMode)
        {
            return;
        }

        ___pawn.guest.interactionMode = PrisonerInteractionModeDefOf.Enslave;
        var text = "CTE.pawnconverted".Translate(___pawn.NameFullColored);
        var messageType = MessageTypeDefOf.PositiveEvent;
        var message = new Message(text, messageType, new LookTargets(___pawn));
        Messages.Message(message);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HarmonyLib;

/// <summary>
/// See https://github.com/pardeike/Harmony/wiki for a full reference on Harmony.
/// </summary>
namespace BSCheat.HarmonyPatches.Swing
{
    /// <summary>
    /// This patches ClassToPatch.MethodToPatch(Parameter1Type arg1, Parameter2Type arg2)
    /// </summary>
    [HarmonyPatch(typeof(SaberSwingRating), "BeforeCutStepRating")]
    public class Postswing
    {
        static void Postfix(ref float __result)
        {
            // perfect postswing
            __result = 60f;
        }
    }
}
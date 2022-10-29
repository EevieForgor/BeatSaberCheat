using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HarmonyLib;
using UnityEngine;

/// <summary>
/// See https://github.com/pardeike/Harmony/wiki for a full reference on Harmony.
/// </summary>
namespace BSCheat.HarmonyPatches.Swing
{
    /// <summary>
    /// This patches ClassToPatch.MethodToPatch(Parameter1Type arg1, Parameter2Type arg2)
    /// </summary>
    [HarmonyPatch(typeof(GameNoteController), "HandleCut")]
    public class CenterDistance
    {
        static void Prefix(ref GameNoteController __instance, Saber saber, Vector3 cutPoint, Quaternion orientation, Vector3 cutDirVec, bool allowBadCut)
        {
            __instance.noteTransform.position = cutPoint;
        }
    }
}
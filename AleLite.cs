namespace AleLite
{
    using BepInEx;
    using HarmonyLib;
    using EFT.InventoryLogic;
    using static EFT.SkillManager;
    using EFT;

    [BepInPlugin(GUID, NAME, VERSION)]
    public class AleLite : BaseUnityPlugin
    {
        public const string GUID = "com.ehaugw.alelite";
        public const string VERSION = "1.0.0";
        public const string NAME = "Ale Lite";

        internal void Awake()
        {
            var harmony = new Harmony(GUID);
            harmony.PatchAll();
        }

        [HarmonyPatch(typeof(Class1319), nameof(Class1319.method_0))]
        public class Class1319_method_0
        {
            [HarmonyPrefix]
            public static void Prefix(Class1319 __instance, ref SkillManager.GStruct242 movement, ref float __state)
            {
                __state = movement.Overweight;
                if (movement.Overweight > 0f)
                {
                    movement.Overweight = 0;
                }

            }
            [HarmonyPostfix]
            public static void Postfix(Class1319 __instance, ref SkillManager.GStruct242 movement, ref float __state, ref float __result)
            {
                if (__state > 0f)
                {
                    __result *= 0.5f;
                }
                movement.Overweight = __state;
            }
            //public static void Postfix(Class1319 __instance, SkillManager.GStruct242 movement, ref float __result)
            //{
            //    if (movement.Overweight > 0f)
            //    {
            //        __result = __instance.skillManager_0.Settings.Endurance.SprintAction * (1f + __instance.skillManager_0.Settings.Endurance.GainPerFatigueStack * movement.Fatigue) * 0.5f;
            //    }
            //}
        }

        [HarmonyPatch(typeof(Class1319), nameof(Class1319.method_1))]
        public class Class1319_method_1
        {
            [HarmonyPrefix]
            public static void Prefix(Class1319 __instance, ref SkillManager.GStruct242 movement, ref float __state)
            {
                __state = movement.Overweight;
                if (movement.Overweight > 0f)
                {
                    movement.Overweight = 0;
                }

            }
            [HarmonyPostfix]
            public static void Postfix(Class1319 __instance, ref SkillManager.GStruct242 movement, ref float __state, ref float __result)
            {
                if (__state > 0f)
                {
                    __result *= 0.5f;
                }
                movement.Overweight = __state;
            }
            //public static void Postfix(Class1319 __instance, SkillManager.GStruct242 movement, ref float __result)
            //{
            //    if (movement.Overweight > 0f)
            //    {
            //        __result = __instance.skillManager_0.Settings.Endurance.SprintAction * (1f + __instance.skillManager_0.Settings.Endurance.GainPerFatigueStack * movement.Fatigue) * 0.5f;
            //    }
            //}
        }
    }
}

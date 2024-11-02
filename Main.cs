using HarmonyLib;
using ModLoader;
using ModLoader.Helpers;
using SFS.Parts.Modules;
using SFS.Parts;
using SFS;
using UnityEngine;
using System.Linq;

namespace WaterfallSFS
{
    public class Main : Mod
    {

        public override string ModNameID => "waterfallsfs";
        public override string DisplayName => "WaterfallSFS";
        public override string Author => "DanielMoDis";
        public override string MinimumGameVersionNecessary => "1.5.9.8";
        public override string ModVersion => "v1.0.0";
        public override string Description => "Based on the Waterfall mod for Kerbal Space Program, enhances engine exhaust and sound effects";

        // This initializes the patcher. This is required if you use any Harmony patches.
        static Harmony patcher;

        public override void Load()
        {
            // This tells the loader what to run when your mod is loaded.
            Part part = Base.partsLoader.parts[""];
            if (part.GetModules<FlameRandomizer>().First() is FlameRandomizer flame)
            {
                GameObject go = flame.gameObject;
                // ...
            }
        }

        public override void Early_Load()
        {
            // This method runs before anything from the game is loaded. This is where you should apply your patches, as shown below.

            // The patcher uses an ID formatted like a web domain.
            patcher = new Harmony("danielmodis.waterfallsfs.main");

            // This pulls your Harmony patches from everywhere in the namespace and applies them.
            patcher.PatchAll();
        }
    }
}
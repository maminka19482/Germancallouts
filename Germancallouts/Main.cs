using System;
using LSPD_First_Response.Mod.API;
using Rage;

namespace Germancallouts
{
    public class Main : Plugin
    {
        public static String Version = "1.0.0"; // Version of the plugin

        public override void Initialize()
        {
            Functions.OnOnDutyStateChanged += OnOnDutyStateChangedHandler;  // Subscribe to the OnDutyStateChanged event
            Game.LogTrivial("GERMANCALLOUTS: First LSPDFR Plugin Loaded.");
        }

        public override void Finally()
        {
            Game.LogTrivial("[Info] GERMANCALLOUTS: Finished Cleaning Up.");
        }

        private static void OnOnDutyStateChangedHandler(bool OnDuty)
        {
            if (OnDuty)
            {
                Game.DisplayNotification("~b~German Callouts~w~ Version ~g~" + Version + "~w~ by ~y~Maminka1948~w~ Loaded ~b~Successfully!~g~ Enjoy!");  // Display a notification
                Game.LogTrivial("Player Went on Duty. Registering Callouts...");
                RegisterCallouts();
            }
        }

        private static void RegisterCallouts()
        {
            Functions.RegisterCallout(typeof(Germancallouts.Callouts.Klimakleber)); // Register the Klimakleber callout
        }
    }
}
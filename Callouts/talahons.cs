using LSPD_First_Response.Engine;
using LSPD_First_Response.Mod.Callouts;
using Rage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Germancallouts.Callouts
{
    [CalloutInfo("Talahonfight", CalloutProbability.High)]
    
    class Talahonfight : Callout
    {
        private Ped _Talahon1;
        private Ped _Talahon2;

        private Vector3 _Spawnpoint;

        private Blip _sceneblip;

        private Ped Player = Game.LocalPlayer.Character;

        public override bool OnBeforeCalloutDisplayed()
        {
            _Spawnpoint =  World.GetNextPositionOnStreet(Player.Position.Around(100f));

            ShowCalloutAreaBlipBeforeAccepting(_Spawnpoint, 30f);
            CalloutMessage = "Talahonfight";
            CalloutPosition = _Spawnpoint;

            return base.OnBeforeCalloutDisplayed();
        }
        public override bool OnCalloutAccepted()
        {

            return base.OnCalloutAccepted();
        }
        private void Crtalahon()
        {
            _Talahon1 = 
        }
    }
}

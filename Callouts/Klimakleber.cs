using LSPD_First_Response.Engine;
using LSPD_First_Response.Mod.API;
using LSPD_First_Response.Mod.Callouts;
using Rage;
using System;
using System.Collections.Generic;

using System.Drawing;

namespace Germancallouts.Callouts
{
    [CalloutInfo("Klimakleber", CalloutProbability.High)]
    class Klimakleber : Callout

    {
        private List<Vector3> _spawnk = new List<Vector3> {
        new Vector3(158, -528, 40),
        new Vector3(158, -530, 40),
        new Vector3(158, -532, 40),
        new Vector3(158, -534, 40),
        new Vector3(158, -536, 40) 
        }; // TODO: Mehr hinzufügen aber muss dann alles andere umschreiben vllt später
        private Ped _Kleber1;
        private Ped _Kleber2;
        private Ped _Kleber3;
        private Ped _Kleber4;
        private Ped _Kleber5;

        private Ped Player = Game.LocalPlayer.Character;
        private Blip _sceneblip;


        public override bool OnBeforeCalloutDisplayed()
        {
            ShowCalloutAreaBlipBeforeAccepting(_spawnk[2], 20f);
            CalloutMessage = "Klimakleber";
            CalloutPosition = _spawnk[2];
            return base.OnBeforeCalloutDisplayed();
        }
    public override bool OnCalloutAccepted()
    {
            crkleber();
            crblip();
            return base.OnCalloutAccepted();
    }
        private void crkleber()
        {
            _Kleber1 = new Ped("s_m_m_gardener_01", _spawnk[0], 0f);
            _Kleber1.SetRotationRoll(180);
            _Kleber1.BlockPermanentEvents = true;
            _Kleber1.IsPersistent = true;
            
            
            

            _Kleber2 = new Ped("s_m_m_gardener_01", _spawnk[1], 0f);
            _Kleber2.SetRotationRoll(180);
            _Kleber2.BlockPermanentEvents = true;
            _Kleber2.IsPersistent = true;
            
           


            _Kleber3 = new Ped("s_m_m_gardener_01", _spawnk[2], 0f);
            _Kleber3.SetRotationRoll(180);
            _Kleber3.BlockPermanentEvents = true;
            _Kleber3.IsPersistent = true;
            
            

            _Kleber4 = new Ped("s_m_m_gardener_01", _spawnk[3], 0f);
            _Kleber4.SetRotationRoll(180);
            _Kleber4.BlockPermanentEvents = true;
            _Kleber4.IsPersistent = true;
           
           

            _Kleber5 = new Ped("s_m_m_gardener_01", _spawnk[4], 0f);
            _Kleber5.SetRotationRoll(180);

            _Kleber5.BlockPermanentEvents = true;
            _Kleber5.IsPersistent = true;
           
                }

        private void crblip()
        {
            _sceneblip = new Blip(_spawnk[2]);
            _sceneblip.Name = "Klimakleber";
            _sceneblip.IsRouteEnabled = true;
        }
    public override void Process()
    {

        if (Player.DistanceTo(_spawnk[2]) < 20f)
            {
                crsit();
            }
        if (_Kleber1.IsDead && _Kleber2.IsDead && _Kleber3.IsDead && _Kleber4.IsDead && _Kleber5.IsDead)
            {
               
                End();
                return;
            }
            base.Process();
    }
        private void crsit()
        {
            _Kleber1.Tasks.PlayAnimation("anim@amb@business@bgen@bgen_no_work@", "sit_phone_phoneputdown_idle_nowork", 1f, AnimationFlags.Loop);
            _Kleber2.Tasks.PlayAnimation("anim@amb@business@bgen@bgen_no_work@", "sit_phone_phoneputdown_idle_nowork", 1f, AnimationFlags.Loop);
            _Kleber3.Tasks.PlayAnimation("anim@amb@business@bgen@bgen_no_work@", "sit_phone_phoneputdown_idle_nowork", 1f, AnimationFlags.Loop);
            _Kleber4.Tasks.PlayAnimation("anim@amb@business@bgen@bgen_no_work@", "sit_phone_phoneputdown_idle_nowork", 1f, AnimationFlags.Loop);
            _Kleber5.Tasks.PlayAnimation("anim@amb@business@bgen@bgen_no_work@", "sit_phone_phoneputdown_idle_nowork", 1f, AnimationFlags.Loop);




        }

    public override void End()
    {
            if (_Kleber1.Exists()) _Kleber1.Delete();
            if (_Kleber2.Exists()) _Kleber2.Delete();
            if (_Kleber3.Exists()) _Kleber3.Delete();
            if (_Kleber4.Exists()) _Kleber4.Delete();
            if (_Kleber5.Exists()) _Kleber5.Delete();
            if (_sceneblip.Exists()) _sceneblip.Delete();
            base.End();
    }
}
}

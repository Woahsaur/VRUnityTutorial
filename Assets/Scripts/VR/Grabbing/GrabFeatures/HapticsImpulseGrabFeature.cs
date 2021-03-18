using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace VR.Grabbing.GrabFeatures
{
    public class HapticsImpulseGrabFeature : GrabFeature
    {
        [SerializeField] private HapticsImpulse hapticsImpulse;

        protected override void HandleGrabbed()
        {
            base.HandleGrabbed();

            hapticsImpulse.Execute(Grabbable.ActiveGrabber.Hand);
        }
    }
}

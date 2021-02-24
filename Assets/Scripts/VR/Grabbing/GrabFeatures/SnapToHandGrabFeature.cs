using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace VR.Grabbing.GrabFeatures
{
    public class SnapToHandGrabFeature : GrabFeature
    {
        protected override void HandleUpdate()
        {
            base.HandleUpdate();

            if (IsGrabbed)
            {
                transform.position = Grabbable.ActiveGrabber.transform.position;
                transform.rotation = Grabbable.ActiveGrabber.transform.rotation;
            }
        }
    }
}

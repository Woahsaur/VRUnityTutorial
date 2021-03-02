using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace VR.Grabbing.GrabFeatures
{
    public class PhysicsGrabFeature : GrabFeature
    {
        [SerializeField] private PhysicsObject physicsObject;

        protected override void HandleStart()
        {
            base.HandleStart();

            if (physicsObject == null)
            {
                physicsObject = GetComponent<PhysicsObject>();
            }
        }

        protected override void HandleGrabbed()
        {
            base.HandleGrabbed();

            physicsObject.OnGrabbed(Grabbable.ActiveGrabber);
        }

        protected override void HandleLetGo()
        {
            base.HandleLetGo();

            physicsObject.OnLetGo(Grabbable.ActiveGrabber);
        }

        protected override void HandleGrabberLostControl()
        {
            base.HandleGrabberLostControl();

            physicsObject.RemoveGrabber(Grabbable.ActiveGrabber);
        }
    }
}

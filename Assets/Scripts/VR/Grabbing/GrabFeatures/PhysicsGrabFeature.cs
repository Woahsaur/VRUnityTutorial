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
        [SerializeField] private Rigidbody rigidBody;
        [SerializeField] private float throwSpeedMultiplier = 1f;

        protected override void HandleStart()
        {
            base.HandleStart();

            if (rigidBody == null)
            {
                rigidBody = GetComponent<Rigidbody>();
            }
        }

        protected override void HandleGrabbed()
        {
            base.HandleGrabbed();

            rigidBody.isKinematic = true;
            rigidBody.useGravity = false;
        }

        protected override void HandleLetGo()
        {
            base.HandleLetGo();

            rigidBody.isKinematic = false;
            rigidBody.useGravity = true;

            rigidBody.velocity = Grabbable.ActiveGrabber.Velocity * throwSpeedMultiplier;
            rigidBody.angularVelocity = Grabbable.ActiveGrabber.AngularVelocity;
        }
    }
}

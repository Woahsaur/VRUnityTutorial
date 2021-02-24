using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace VR.Grabbing
{
    public class GrabManager : MonoBehaviour
    {
        [SerializeField] private HandInput hand;
        [SerializeField] private float grabRadius;
        [SerializeField] private LayerMask grabLayer;

        private Grabbable activeGrabbable;

        public Vector3 Velocity { get; private set; }

        public Vector3 AngularVelocity { get; private set; }

        private void Start()
        {
            InputController.Instance.RegisterGripTriggeredNotify(hand, HandleGripTriggered);
            InputController.Instance.RegisterGripCanceledNotify(hand, HandleGripCanceled);
            InputController.Instance.RegisterDeviceVelocityNotify(hand, HandleVelocity);
            InputController.Instance.RegisterDeviceAngularVelocityNotify(hand, HandleAngularVelocity);
        }

        private void HandleGripTriggered()
        {
            var collisions = Physics.OverlapSphere(transform.position, grabRadius, grabLayer);

            Grabbable testedGrabbable = null;
            float distance = float.PositiveInfinity;

            for(var i = 0; i < collisions.Length; i++)
            {
                var testDistance = (collisions[i].transform.position - transform.position).sqrMagnitude;

                if(testDistance < distance)
                {
                    testedGrabbable = collisions[i].GetComponentInParent<Grabbable>();
                    distance = testDistance;
                }
            }

            if (testedGrabbable != null)
            {
                PerformGrab(testedGrabbable);
            }
        }

        private void PerformGrab(Grabbable grabbable)
        {
            if (activeGrabbable == grabbable)
                return;

            if (activeGrabbable != null)
            {
                activeGrabbable.LetGo();
            }

            activeGrabbable = grabbable;
            activeGrabbable.Grab(this);
        }

        private void HandleGripCanceled()
        {
            if (activeGrabbable != null)
            {
                activeGrabbable.LetGo();
                activeGrabbable = null;
            }
        }

        private void HandleVelocity(Vector3 deviceVelocity)
        {
            Velocity = deviceVelocity;
        }

        private void HandleAngularVelocity(Vector3 deviceAngularVelocity)
        {
            AngularVelocity = deviceAngularVelocity;
        }

        public void LostControlOfGrabbable(Grabbable grabbable)
        {
            if (activeGrabbable == grabbable)
            {
                activeGrabbable = null;
            }
        }
    }
}

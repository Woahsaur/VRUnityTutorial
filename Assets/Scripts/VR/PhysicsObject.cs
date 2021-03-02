using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using VR.Grabbing;

namespace VR
{
    [RequireComponent(typeof(Rigidbody))]
    public class PhysicsObject : MonoBehaviour
    {
        [SerializeField] private float throwSpeedMultiplier;

        private Rigidbody rigidBody;
        private List<GrabManager> activeGrabbers = new List<GrabManager>();

        private void Awake()
        {
            rigidBody = GetComponent<Rigidbody>();
        }

        public void OnGrabbed(GrabManager grabManager)
        {
            if (!activeGrabbers.Contains(grabManager))
            {
                activeGrabbers.Add(grabManager);
            }


            rigidBody.isKinematic = true;
            rigidBody.useGravity = false;
        }

        public void OnLetGo(GrabManager grabManager)
        {
            RemoveGrabber(grabManager);

            if (activeGrabbers.Count == 0)
            {
                rigidBody.isKinematic = false;
                rigidBody.useGravity = true;

                rigidBody.velocity = grabManager.Velocity * throwSpeedMultiplier;
                rigidBody.angularVelocity = grabManager.AngularVelocity;
            }
        }

        public void RemoveGrabber(GrabManager grabber)
        {
            if (activeGrabbers.Contains(grabber))
            {
                activeGrabbers.Remove(grabber);
            }
        }
    }
}

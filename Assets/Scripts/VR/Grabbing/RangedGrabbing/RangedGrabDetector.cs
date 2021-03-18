using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace VR.Grabbing.RangedGrabbing
{
    [RequireComponent(typeof(GrabManager))]
    public class RangedGrabDetector : MonoBehaviour
    {
        [SerializeField] private LayerMask rangedGrabZoneLayer;
        [SerializeField] private float detectionRange;

        private GrabManager grabManager;

        public RangedGrabTarget ActiveRangedGrabTarget { get; private set; }

        private void Start()
        {
            grabManager = GetComponent<GrabManager>();
        }

        private void Update()
        {
            if (grabManager.HasActiveGrabbable())
                return;

            if (Physics.Raycast(new Ray(transform.position, transform.forward), out var hit, detectionRange, rangedGrabZoneLayer))
            {
                var rangedGrabTarget = hit.collider.GetComponent<RangedGrabTarget>();
                if (rangedGrabTarget != null && rangedGrabTarget != ActiveRangedGrabTarget)
                {
                    if (ActiveRangedGrabTarget != null)
                    {
                        ActiveRangedGrabTarget.Untarget();
                    }

                    ActiveRangedGrabTarget = rangedGrabTarget;

                    ActiveRangedGrabTarget.Target();
                }
            }
            else if (ActiveRangedGrabTarget != null)
            {
                ActiveRangedGrabTarget.Untarget();
                ActiveRangedGrabTarget = null;
            }
        }

        public bool HasActiveRangedGrabTarget()
        {
            return ActiveRangedGrabTarget != null;
        }
    }
}

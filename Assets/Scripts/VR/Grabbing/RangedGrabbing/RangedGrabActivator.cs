using Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace VR.Grabbing.RangedGrabbing
{
    [RequireComponent(typeof(GrabManager))]
    [RequireComponent(typeof(RangedGrabDetector))]
    public class RangedGrabActivator : MonoBehaviour
    {
        [SerializeField] private bool flickActivated;
        [SerializeField] private float flickBeginThreshold;
        [SerializeField] private float flickEndThreshold;
        [SerializeField] private float rangedGrabDuration;

        private GrabManager grabManager;
        private RangedGrabDetector rangedGrabDetector;
        private RangedGrabTarget activeRangedGrabTarget;
        private bool executingRangedGrab;
        private bool brokeThreshold;

        private void Start()
        {
            grabManager = GetComponent<GrabManager>();
            rangedGrabDetector = GetComponent<RangedGrabDetector>();
            InputController.Instance.RegisterGripTriggeredNotify(grabManager.Hand, HandleGrabTriggered);
            InputController.Instance.RegisterGripCanceledNotify(grabManager.Hand, HandleGripLetGo);

            if (flickActivated)
            {
                InputController.Instance.RegisterDeviceAngularVelocityNotify(grabManager.Hand, HandleAngularVelocityChange);
            }
            else
            {
                InputController.Instance.RegisterTriggerTriggeredNotify(grabManager.Hand, HandleTriggerTriggered);
            }
        }

        private void HandleGrabTriggered()
        {
            if (!grabManager.HasActiveGrabbable() && rangedGrabDetector.HasActiveRangedGrabTarget())
            {
                activeRangedGrabTarget = rangedGrabDetector.ActiveRangedGrabTarget;
            }
        }

        private void HandleGripLetGo()
        {
            if (activeRangedGrabTarget != null)
            {
                activeRangedGrabTarget = null; 

                if (executingRangedGrab)
                {
                    StopAllCoroutines();
                }
            }
        }

        private void HandleAngularVelocityChange(Vector3 angularVelocity)
        {
            var speed = angularVelocity.magnitude;

            if (activeRangedGrabTarget != null)
            {
                brokeThreshold = HasFlickBegun(speed);
            
                if (HasFlickEnded(speed) && !executingRangedGrab)
                {
                    StartCoroutine(ExecuteFlickRangedGrab());
                    brokeThreshold = false;
                }
            }
            else
            {
                brokeThreshold = false;
            }
        }

        private bool HasFlickBegun(float speed)
        {
            return brokeThreshold ? true : (speed > flickBeginThreshold);
        }

        private bool HasFlickEnded(float speed)
        {
            return brokeThreshold ? (speed < flickEndThreshold) : false;
        }

        private IEnumerator ExecuteFlickRangedGrab()
        {
            var executionTime = 0f;
            var originPosition = activeRangedGrabTarget.transform.parent.position;
            var originRotation = activeRangedGrabTarget.transform.parent.rotation;
            var distance = (activeRangedGrabTarget.transform.position - transform.position).magnitude;
            var midPoint = transform.position + transform.forward * distance * 1.25f;

            if (activeRangedGrabTarget.transform.parent.GetComponent<Rigidbody>())
            {
                activeRangedGrabTarget.transform.parent.GetComponent<Rigidbody>().isKinematic = true;
                activeRangedGrabTarget.transform.parent.GetComponent<Rigidbody>().useGravity = false;
            }

            executingRangedGrab = true;

            while (executionTime < rangedGrabDuration)
            {
                if (activeRangedGrabTarget == null)
                    break;

                executionTime += Time.deltaTime;

                var percentT = executionTime / rangedGrabDuration;

                activeRangedGrabTarget.transform.parent.position = CalculateCurvedPoint(originPosition, midPoint, grabManager.transform.position, percentT);
                activeRangedGrabTarget.transform.parent.rotation = Quaternion.Slerp(originRotation, grabManager.transform.rotation, percentT * percentT);

                yield return new WaitForEndOfFrame();
            }

            if (activeRangedGrabTarget != null)
            {
                if (activeRangedGrabTarget.transform.parent.GetComponent<Rigidbody>())
                {
                    activeRangedGrabTarget.transform.parent.GetComponent<Rigidbody>().isKinematic = false;
                    activeRangedGrabTarget.transform.parent.GetComponent<Rigidbody>().useGravity = true;
                }

                grabManager.PerformGrab(activeRangedGrabTarget.Grabbable);
                activeRangedGrabTarget = null;
            }


            executingRangedGrab = false;
        }

        private Vector3 CalculateCurvedPoint(Vector3 origin, Vector3 mid, Vector3 end, float percentageComplete)
        {
            return Vector3.Lerp(Vector3.Lerp(origin, mid, percentageComplete), Vector3.Lerp(mid, end, percentageComplete), percentageComplete);
        }
        private void HandleTriggerTriggered()
        {
            if (activeRangedGrabTarget != null && !executingRangedGrab)
            {
                StartCoroutine(ExecuteRangedGrab());
            }
        }

        private IEnumerator ExecuteRangedGrab()
        {
            var executionTime = 0f;
            var originPosition = activeRangedGrabTarget.transform.parent.position;
            var originRotation = activeRangedGrabTarget.transform.parent.rotation;

            executingRangedGrab = true;

            if (activeRangedGrabTarget.transform.parent.GetComponent<Rigidbody>())
            {
                activeRangedGrabTarget.transform.parent.GetComponent<Rigidbody>().isKinematic = true;
                activeRangedGrabTarget.transform.parent.GetComponent<Rigidbody>().useGravity = false;
            }

            while (executionTime < rangedGrabDuration)
            {
                if (activeRangedGrabTarget == null)
                    break;

                executionTime += Time.deltaTime;

                var percentT = executionTime / rangedGrabDuration;

                activeRangedGrabTarget.transform.parent.position = Vector3.Lerp(originPosition, grabManager.transform.position, percentT * percentT);
                activeRangedGrabTarget.transform.parent.rotation = Quaternion.Slerp(originRotation, grabManager.transform.rotation, percentT * percentT);

                yield return new WaitForEndOfFrame();
            }

            if (activeRangedGrabTarget != null)
            {
                if (activeRangedGrabTarget.transform.parent.GetComponent<Rigidbody>())
                {
                    activeRangedGrabTarget.transform.parent.GetComponent<Rigidbody>().isKinematic = false;
                    activeRangedGrabTarget.transform.parent.GetComponent<Rigidbody>().useGravity = true;
                }

                grabManager.PerformGrab(activeRangedGrabTarget.Grabbable);
                activeRangedGrabTarget = null;
            }

            executingRangedGrab = false;
        }
    }
}

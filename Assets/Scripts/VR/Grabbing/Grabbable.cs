using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;
using VR.Grabbing.GrabFeatures;

namespace VR.Grabbing
{
    public class Grabbable : MonoBehaviour
    {
        [SerializeField] private UnityEvent onGrabbed;
        [SerializeField] private UnityEvent onLetGo;

        public GrabManager ActiveGrabber { get; private set; }

        public void Grab(GrabManager grabManager)
        {
            if (ActiveGrabber != null)
            {
                ActiveGrabber.LostControlOfGrabbable(this);
            }

            ActiveGrabber = grabManager;
            onGrabbed.Invoke();
        }

        public void LetGo()
        {
            onLetGo.Invoke();
            ActiveGrabber = null;
        }

        public void RegisterGrabFeature(GrabFeature grabFeature)
        {
            onGrabbed.AddListener(grabFeature.OnGrabbed);
            onLetGo.AddListener(grabFeature.OnLetGo);
        }
    }
}

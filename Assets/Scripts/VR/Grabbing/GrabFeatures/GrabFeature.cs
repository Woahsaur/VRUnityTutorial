using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace VR.Grabbing.GrabFeatures
{
    public abstract class GrabFeature : MonoBehaviour
    {
        [field:SerializeField] public Grabbable Grabbable { get; private set; }

        public bool IsGrabbed { get; private set; }

        private void Start()
        {
            if (Grabbable == null)
            {
                Grabbable = GetComponent<Grabbable>();
            }

            if (Grabbable != null)
            {
                Grabbable.RegisterGrabFeature(this);
            }

            HandleStart();
        }

        protected virtual void HandleStart()
        {

        }

        private void Update()
        {
            HandleUpdate();
        }

        protected virtual void HandleUpdate()
        {

        }

        public void OnGrabbed()
        {
            IsGrabbed = true;
            HandleGrabbed();
        }

        protected virtual void HandleGrabbed()
        {

        }

        public void OnLetGo()
        {
            IsGrabbed = false;
            HandleLetGo();
        }

        protected virtual void HandleLetGo()
        {

        }

        public void OnGraberLostControl()
        {
            IsGrabbed = false;
            HandleGrabberLostControl();
        }

        protected virtual void HandleGrabberLostControl()
        {

        }
    }
}

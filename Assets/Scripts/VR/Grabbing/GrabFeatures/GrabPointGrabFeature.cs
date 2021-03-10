using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Weapons;

namespace VR.Grabbing.GrabFeatures
{
    public enum GrabPointPriority
    {
        None,
        Primary,
        Secondary
    }

    public class GrabPointGrabFeature : GrabFeature
    {
        [SerializeField] private GrabPointPriority priority;
        [SerializeField] private Weapon weapon;

        public GrabPointPriority Priority => priority;

        public Vector3 Offset { get; private set; }

        protected override void HandleStart()
        {
            base.HandleStart();

            if (weapon == null)
            {
                weapon = GetComponentInParent<Weapon>();
            }

            Offset = transform.localPosition;
        }

        protected override void HandleGrabbed()
        {
            base.HandleGrabbed();

            weapon.Grab(this);
        }

        protected override void HandleLetGo()
        {
            base.HandleLetGo();

            weapon.LetGo(this);
        }
    }
}

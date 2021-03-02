using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using VR.Grabbing.GrabFeatures;

namespace Weapons.WeaponFeatures
{
    public abstract class WeaponFeature : MonoBehaviour
    {
        [SerializeField] private Weapon weapon;

        private List<GrabPointGrabFeature> activeGrabPoints = new List<GrabPointGrabFeature>();

        private void Start()
        {
            if (weapon == null)
            {
                weapon = GetComponentInParent<Weapon>();
            }

            if (weapon != null)
            {
                weapon.RegisterWeaponFeature(this);
            }
        }

        public void WeaponGrabPointGrabbed(GrabPointGrabFeature grabPoint)
        {
            if (!activeGrabPoints.Contains(grabPoint))
            {
                activeGrabPoints.Add(grabPoint);
            }

            HandleGrabPointGrabbed(grabPoint);
        }

        protected virtual void HandleGrabPointGrabbed(GrabPointGrabFeature grabPoint)
        {

        }

        public void WeaponGrabPointLetGo(GrabPointGrabFeature grabPoint)
        {
            if (activeGrabPoints.Contains(grabPoint))
            {
                activeGrabPoints.Remove(grabPoint);
            }
        }

        protected virtual void HandleGrabPointLetGo(GrabPointGrabFeature grabPoint)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using VR.Grabbing;
using VR.Grabbing.GrabFeatures;
using Weapons.WeaponFeatures;

namespace Weapons
{
    public class Weapon : MonoBehaviour
    {
        private GrabPointGrabFeature primaryGrabPoint;
        private GrabPointGrabFeature secondaryGrabPoint;

        private GrabManager primaryGrabManager;
        private GrabManager secondaryGrabManager;

        private Action<GrabPointGrabFeature> onWeaponGrabPointGrabbed;
        private Action<GrabPointGrabFeature> onWeaponGrabPointLetGo;

        private bool isGrabbed;

        public void Grab(GrabPointGrabFeature grabbedPoint)
        {
            if (grabbedPoint.Priority == GrabPointPriority.Primary)
            {
                primaryGrabPoint = grabbedPoint;
                primaryGrabManager = primaryGrabPoint.Grabbable.ActiveGrabber;

                onWeaponGrabPointGrabbed?.Invoke(primaryGrabPoint);
            }
            else
            {
                secondaryGrabPoint = grabbedPoint;
                secondaryGrabManager = secondaryGrabPoint.Grabbable.ActiveGrabber;

                onWeaponGrabPointGrabbed?.Invoke(secondaryGrabPoint);
            }

            isGrabbed = true;
        }

        public void LetGo(GrabPointGrabFeature letGoPoint)
        {
            switch(letGoPoint.Priority)
            {
                case GrabPointPriority.Primary:
                    onWeaponGrabPointLetGo?.Invoke(primaryGrabPoint);
                    primaryGrabPoint = null;
                    break;
                case GrabPointPriority.Secondary:
                    onWeaponGrabPointLetGo?.Invoke(secondaryGrabPoint);
                    secondaryGrabPoint = null;
                    break;
            }

            isGrabbed = primaryGrabPoint != null || secondaryGrabPoint != null;
        }

        public void RegisterWeaponFeature(WeaponFeature weaponFeature)
        {
            onWeaponGrabPointGrabbed += weaponFeature.WeaponGrabPointGrabbed;
            onWeaponGrabPointLetGo += weaponFeature.WeaponGrabPointLetGo;
        }

        private void Update()
        {
            if (isGrabbed)
            {
                if (primaryGrabPoint != null)
                {
                    transform.position = primaryGrabManager.transform.position - transform.TransformDirection(primaryGrabPoint.Offset);

                    if (secondaryGrabPoint == null)
                    {
                        transform.rotation = primaryGrabManager.transform.rotation;
                    }
                    else
                    {
                        transform.rotation = Quaternion.LookRotation(secondaryGrabManager.transform.position - primaryGrabManager.transform.position, primaryGrabManager.transform.up);
                    }
                }
                else
                {
                    transform.position = secondaryGrabManager.transform.position - transform.TransformDirection(secondaryGrabPoint.Offset);
                }
            }
        }
    }
}

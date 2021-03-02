using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using VR.Grabbing.GrabFeatures;
using Weapons.Projectiles;

namespace Weapons.WeaponFeatures
{
    public class ProjectileWeaponFeature : WeaponFeature
    {
        [SerializeField] private Projectile projectileTemplate;
        [SerializeField] private Vector3 muzzlePosition;

        protected override void HandleGrabPointGrabbed(GrabPointGrabFeature grabPoint)
        {
            base.HandleGrabPointGrabbed(grabPoint);

            if (grabPoint.Priority == GrabPointPriority.Primary)
            {
                InputController.Instance.RegisterTriggerTriggeredNotify(grabPoint.Grabbable.ActiveGrabber.Hand, HandleTriggerTriggered);
            }
        }

        private void HandleTriggerTriggered()
        {
            var projectileInstance = Instantiate(projectileTemplate, transform.TransformPoint(muzzlePosition), Quaternion.identity);
            projectileInstance.Fire(transform.forward);
        }

        protected override void HandleGrabPointLetGo(GrabPointGrabFeature grabPoint)
        {
            base.HandleGrabPointLetGo(grabPoint);

            if (grabPoint.Priority == GrabPointPriority.Primary)
            {
                InputController.Instance.UnregisterTriggerTriggeredNotify(grabPoint.Grabbable.ActiveGrabber.Hand, HandleTriggerTriggered);
            }
        }
    }
}

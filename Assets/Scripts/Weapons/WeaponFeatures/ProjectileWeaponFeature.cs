using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;
using VR;
using VR.Grabbing;
using VR.Grabbing.GrabFeatures;
using Weapons.Projectiles;

namespace Weapons.WeaponFeatures
{
    public class ProjectileWeaponFeature : WeaponFeature
    {
        [SerializeField] private Projectile projectileTemplate;
        [SerializeField] private Vector3 muzzlePosition;
        [SerializeField] private UnityEvent<HandInput> onProjectileFired;

        private GrabManager activeGrabber;


        protected override void HandleGrabPointGrabbed(GrabPointGrabFeature grabPoint)
        {
            base.HandleGrabPointGrabbed(grabPoint);

            if (grabPoint.Priority == GrabPointPriority.Primary)
            {
                if (activeGrabber != null && activeGrabber != grabPoint.Grabbable.ActiveGrabber)
                {
                    InputController.Instance.UnregisterTriggerTriggeredNotify(activeGrabber.Hand, HandleTriggerTriggered);
                }

                InputController.Instance.RegisterTriggerTriggeredNotify(grabPoint.Grabbable.ActiveGrabber.Hand, HandleTriggerTriggered);
            }

            activeGrabber = grabPoint.Grabbable.ActiveGrabber;
        }

        private void HandleTriggerTriggered()
        {
            var projectileInstance = Instantiate(projectileTemplate, transform.TransformPoint(muzzlePosition), Quaternion.identity);
            projectileInstance.Fire(transform.forward);
            onProjectileFired.Invoke(activeGrabber.Hand);
        }

        protected override void HandleGrabPointLetGo(GrabPointGrabFeature grabPoint)
        {
            base.HandleGrabPointLetGo(grabPoint);

            if (grabPoint.Priority == GrabPointPriority.Primary)
            {
                InputController.Instance.UnregisterTriggerTriggeredNotify(grabPoint.Grabbable.ActiveGrabber.Hand, HandleTriggerTriggered);
            }

            activeGrabber = null;
        }
    }
}

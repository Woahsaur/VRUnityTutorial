using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace VR
{
    public class DebugHand : MonoBehaviour
    {
        [SerializeField] private HandInput hand;
        [SerializeField] private bool debugGrip;
        [SerializeField] private bool debugTrigger;
        [SerializeField] private bool debugThumbstick;
        [SerializeField] private bool debugPrimaryButton;
        [SerializeField] private bool debugSecondaryButton;
        [SerializeField] private bool debugPosition;
        [SerializeField] private bool debugRotation;
        [SerializeField] private bool debugVelocity;
        [SerializeField] private bool debugAngularVelocity;

        private void Start()
        {
            if (debugGrip)
            {
                InputController.Instance.RegisterGripTriggeredNotify(hand, () => WriteDebugLine("Grip Triggered"));
                InputController.Instance.RegisterGripStrengthNotify(hand, value => WriteDebugLine($"Grip Strength - {(int)(value * 100f)}"));
            }

            if (debugTrigger)
            {
                InputController.Instance.RegisterTriggerTriggeredNotify(hand, () => WriteDebugLine("Trigger Triggered"));
                InputController.Instance.RegisterTriggerStrengthNotify(hand, value => WriteDebugLine($"Trigger Strength - {(int)(value * 100f)}"));
            }

            if (debugThumbstick)
            {
                InputController.Instance.RegisterThumbstickTouchedNotify(hand, () => WriteDebugLine("Thumbstick Touched"));
                InputController.Instance.RegisterThumbstickTriggeredNotify(hand, () => WriteDebugLine("Thumbstick Triggered"));
                InputController.Instance.RegisterThumbstickDirectionNotify(hand, value => WriteDebugLine($"Thumbstick Direction - {value}"));
            }

            if (debugPrimaryButton)
            {
                InputController.Instance.RegisterPrimaryButtonTouchedNotifies(hand, () => WriteDebugLine("Primary Button Touched"));
                InputController.Instance.RegisterPrimaryButtonTriggeredNotifies(hand, () => WriteDebugLine("Primary Button Triggered"));
            }

            if (debugSecondaryButton)
            {
                InputController.Instance.RegisterSecondaryButtonTouchedNotifies(hand, () => WriteDebugLine("Secondary Button Touched"));
                InputController.Instance.RegisterSecondaryButtonTriggeredNotifies(hand, () => WriteDebugLine("Secondary Button Triggered"));
            }

            if (debugPosition)
            {
                InputController.Instance.RegisterDevicePositionNotify(hand, value => WriteDebugLine($"Position - {value}"));
            }

            if (debugRotation)
            {
                InputController.Instance.RegisterDeviceRotationNotify(hand, value => WriteDebugLine($"Rotation - {value}"));
            }

            if (debugVelocity)
            {
                InputController.Instance.RegisterDeviceVelocityNotify(hand, value => WriteDebugLine($"Velocity - {value}"));
            }

            if (debugAngularVelocity)
            {
                InputController.Instance.RegisterDeviceAngularVelocityNotify(hand, value => WriteDebugLine($"Angular Velocity - {value}"));
            }
        }

        private void WriteDebugLine(string message)
        {
            Debug.Log($"{hand}: {message}");
        }
    }
}

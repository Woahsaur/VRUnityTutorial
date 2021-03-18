using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.XR.Haptics;
using VR;

namespace Core
{
    public class InputController : MonoBehaviour
    {
        public static InputController Instance { get; set; }
        
        private CoreInputActions inputActions;

        // Grip
        public List<Action>[] gripTriggeredNotifies = new List<Action>[2];
        public List<Action>[] gripCanceledNotifies = new List<Action>[2];
        public List<Action<float>>[] gripStrengthNotifies = new List<Action<float>>[2];

        // Trigger
        public List<Action>[] triggerTriggeredNotifies = new List<Action>[2];
        public List<Action>[] triggerCanceledNotifies = new List<Action>[2];
        public List<Action<float>>[] triggerStrengthNotifies = new List<Action<float>>[2];

        // Thumbstick
        public List<Action>[] thumbstickTouchedNotifies = new List<Action>[2];
        public List<Action>[] thumbstickTriggeredNotifies = new List<Action>[2];
        public List<Action<Vector2>>[] thumbstickDirectionNotifies = new List<Action<Vector2>>[2];

        // Primary Button
        public List<Action>[] primaryButtonTouchedNotifies = new List<Action>[2];
        public List<Action>[] primaryButtonTriggeredNotifies = new List<Action>[2];

        // Secondary Button
        public List<Action>[] secondaryButtonTouchedNotifies = new List<Action>[2];
        public List<Action>[] secondaryButtonTriggeredNotifies = new List<Action>[2];

        // Device Details
        public List<Action<Vector3>>[] devicePositionNotifies = new List<Action<Vector3>>[2];
        public List<Action<Quaternion>>[] deviceRotationNotifies = new List<Action<Quaternion>>[2];
        public List<Action<Vector3>>[] deviceVelocityNotifies = new List<Action<Vector3>>[2];
        public List<Action<Vector3>>[] deviceAngularVelocityNotifies = new List<Action<Vector3>>[2];

        public InputDevice[] XRControllers { get; private set; }

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                inputActions = new CoreInputActions();
                PopulateDefaultNotifyLists();
                PopulateXRControllers();
            }
            else if(Instance != this)
            {
                Destroy(this);
            }
        }

        private void PopulateDefaultNotifyLists()
        {
            for(var i = 0; i < 2; i++)
            {
                gripTriggeredNotifies[i] = new List<Action>();
                gripCanceledNotifies[i] = new List<Action>();
                gripStrengthNotifies[i] = new List<Action<float>>();

                triggerTriggeredNotifies[i] = new List<Action>();
                triggerCanceledNotifies[i] = new List<Action>();
                triggerStrengthNotifies[i] = new List<Action<float>>();

                thumbstickTouchedNotifies[i] = new List<Action>();
                thumbstickTriggeredNotifies[i] = new List<Action>();
                thumbstickDirectionNotifies[i] = new List<Action<Vector2>>();

                primaryButtonTouchedNotifies[i] = new List<Action>();
                primaryButtonTriggeredNotifies[i] = new List<Action>();
                
                secondaryButtonTouchedNotifies[i] = new List<Action>();
                secondaryButtonTriggeredNotifies[i] = new List<Action>();

                devicePositionNotifies[i] = new List<Action<Vector3>>();
                deviceRotationNotifies[i] = new List<Action<Quaternion>>();
                deviceVelocityNotifies[i] = new List<Action<Vector3>>();
                deviceAngularVelocityNotifies[i] = new List<Action<Vector3>>();
            }
        }

        private void PopulateXRControllers()
        {
            XRControllers = new InputDevice[2];

            InputSystem.onDeviceChange += (device, change) =>
            {
                switch (change)
                {
                    case InputDeviceChange.Added:
                        if (device.usages.Contains(CommonUsages.LeftHand))
                        {
                            XRControllers[(int)HandInput.Left] = device;
                        }
                        if (device.usages.Contains(CommonUsages.RightHand))
                        {
                            XRControllers[(int)HandInput.Right] = device;
                        }
                        break;
                    case InputDeviceChange.Removed:
                        if (device.usages.Contains(CommonUsages.LeftHand))
                        {
                            XRControllers[(int)HandInput.Left] = null;
                        }
                        if (device.usages.Contains(CommonUsages.RightHand))
                        {
                            XRControllers[(int)HandInput.Right] = null;
                        }
                        break;
                    case InputDeviceChange.Reconnected:
                        if (device.usages.Contains(CommonUsages.LeftHand))
                        {
                            XRControllers[(int)HandInput.Left] = device;
                        }
                        if (device.usages.Contains(CommonUsages.RightHand))
                        {
                            XRControllers[(int)HandInput.Right] = device;
                        }
                        break;
                    case InputDeviceChange.Disconnected:
                        if (device.usages.Contains(CommonUsages.LeftHand))
                        {
                            XRControllers[(int)HandInput.Left] = null;
                        }
                        if (device.usages.Contains(CommonUsages.RightHand))
                        {
                            XRControllers[(int)HandInput.Right] = null;
                        }
                        break;
                }
            };
        }

        #region Grip Registers
        public void RegisterGripTriggeredNotify(HandInput handInput, Action notify)
        {
            gripTriggeredNotifies[(int)handInput].Add(notify);
        }

        public void UnregisterGripTriggeredNotify(HandInput handInput, Action notify)
        {
            gripTriggeredNotifies[(int)handInput].Remove(notify);
        }

        public void RegisterGripCanceledNotify(HandInput handInput, Action notify)
        {
            gripCanceledNotifies[(int)handInput].Add(notify);
        }

        public void UnregisterGripCanceledNotify(HandInput handInput, Action notify)
        {
            gripCanceledNotifies[(int)handInput].Remove(notify);
        }

        public void RegisterGripStrengthNotify(HandInput handInput, Action<float> notify)
        {
            gripStrengthNotifies[(int)handInput].Add(notify);
        }

        public void UnregisterGripStrengthNotify(HandInput handInput, Action<float> notify)
        {
            gripStrengthNotifies[(int)handInput].Remove(notify);
        }
        #endregion

        #region Trigger Registers
        public void RegisterTriggerTriggeredNotify(HandInput handInput, Action notify)
        {
            triggerTriggeredNotifies[(int)handInput].Add(notify);
        }

        public void UnregisterTriggerTriggeredNotify(HandInput handInput, Action notify)
        {
            triggerTriggeredNotifies[(int)handInput].Remove(notify);
        }

        public void RegisterTriggerCanceledNotify(HandInput handInput, Action notify)
        {
            triggerCanceledNotifies[(int)handInput].Add(notify);
        }

        public void UnregisterTriggerCanceledNotify(HandInput handInput, Action notify)
        {
            triggerCanceledNotifies[(int)handInput].Remove(notify);
        }

        public void RegisterTriggerStrengthNotify(HandInput handInput, Action<float> notify)
        {
            triggerStrengthNotifies[(int)handInput].Add(notify);
        }

        public void UnregisterTriggerStrengthNotify(HandInput handInput, Action<float> notify)
        {
            triggerStrengthNotifies[(int)handInput].Remove(notify);
        }
        #endregion

        #region Thumbstick Registers
        public void RegisterThumbstickTouchedNotify(HandInput handInput, Action notify)
        {
            thumbstickTouchedNotifies[(int)handInput].Add(notify);
        }

        public void UnregisterThumbstickTouchedNotify(HandInput handInput, Action notify)
        {
            thumbstickTouchedNotifies[(int)handInput].Remove(notify);
        }

        public void RegisterThumbstickTriggeredNotify(HandInput handInput, Action notify)
        {
            thumbstickTriggeredNotifies[(int)handInput].Add(notify);
        }

        public void UnregisterThumbstickTriggeredNotify(HandInput handInput, Action notify)
        {
            thumbstickTriggeredNotifies[(int)handInput].Remove(notify);
        }

        public void RegisterThumbstickDirectionNotify(HandInput handInput, Action<Vector2> notify)
        {
            thumbstickDirectionNotifies[(int)handInput].Add(notify);
        }

        public void UnregisterThumbstickDirectionNotify(HandInput handInput, Action<Vector2> notify)
        {
            thumbstickDirectionNotifies[(int)handInput].Remove(notify);
        }
        #endregion

        #region Primary Button Registers
        public void RegisterPrimaryButtonTouchedNotifies(HandInput handInput, Action notify)
        {
            primaryButtonTouchedNotifies[(int)handInput].Add(notify);
        }

        public void UnregisterPrimaryButtonTouchedNotifies(HandInput handInput, Action notify)
        {
            primaryButtonTouchedNotifies[(int)handInput].Remove(notify);
        }

        public void RegisterPrimaryButtonTriggeredNotifies(HandInput handInput, Action notify)
        {
            primaryButtonTriggeredNotifies[(int)handInput].Add(notify);
        }

        public void UnregisterPrimaryButtonTriggeredNotifies(HandInput handInput, Action notify)
        {
            primaryButtonTriggeredNotifies[(int)handInput].Remove(notify);
        }

        #endregion

        #region Secondary Button Registers
        public void RegisterSecondaryButtonTouchedNotifies(HandInput handInput, Action notify)
        {
            secondaryButtonTouchedNotifies[(int)handInput].Add(notify);
        }

        public void UnregisterSecondaryButtonTouchedNotifies(HandInput handInput, Action notify)
        {
            secondaryButtonTouchedNotifies[(int)handInput].Remove(notify);
        }

        public void RegisterSecondaryButtonTriggeredNotifies(HandInput handInput, Action notify)
        {
            secondaryButtonTriggeredNotifies[(int)handInput].Add(notify);
        }

        public void UnregisterSecondaryButtonTriggeredNotifies(HandInput handInput, Action notify)
        {
            secondaryButtonTriggeredNotifies[(int)handInput].Remove(notify);
        }

        #endregion

        #region Device Details Registers
        public void RegisterDevicePositionNotify(HandInput handInput, Action<Vector3> notify)
        {
            devicePositionNotifies[(int)handInput].Add(notify);
        }

        public void UnregisterDevicePositionNotify(HandInput handInput, Action<Vector3> notify)
        {
            devicePositionNotifies[(int)handInput].Remove(notify);
        }

        public void RegisterDeviceRotationNotify(HandInput handInput, Action<Quaternion> notify)
        {
            deviceRotationNotifies[(int)handInput].Add(notify);
        }

        public void UnregisterDeviceRotationNotify(HandInput handInput, Action<Quaternion> notify)
        {
            deviceRotationNotifies[(int)handInput].Remove(notify);
        }

        public void RegisterDeviceVelocityNotify(HandInput handInput, Action<Vector3> notify)
        {
            deviceVelocityNotifies[(int)handInput].Add(notify);
        }

        public void UnregisterDeviceVelocityNotify(HandInput handInput, Action<Vector3> notify)
        {
            deviceVelocityNotifies[(int)handInput].Remove(notify);
        }

        public void RegisterDeviceAngularVelocityNotify(HandInput handInput, Action<Vector3> notify)
        {
            deviceAngularVelocityNotifies[(int)handInput].Add(notify);
        }

        public void UnregisterDeviceAngularVelocityNotify(HandInput handInput, Action<Vector3> notify)
        {
            deviceAngularVelocityNotifies[(int)handInput].Remove(notify);
        }
        #endregion

        private void Start()
        {
            #region Right Hand Bindings
            inputActions.RightHand.GripTriggered.performed += _ => TriggerActionNotifies(gripTriggeredNotifies[(int)HandInput.Right]);
            inputActions.RightHand.GripTriggered.canceled += _ => TriggerActionNotifies(gripCanceledNotifies[(int)HandInput.Right]);
            inputActions.RightHand.GripStrength.performed += ctx => TriggerNotifies(gripStrengthNotifies[(int)HandInput.Right], ctx.ReadValue<float>());

            inputActions.RightHand.TriggerTriggered.performed += _ => TriggerActionNotifies(triggerTriggeredNotifies[(int)HandInput.Right]);
            inputActions.RightHand.TriggerTriggered.canceled += _ => TriggerActionNotifies(triggerCanceledNotifies[(int)HandInput.Right]);
            inputActions.RightHand.TriggerStrength.performed += ctx => TriggerNotifies(triggerStrengthNotifies[(int)HandInput.Right], ctx.ReadValue<float>());

            inputActions.RightHand.ThumbstickTouch.performed += _ => TriggerActionNotifies(thumbstickTouchedNotifies[(int)HandInput.Right]);
            inputActions.RightHand.ThumbstickTriggered.performed += ctx => TriggerActionNotifies(thumbstickTriggeredNotifies[(int)HandInput.Right]);
            inputActions.RightHand.ThumbstickDirection.performed += ctx => TriggerNotifies(thumbstickDirectionNotifies[(int)HandInput.Right], ctx.ReadValue<Vector2>());

            inputActions.RightHand.PrimaryButtonTouched.performed += _ => TriggerActionNotifies(primaryButtonTouchedNotifies[(int)HandInput.Right]);
            inputActions.RightHand.PrimaryButtonTriggered.performed += ctx => TriggerActionNotifies(primaryButtonTriggeredNotifies[(int)HandInput.Right]);
            
            inputActions.RightHand.SecondaryButtonTouched.performed += _ => TriggerActionNotifies(secondaryButtonTouchedNotifies[(int)HandInput.Right]);
            inputActions.RightHand.SecondaryButtonTriggered.performed += ctx => TriggerActionNotifies(secondaryButtonTriggeredNotifies[(int)HandInput.Right]);

            inputActions.RightHand.DevicePosition.performed += ctx => TriggerNotifies(devicePositionNotifies[(int)HandInput.Right], ctx.ReadValue<Vector3>());
            inputActions.RightHand.DeviceRotation.performed += ctx => TriggerNotifies(deviceRotationNotifies[(int)HandInput.Right], ctx.ReadValue<Quaternion>());
            inputActions.RightHand.DeviceVelocity.performed += ctx => TriggerNotifies(deviceVelocityNotifies[(int)HandInput.Right], ctx.ReadValue<Vector3>());
            inputActions.RightHand.DeviceAngularVelocity.performed += ctx => TriggerNotifies(deviceAngularVelocityNotifies[(int)HandInput.Right], ctx.ReadValue<Vector3>());
            #endregion

            #region Left Hand Bindings
            inputActions.LeftHand.GripTriggered.performed += _ => TriggerActionNotifies(gripTriggeredNotifies[(int)HandInput.Left]);
            inputActions.LeftHand.GripTriggered.canceled += _ => TriggerActionNotifies(gripCanceledNotifies[(int)HandInput.Left]);
            inputActions.LeftHand.GripStrength.performed += ctx => TriggerNotifies(gripStrengthNotifies[(int)HandInput.Left], ctx.ReadValue<float>());

            inputActions.LeftHand.TriggerTriggered.performed += _ => TriggerActionNotifies(triggerTriggeredNotifies[(int)HandInput.Left]);
            inputActions.LeftHand.TriggerTriggered.canceled += _ => TriggerActionNotifies(triggerCanceledNotifies[(int)HandInput.Left]);
            inputActions.LeftHand.TriggerStrength.performed += ctx => TriggerNotifies(triggerStrengthNotifies[(int)HandInput.Left], ctx.ReadValue<float>());

            inputActions.LeftHand.ThumbstickTouch.performed += _ => TriggerActionNotifies(thumbstickTouchedNotifies[(int)HandInput.Left]);
            inputActions.LeftHand.ThumbstickTriggered.performed += ctx => TriggerActionNotifies(thumbstickTriggeredNotifies[(int)HandInput.Left]);
            inputActions.LeftHand.ThumbstickDirection.performed += ctx => TriggerNotifies(thumbstickDirectionNotifies[(int)HandInput.Left], ctx.ReadValue<Vector2>());

            inputActions.LeftHand.PrimaryButtonTouched.performed += _ => TriggerActionNotifies(primaryButtonTouchedNotifies[(int)HandInput.Left]);
            inputActions.LeftHand.PrimaryButtonTriggered.performed += ctx => TriggerActionNotifies(primaryButtonTriggeredNotifies[(int)HandInput.Left]);

            inputActions.LeftHand.SecondaryButtonTouched.performed += _ => TriggerActionNotifies(secondaryButtonTouchedNotifies[(int)HandInput.Left]);
            inputActions.LeftHand.SecondaryButtonTriggered.performed += ctx => TriggerActionNotifies(secondaryButtonTriggeredNotifies[(int)HandInput.Left]);

            inputActions.LeftHand.DevicePosition.performed += ctx => TriggerNotifies(devicePositionNotifies[(int)HandInput.Left], ctx.ReadValue<Vector3>());
            inputActions.LeftHand.DeviceRotation.performed += ctx => TriggerNotifies(deviceRotationNotifies[(int)HandInput.Left], ctx.ReadValue<Quaternion>());
            inputActions.LeftHand.DeviceVelocity.performed += ctx => TriggerNotifies(deviceVelocityNotifies[(int)HandInput.Left], ctx.ReadValue<Vector3>());
            inputActions.LeftHand.DeviceAngularVelocity.performed += ctx => TriggerNotifies(deviceAngularVelocityNotifies[(int)HandInput.Left], ctx.ReadValue<Vector3>());
            #endregion

            inputActions.Enable();
            inputActions.RightHand.Enable();
        }

        private void TriggerNotifies<T>(List<Action<T>> notifies, T value)
        {
            foreach(var notify in notifies)
            {
                notify?.Invoke(value);
            }
        }

        private void TriggerActionNotifies(List<Action> notifies)
        {
            foreach(var notify in notifies)
            {
                notify?.Invoke();
            }
        }

        private void OnDestroy()
        {
            for(var i = 0; i < 2; i++)
            {
                gripStrengthNotifies[i].Clear();
                gripTriggeredNotifies[i].Clear();
            }
        }

        public void SendHaptics(HandInput hand, int channel, float amplitude, float duration)
        {
            if (XRControllers[(int)hand] != null)
            {
                var hapticsRequest = SendHapticImpulseCommand.Create(channel, amplitude, duration);
                XRControllers[(int)hand].ExecuteCommand(ref hapticsRequest);
            }
            else
            {
                Debug.LogWarning("Attempted to send haptics input to a null device.");
            }
        }
    }
}
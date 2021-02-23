// GENERATED AUTOMATICALLY FROM 'Assets/Core/Input/CoreInputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @CoreInputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @CoreInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""CoreInputActions"",
    ""maps"": [
        {
            ""name"": ""RightHand"",
            ""id"": ""82e0e22c-7a84-4198-b2b0-488fa403a637"",
            ""actions"": [
                {
                    ""name"": ""GripStrength"",
                    ""type"": ""Value"",
                    ""id"": ""b44bf793-6517-4e87-94d8-57dbb1d55cee"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""GripTriggered"",
                    ""type"": ""Button"",
                    ""id"": ""337b08b4-bb1b-4520-ab7e-af7d772aa538"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TriggerStrength"",
                    ""type"": ""Value"",
                    ""id"": ""8968ced6-bd71-4d5d-ac35-28090b216c8a"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TriggerTriggered"",
                    ""type"": ""Button"",
                    ""id"": ""f486d1dc-7a50-498f-b4dc-e3d6c908bcdc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ThumbstickTouch"",
                    ""type"": ""Button"",
                    ""id"": ""e415ec7a-7ef0-467c-a223-0228b3830f6d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ThumbstickTriggered"",
                    ""type"": ""Button"",
                    ""id"": ""e66b753d-4ed7-464d-9487-9f8d1995179d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ThumbstickDirection"",
                    ""type"": ""Value"",
                    ""id"": ""24f3f6c5-4d37-4c42-9d47-274e9477ba86"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PrimaryButtonTriggered"",
                    ""type"": ""Button"",
                    ""id"": ""df594fd4-4148-4203-ad0e-358e2bdf216f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PrimaryButtonTouched"",
                    ""type"": ""Button"",
                    ""id"": ""d21fd67e-ccc6-4784-a2f1-66eecc50937c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SecondaryButtonTriggered"",
                    ""type"": ""Button"",
                    ""id"": ""33552d3a-552e-48d7-b404-4267df91ed07"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SecondaryButtonTouched"",
                    ""type"": ""Button"",
                    ""id"": ""2f0f35b3-2590-41a2-93a9-7392b929caf5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DevicePosition"",
                    ""type"": ""Value"",
                    ""id"": ""5b13a01c-7445-49ac-8cf5-d5b29c0c7073"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DeviceRotation"",
                    ""type"": ""Value"",
                    ""id"": ""edd913d9-263d-4bfb-9b47-3f36abafa958"",
                    ""expectedControlType"": ""Quaternion"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DeviceVelocity"",
                    ""type"": ""Value"",
                    ""id"": ""3e1d61b8-c115-4eeb-9383-667895b45134"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DeviceAngularVelocity"",
                    ""type"": ""Value"",
                    ""id"": ""d8dccfe3-90eb-4079-92cb-54b8b0703512"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7e49427a-b2bf-40fe-8568-8fa372509650"",
                    ""path"": ""<XRController>{RightHand}/grip"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GripStrength"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c4a3110e-11b4-41dc-84ab-8b9abb1ac42b"",
                    ""path"": ""<XRController>{RightHand}/gripPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GripTriggered"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a8af932d-2203-4b9c-9248-db07e43217cf"",
                    ""path"": ""<XRController>{RightHand}/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TriggerStrength"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4a0080db-1b7a-450e-ab24-1b2d982cfb55"",
                    ""path"": ""<XRController>{RightHand}/triggerPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TriggerTriggered"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7e0e1311-376f-4e55-b272-aba8fbbe0cb0"",
                    ""path"": ""<XRController>{RightHand}/thumbstickTouched"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ThumbstickTouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""019e7b2c-0208-46ef-87b4-227d36ff186f"",
                    ""path"": ""<XRController>{RightHand}/thumbstickClicked"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ThumbstickTriggered"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0e3c3021-1832-48e5-b42f-13f55e0a49d4"",
                    ""path"": ""<XRController>{RightHand}/thumbstick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ThumbstickDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a3f9ce00-6e46-489f-a71c-385c2f5e2c7b"",
                    ""path"": ""<XRController>{RightHand}/primaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PrimaryButtonTriggered"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bcace62d-43ff-4f88-9d4c-6d726a4ea7dc"",
                    ""path"": ""<XRController>{RightHand}/secondaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SecondaryButtonTriggered"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""10b64606-e57b-41a1-b8bd-e6b564caa288"",
                    ""path"": ""<XRController>{RightHand}/secondaryTouched"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SecondaryButtonTouched"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c0633240-bbde-46c5-bdaa-39416c82e952"",
                    ""path"": ""<XRController>{RightHand}/primaryTouched"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PrimaryButtonTouched"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b790acb2-e145-4a67-9ef0-76c0aa166443"",
                    ""path"": ""<XRController>{RightHand}/devicePosition"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DevicePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f9251734-32e0-4811-a3a2-1aa10b09f36a"",
                    ""path"": ""<XRController>{RightHand}/deviceRotation"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DeviceRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8610b85e-264c-4184-af1c-43fe40a5be1a"",
                    ""path"": ""<XRController>{RightHand}/deviceVelocity"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DeviceVelocity"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b19f6e94-d211-4564-ad31-a90d8b2c1a27"",
                    ""path"": ""<XRController>{RightHand}/deviceAngularVelocity"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DeviceAngularVelocity"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""LeftHand"",
            ""id"": ""c076aa30-f4c6-494d-be1d-6045640d2e3f"",
            ""actions"": [
                {
                    ""name"": ""GripStrength"",
                    ""type"": ""Value"",
                    ""id"": ""b9d9ea3c-fa90-43b4-9623-a1a62935d368"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""GripTriggered"",
                    ""type"": ""Button"",
                    ""id"": ""a86b8591-d1c5-4619-b7fb-7be291fb6b8f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TriggerStrength"",
                    ""type"": ""Value"",
                    ""id"": ""2af63e71-ff20-4467-a267-95eb9a06a545"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TriggerTriggered"",
                    ""type"": ""Button"",
                    ""id"": ""9c723b28-9eba-4480-bd0e-de91a1ce2476"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ThumbstickTouch"",
                    ""type"": ""Button"",
                    ""id"": ""3ec94714-5558-4cb2-a52c-7e38f99532cd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ThumbstickTriggered"",
                    ""type"": ""Button"",
                    ""id"": ""73598262-3973-4bd9-9f96-430ee2294187"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ThumbstickDirection"",
                    ""type"": ""Value"",
                    ""id"": ""62f2c6d7-fb9c-4b04-b0f7-ba7d0a348462"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PrimaryButtonTriggered"",
                    ""type"": ""Button"",
                    ""id"": ""021d27c7-1135-4249-b748-5ab7253a3649"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PrimaryButtonTouched"",
                    ""type"": ""Button"",
                    ""id"": ""32782f04-a0da-456f-98cf-dd10bce290b4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SecondaryButtonTriggered"",
                    ""type"": ""Button"",
                    ""id"": ""4f9ea913-5ac4-4ffc-8c8a-6cf30d6bafcf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SecondaryButtonTouched"",
                    ""type"": ""Button"",
                    ""id"": ""abb0cafa-0fc1-4b10-a552-6634463ecd7c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DevicePosition"",
                    ""type"": ""Value"",
                    ""id"": ""cec2fcca-f059-4d7d-b981-5ab6e1055519"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DeviceRotation"",
                    ""type"": ""Value"",
                    ""id"": ""b5f480d5-5997-4c7b-8d61-8a6a4257b671"",
                    ""expectedControlType"": ""Quaternion"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DeviceVelocity"",
                    ""type"": ""Value"",
                    ""id"": ""433a37ac-ea5c-4904-9657-0b081b6f0c46"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DeviceAngularVelocity"",
                    ""type"": ""Value"",
                    ""id"": ""80a895cf-a0ae-4e19-995d-2760fc194c86"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""08bf50e6-592f-4722-b4ff-66caaac68b9b"",
                    ""path"": ""<XRController>{LeftHand}/grip"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GripStrength"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b3ede174-dba0-420d-9983-c09cfc6ff183"",
                    ""path"": ""<XRController>{LeftHand}/gripPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GripTriggered"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""984a8b23-a432-4341-b51d-b73109430dcc"",
                    ""path"": ""<XRController>{LeftHand}/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TriggerStrength"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b2aac34a-77b5-4a72-b870-dca225c7846c"",
                    ""path"": ""<XRController>{LeftHand}/triggerPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TriggerTriggered"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""699afea8-6386-4316-988b-f321a88febdc"",
                    ""path"": ""<XRController>{LeftHand}/thumbstickTouched"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ThumbstickTouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e2785d07-386c-4516-a463-0e10b2027ae5"",
                    ""path"": ""<XRController>{LeftHand}/thumbstickClicked"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ThumbstickTriggered"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""274a5125-5482-49e6-a5ab-9d7cfc297f33"",
                    ""path"": ""<XRController>{LeftHand}/thumbstick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ThumbstickDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6f1cc722-1f7b-448e-a080-216a6b490208"",
                    ""path"": ""<XRController>{LeftHand}/primaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PrimaryButtonTriggered"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4484349a-8ce6-422e-9485-680528f03e6f"",
                    ""path"": ""<XRController>{LeftHand}/secondaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SecondaryButtonTriggered"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b5d3a4ef-bd0f-4f07-8d2d-e37651d5486a"",
                    ""path"": ""<XRController>{LeftHand}/secondaryTouched"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SecondaryButtonTouched"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""84d72387-ad7c-46d8-a158-43e2e123ee5e"",
                    ""path"": ""<XRController>{LeftHand}/primaryTouched"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PrimaryButtonTouched"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8fcf4f26-8d1f-4951-b50d-22e89972b537"",
                    ""path"": ""<XRController>{LeftHand}/devicePosition"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DevicePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bc5e5b2b-49f9-4d64-ad11-b1f7de472c4e"",
                    ""path"": ""<XRController>{LeftHand}/deviceRotation"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DeviceRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bc6a1902-7f3b-4f47-b0e2-216f9d59d0c6"",
                    ""path"": ""<XRController>{LeftHand}/deviceVelocity"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DeviceVelocity"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3f198e92-5df2-4298-bead-c6d9f1ef3ea0"",
                    ""path"": ""<XRController>{LeftHand}/deviceAngularVelocity"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DeviceAngularVelocity"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // RightHand
        m_RightHand = asset.FindActionMap("RightHand", throwIfNotFound: true);
        m_RightHand_GripStrength = m_RightHand.FindAction("GripStrength", throwIfNotFound: true);
        m_RightHand_GripTriggered = m_RightHand.FindAction("GripTriggered", throwIfNotFound: true);
        m_RightHand_TriggerStrength = m_RightHand.FindAction("TriggerStrength", throwIfNotFound: true);
        m_RightHand_TriggerTriggered = m_RightHand.FindAction("TriggerTriggered", throwIfNotFound: true);
        m_RightHand_ThumbstickTouch = m_RightHand.FindAction("ThumbstickTouch", throwIfNotFound: true);
        m_RightHand_ThumbstickTriggered = m_RightHand.FindAction("ThumbstickTriggered", throwIfNotFound: true);
        m_RightHand_ThumbstickDirection = m_RightHand.FindAction("ThumbstickDirection", throwIfNotFound: true);
        m_RightHand_PrimaryButtonTriggered = m_RightHand.FindAction("PrimaryButtonTriggered", throwIfNotFound: true);
        m_RightHand_PrimaryButtonTouched = m_RightHand.FindAction("PrimaryButtonTouched", throwIfNotFound: true);
        m_RightHand_SecondaryButtonTriggered = m_RightHand.FindAction("SecondaryButtonTriggered", throwIfNotFound: true);
        m_RightHand_SecondaryButtonTouched = m_RightHand.FindAction("SecondaryButtonTouched", throwIfNotFound: true);
        m_RightHand_DevicePosition = m_RightHand.FindAction("DevicePosition", throwIfNotFound: true);
        m_RightHand_DeviceRotation = m_RightHand.FindAction("DeviceRotation", throwIfNotFound: true);
        m_RightHand_DeviceVelocity = m_RightHand.FindAction("DeviceVelocity", throwIfNotFound: true);
        m_RightHand_DeviceAngularVelocity = m_RightHand.FindAction("DeviceAngularVelocity", throwIfNotFound: true);
        // LeftHand
        m_LeftHand = asset.FindActionMap("LeftHand", throwIfNotFound: true);
        m_LeftHand_GripStrength = m_LeftHand.FindAction("GripStrength", throwIfNotFound: true);
        m_LeftHand_GripTriggered = m_LeftHand.FindAction("GripTriggered", throwIfNotFound: true);
        m_LeftHand_TriggerStrength = m_LeftHand.FindAction("TriggerStrength", throwIfNotFound: true);
        m_LeftHand_TriggerTriggered = m_LeftHand.FindAction("TriggerTriggered", throwIfNotFound: true);
        m_LeftHand_ThumbstickTouch = m_LeftHand.FindAction("ThumbstickTouch", throwIfNotFound: true);
        m_LeftHand_ThumbstickTriggered = m_LeftHand.FindAction("ThumbstickTriggered", throwIfNotFound: true);
        m_LeftHand_ThumbstickDirection = m_LeftHand.FindAction("ThumbstickDirection", throwIfNotFound: true);
        m_LeftHand_PrimaryButtonTriggered = m_LeftHand.FindAction("PrimaryButtonTriggered", throwIfNotFound: true);
        m_LeftHand_PrimaryButtonTouched = m_LeftHand.FindAction("PrimaryButtonTouched", throwIfNotFound: true);
        m_LeftHand_SecondaryButtonTriggered = m_LeftHand.FindAction("SecondaryButtonTriggered", throwIfNotFound: true);
        m_LeftHand_SecondaryButtonTouched = m_LeftHand.FindAction("SecondaryButtonTouched", throwIfNotFound: true);
        m_LeftHand_DevicePosition = m_LeftHand.FindAction("DevicePosition", throwIfNotFound: true);
        m_LeftHand_DeviceRotation = m_LeftHand.FindAction("DeviceRotation", throwIfNotFound: true);
        m_LeftHand_DeviceVelocity = m_LeftHand.FindAction("DeviceVelocity", throwIfNotFound: true);
        m_LeftHand_DeviceAngularVelocity = m_LeftHand.FindAction("DeviceAngularVelocity", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // RightHand
    private readonly InputActionMap m_RightHand;
    private IRightHandActions m_RightHandActionsCallbackInterface;
    private readonly InputAction m_RightHand_GripStrength;
    private readonly InputAction m_RightHand_GripTriggered;
    private readonly InputAction m_RightHand_TriggerStrength;
    private readonly InputAction m_RightHand_TriggerTriggered;
    private readonly InputAction m_RightHand_ThumbstickTouch;
    private readonly InputAction m_RightHand_ThumbstickTriggered;
    private readonly InputAction m_RightHand_ThumbstickDirection;
    private readonly InputAction m_RightHand_PrimaryButtonTriggered;
    private readonly InputAction m_RightHand_PrimaryButtonTouched;
    private readonly InputAction m_RightHand_SecondaryButtonTriggered;
    private readonly InputAction m_RightHand_SecondaryButtonTouched;
    private readonly InputAction m_RightHand_DevicePosition;
    private readonly InputAction m_RightHand_DeviceRotation;
    private readonly InputAction m_RightHand_DeviceVelocity;
    private readonly InputAction m_RightHand_DeviceAngularVelocity;
    public struct RightHandActions
    {
        private @CoreInputActions m_Wrapper;
        public RightHandActions(@CoreInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @GripStrength => m_Wrapper.m_RightHand_GripStrength;
        public InputAction @GripTriggered => m_Wrapper.m_RightHand_GripTriggered;
        public InputAction @TriggerStrength => m_Wrapper.m_RightHand_TriggerStrength;
        public InputAction @TriggerTriggered => m_Wrapper.m_RightHand_TriggerTriggered;
        public InputAction @ThumbstickTouch => m_Wrapper.m_RightHand_ThumbstickTouch;
        public InputAction @ThumbstickTriggered => m_Wrapper.m_RightHand_ThumbstickTriggered;
        public InputAction @ThumbstickDirection => m_Wrapper.m_RightHand_ThumbstickDirection;
        public InputAction @PrimaryButtonTriggered => m_Wrapper.m_RightHand_PrimaryButtonTriggered;
        public InputAction @PrimaryButtonTouched => m_Wrapper.m_RightHand_PrimaryButtonTouched;
        public InputAction @SecondaryButtonTriggered => m_Wrapper.m_RightHand_SecondaryButtonTriggered;
        public InputAction @SecondaryButtonTouched => m_Wrapper.m_RightHand_SecondaryButtonTouched;
        public InputAction @DevicePosition => m_Wrapper.m_RightHand_DevicePosition;
        public InputAction @DeviceRotation => m_Wrapper.m_RightHand_DeviceRotation;
        public InputAction @DeviceVelocity => m_Wrapper.m_RightHand_DeviceVelocity;
        public InputAction @DeviceAngularVelocity => m_Wrapper.m_RightHand_DeviceAngularVelocity;
        public InputActionMap Get() { return m_Wrapper.m_RightHand; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(RightHandActions set) { return set.Get(); }
        public void SetCallbacks(IRightHandActions instance)
        {
            if (m_Wrapper.m_RightHandActionsCallbackInterface != null)
            {
                @GripStrength.started -= m_Wrapper.m_RightHandActionsCallbackInterface.OnGripStrength;
                @GripStrength.performed -= m_Wrapper.m_RightHandActionsCallbackInterface.OnGripStrength;
                @GripStrength.canceled -= m_Wrapper.m_RightHandActionsCallbackInterface.OnGripStrength;
                @GripTriggered.started -= m_Wrapper.m_RightHandActionsCallbackInterface.OnGripTriggered;
                @GripTriggered.performed -= m_Wrapper.m_RightHandActionsCallbackInterface.OnGripTriggered;
                @GripTriggered.canceled -= m_Wrapper.m_RightHandActionsCallbackInterface.OnGripTriggered;
                @TriggerStrength.started -= m_Wrapper.m_RightHandActionsCallbackInterface.OnTriggerStrength;
                @TriggerStrength.performed -= m_Wrapper.m_RightHandActionsCallbackInterface.OnTriggerStrength;
                @TriggerStrength.canceled -= m_Wrapper.m_RightHandActionsCallbackInterface.OnTriggerStrength;
                @TriggerTriggered.started -= m_Wrapper.m_RightHandActionsCallbackInterface.OnTriggerTriggered;
                @TriggerTriggered.performed -= m_Wrapper.m_RightHandActionsCallbackInterface.OnTriggerTriggered;
                @TriggerTriggered.canceled -= m_Wrapper.m_RightHandActionsCallbackInterface.OnTriggerTriggered;
                @ThumbstickTouch.started -= m_Wrapper.m_RightHandActionsCallbackInterface.OnThumbstickTouch;
                @ThumbstickTouch.performed -= m_Wrapper.m_RightHandActionsCallbackInterface.OnThumbstickTouch;
                @ThumbstickTouch.canceled -= m_Wrapper.m_RightHandActionsCallbackInterface.OnThumbstickTouch;
                @ThumbstickTriggered.started -= m_Wrapper.m_RightHandActionsCallbackInterface.OnThumbstickTriggered;
                @ThumbstickTriggered.performed -= m_Wrapper.m_RightHandActionsCallbackInterface.OnThumbstickTriggered;
                @ThumbstickTriggered.canceled -= m_Wrapper.m_RightHandActionsCallbackInterface.OnThumbstickTriggered;
                @ThumbstickDirection.started -= m_Wrapper.m_RightHandActionsCallbackInterface.OnThumbstickDirection;
                @ThumbstickDirection.performed -= m_Wrapper.m_RightHandActionsCallbackInterface.OnThumbstickDirection;
                @ThumbstickDirection.canceled -= m_Wrapper.m_RightHandActionsCallbackInterface.OnThumbstickDirection;
                @PrimaryButtonTriggered.started -= m_Wrapper.m_RightHandActionsCallbackInterface.OnPrimaryButtonTriggered;
                @PrimaryButtonTriggered.performed -= m_Wrapper.m_RightHandActionsCallbackInterface.OnPrimaryButtonTriggered;
                @PrimaryButtonTriggered.canceled -= m_Wrapper.m_RightHandActionsCallbackInterface.OnPrimaryButtonTriggered;
                @PrimaryButtonTouched.started -= m_Wrapper.m_RightHandActionsCallbackInterface.OnPrimaryButtonTouched;
                @PrimaryButtonTouched.performed -= m_Wrapper.m_RightHandActionsCallbackInterface.OnPrimaryButtonTouched;
                @PrimaryButtonTouched.canceled -= m_Wrapper.m_RightHandActionsCallbackInterface.OnPrimaryButtonTouched;
                @SecondaryButtonTriggered.started -= m_Wrapper.m_RightHandActionsCallbackInterface.OnSecondaryButtonTriggered;
                @SecondaryButtonTriggered.performed -= m_Wrapper.m_RightHandActionsCallbackInterface.OnSecondaryButtonTriggered;
                @SecondaryButtonTriggered.canceled -= m_Wrapper.m_RightHandActionsCallbackInterface.OnSecondaryButtonTriggered;
                @SecondaryButtonTouched.started -= m_Wrapper.m_RightHandActionsCallbackInterface.OnSecondaryButtonTouched;
                @SecondaryButtonTouched.performed -= m_Wrapper.m_RightHandActionsCallbackInterface.OnSecondaryButtonTouched;
                @SecondaryButtonTouched.canceled -= m_Wrapper.m_RightHandActionsCallbackInterface.OnSecondaryButtonTouched;
                @DevicePosition.started -= m_Wrapper.m_RightHandActionsCallbackInterface.OnDevicePosition;
                @DevicePosition.performed -= m_Wrapper.m_RightHandActionsCallbackInterface.OnDevicePosition;
                @DevicePosition.canceled -= m_Wrapper.m_RightHandActionsCallbackInterface.OnDevicePosition;
                @DeviceRotation.started -= m_Wrapper.m_RightHandActionsCallbackInterface.OnDeviceRotation;
                @DeviceRotation.performed -= m_Wrapper.m_RightHandActionsCallbackInterface.OnDeviceRotation;
                @DeviceRotation.canceled -= m_Wrapper.m_RightHandActionsCallbackInterface.OnDeviceRotation;
                @DeviceVelocity.started -= m_Wrapper.m_RightHandActionsCallbackInterface.OnDeviceVelocity;
                @DeviceVelocity.performed -= m_Wrapper.m_RightHandActionsCallbackInterface.OnDeviceVelocity;
                @DeviceVelocity.canceled -= m_Wrapper.m_RightHandActionsCallbackInterface.OnDeviceVelocity;
                @DeviceAngularVelocity.started -= m_Wrapper.m_RightHandActionsCallbackInterface.OnDeviceAngularVelocity;
                @DeviceAngularVelocity.performed -= m_Wrapper.m_RightHandActionsCallbackInterface.OnDeviceAngularVelocity;
                @DeviceAngularVelocity.canceled -= m_Wrapper.m_RightHandActionsCallbackInterface.OnDeviceAngularVelocity;
            }
            m_Wrapper.m_RightHandActionsCallbackInterface = instance;
            if (instance != null)
            {
                @GripStrength.started += instance.OnGripStrength;
                @GripStrength.performed += instance.OnGripStrength;
                @GripStrength.canceled += instance.OnGripStrength;
                @GripTriggered.started += instance.OnGripTriggered;
                @GripTriggered.performed += instance.OnGripTriggered;
                @GripTriggered.canceled += instance.OnGripTriggered;
                @TriggerStrength.started += instance.OnTriggerStrength;
                @TriggerStrength.performed += instance.OnTriggerStrength;
                @TriggerStrength.canceled += instance.OnTriggerStrength;
                @TriggerTriggered.started += instance.OnTriggerTriggered;
                @TriggerTriggered.performed += instance.OnTriggerTriggered;
                @TriggerTriggered.canceled += instance.OnTriggerTriggered;
                @ThumbstickTouch.started += instance.OnThumbstickTouch;
                @ThumbstickTouch.performed += instance.OnThumbstickTouch;
                @ThumbstickTouch.canceled += instance.OnThumbstickTouch;
                @ThumbstickTriggered.started += instance.OnThumbstickTriggered;
                @ThumbstickTriggered.performed += instance.OnThumbstickTriggered;
                @ThumbstickTriggered.canceled += instance.OnThumbstickTriggered;
                @ThumbstickDirection.started += instance.OnThumbstickDirection;
                @ThumbstickDirection.performed += instance.OnThumbstickDirection;
                @ThumbstickDirection.canceled += instance.OnThumbstickDirection;
                @PrimaryButtonTriggered.started += instance.OnPrimaryButtonTriggered;
                @PrimaryButtonTriggered.performed += instance.OnPrimaryButtonTriggered;
                @PrimaryButtonTriggered.canceled += instance.OnPrimaryButtonTriggered;
                @PrimaryButtonTouched.started += instance.OnPrimaryButtonTouched;
                @PrimaryButtonTouched.performed += instance.OnPrimaryButtonTouched;
                @PrimaryButtonTouched.canceled += instance.OnPrimaryButtonTouched;
                @SecondaryButtonTriggered.started += instance.OnSecondaryButtonTriggered;
                @SecondaryButtonTriggered.performed += instance.OnSecondaryButtonTriggered;
                @SecondaryButtonTriggered.canceled += instance.OnSecondaryButtonTriggered;
                @SecondaryButtonTouched.started += instance.OnSecondaryButtonTouched;
                @SecondaryButtonTouched.performed += instance.OnSecondaryButtonTouched;
                @SecondaryButtonTouched.canceled += instance.OnSecondaryButtonTouched;
                @DevicePosition.started += instance.OnDevicePosition;
                @DevicePosition.performed += instance.OnDevicePosition;
                @DevicePosition.canceled += instance.OnDevicePosition;
                @DeviceRotation.started += instance.OnDeviceRotation;
                @DeviceRotation.performed += instance.OnDeviceRotation;
                @DeviceRotation.canceled += instance.OnDeviceRotation;
                @DeviceVelocity.started += instance.OnDeviceVelocity;
                @DeviceVelocity.performed += instance.OnDeviceVelocity;
                @DeviceVelocity.canceled += instance.OnDeviceVelocity;
                @DeviceAngularVelocity.started += instance.OnDeviceAngularVelocity;
                @DeviceAngularVelocity.performed += instance.OnDeviceAngularVelocity;
                @DeviceAngularVelocity.canceled += instance.OnDeviceAngularVelocity;
            }
        }
    }
    public RightHandActions @RightHand => new RightHandActions(this);

    // LeftHand
    private readonly InputActionMap m_LeftHand;
    private ILeftHandActions m_LeftHandActionsCallbackInterface;
    private readonly InputAction m_LeftHand_GripStrength;
    private readonly InputAction m_LeftHand_GripTriggered;
    private readonly InputAction m_LeftHand_TriggerStrength;
    private readonly InputAction m_LeftHand_TriggerTriggered;
    private readonly InputAction m_LeftHand_ThumbstickTouch;
    private readonly InputAction m_LeftHand_ThumbstickTriggered;
    private readonly InputAction m_LeftHand_ThumbstickDirection;
    private readonly InputAction m_LeftHand_PrimaryButtonTriggered;
    private readonly InputAction m_LeftHand_PrimaryButtonTouched;
    private readonly InputAction m_LeftHand_SecondaryButtonTriggered;
    private readonly InputAction m_LeftHand_SecondaryButtonTouched;
    private readonly InputAction m_LeftHand_DevicePosition;
    private readonly InputAction m_LeftHand_DeviceRotation;
    private readonly InputAction m_LeftHand_DeviceVelocity;
    private readonly InputAction m_LeftHand_DeviceAngularVelocity;
    public struct LeftHandActions
    {
        private @CoreInputActions m_Wrapper;
        public LeftHandActions(@CoreInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @GripStrength => m_Wrapper.m_LeftHand_GripStrength;
        public InputAction @GripTriggered => m_Wrapper.m_LeftHand_GripTriggered;
        public InputAction @TriggerStrength => m_Wrapper.m_LeftHand_TriggerStrength;
        public InputAction @TriggerTriggered => m_Wrapper.m_LeftHand_TriggerTriggered;
        public InputAction @ThumbstickTouch => m_Wrapper.m_LeftHand_ThumbstickTouch;
        public InputAction @ThumbstickTriggered => m_Wrapper.m_LeftHand_ThumbstickTriggered;
        public InputAction @ThumbstickDirection => m_Wrapper.m_LeftHand_ThumbstickDirection;
        public InputAction @PrimaryButtonTriggered => m_Wrapper.m_LeftHand_PrimaryButtonTriggered;
        public InputAction @PrimaryButtonTouched => m_Wrapper.m_LeftHand_PrimaryButtonTouched;
        public InputAction @SecondaryButtonTriggered => m_Wrapper.m_LeftHand_SecondaryButtonTriggered;
        public InputAction @SecondaryButtonTouched => m_Wrapper.m_LeftHand_SecondaryButtonTouched;
        public InputAction @DevicePosition => m_Wrapper.m_LeftHand_DevicePosition;
        public InputAction @DeviceRotation => m_Wrapper.m_LeftHand_DeviceRotation;
        public InputAction @DeviceVelocity => m_Wrapper.m_LeftHand_DeviceVelocity;
        public InputAction @DeviceAngularVelocity => m_Wrapper.m_LeftHand_DeviceAngularVelocity;
        public InputActionMap Get() { return m_Wrapper.m_LeftHand; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(LeftHandActions set) { return set.Get(); }
        public void SetCallbacks(ILeftHandActions instance)
        {
            if (m_Wrapper.m_LeftHandActionsCallbackInterface != null)
            {
                @GripStrength.started -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnGripStrength;
                @GripStrength.performed -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnGripStrength;
                @GripStrength.canceled -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnGripStrength;
                @GripTriggered.started -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnGripTriggered;
                @GripTriggered.performed -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnGripTriggered;
                @GripTriggered.canceled -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnGripTriggered;
                @TriggerStrength.started -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnTriggerStrength;
                @TriggerStrength.performed -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnTriggerStrength;
                @TriggerStrength.canceled -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnTriggerStrength;
                @TriggerTriggered.started -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnTriggerTriggered;
                @TriggerTriggered.performed -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnTriggerTriggered;
                @TriggerTriggered.canceled -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnTriggerTriggered;
                @ThumbstickTouch.started -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnThumbstickTouch;
                @ThumbstickTouch.performed -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnThumbstickTouch;
                @ThumbstickTouch.canceled -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnThumbstickTouch;
                @ThumbstickTriggered.started -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnThumbstickTriggered;
                @ThumbstickTriggered.performed -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnThumbstickTriggered;
                @ThumbstickTriggered.canceled -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnThumbstickTriggered;
                @ThumbstickDirection.started -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnThumbstickDirection;
                @ThumbstickDirection.performed -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnThumbstickDirection;
                @ThumbstickDirection.canceled -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnThumbstickDirection;
                @PrimaryButtonTriggered.started -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnPrimaryButtonTriggered;
                @PrimaryButtonTriggered.performed -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnPrimaryButtonTriggered;
                @PrimaryButtonTriggered.canceled -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnPrimaryButtonTriggered;
                @PrimaryButtonTouched.started -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnPrimaryButtonTouched;
                @PrimaryButtonTouched.performed -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnPrimaryButtonTouched;
                @PrimaryButtonTouched.canceled -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnPrimaryButtonTouched;
                @SecondaryButtonTriggered.started -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnSecondaryButtonTriggered;
                @SecondaryButtonTriggered.performed -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnSecondaryButtonTriggered;
                @SecondaryButtonTriggered.canceled -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnSecondaryButtonTriggered;
                @SecondaryButtonTouched.started -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnSecondaryButtonTouched;
                @SecondaryButtonTouched.performed -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnSecondaryButtonTouched;
                @SecondaryButtonTouched.canceled -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnSecondaryButtonTouched;
                @DevicePosition.started -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnDevicePosition;
                @DevicePosition.performed -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnDevicePosition;
                @DevicePosition.canceled -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnDevicePosition;
                @DeviceRotation.started -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnDeviceRotation;
                @DeviceRotation.performed -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnDeviceRotation;
                @DeviceRotation.canceled -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnDeviceRotation;
                @DeviceVelocity.started -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnDeviceVelocity;
                @DeviceVelocity.performed -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnDeviceVelocity;
                @DeviceVelocity.canceled -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnDeviceVelocity;
                @DeviceAngularVelocity.started -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnDeviceAngularVelocity;
                @DeviceAngularVelocity.performed -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnDeviceAngularVelocity;
                @DeviceAngularVelocity.canceled -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnDeviceAngularVelocity;
            }
            m_Wrapper.m_LeftHandActionsCallbackInterface = instance;
            if (instance != null)
            {
                @GripStrength.started += instance.OnGripStrength;
                @GripStrength.performed += instance.OnGripStrength;
                @GripStrength.canceled += instance.OnGripStrength;
                @GripTriggered.started += instance.OnGripTriggered;
                @GripTriggered.performed += instance.OnGripTriggered;
                @GripTriggered.canceled += instance.OnGripTriggered;
                @TriggerStrength.started += instance.OnTriggerStrength;
                @TriggerStrength.performed += instance.OnTriggerStrength;
                @TriggerStrength.canceled += instance.OnTriggerStrength;
                @TriggerTriggered.started += instance.OnTriggerTriggered;
                @TriggerTriggered.performed += instance.OnTriggerTriggered;
                @TriggerTriggered.canceled += instance.OnTriggerTriggered;
                @ThumbstickTouch.started += instance.OnThumbstickTouch;
                @ThumbstickTouch.performed += instance.OnThumbstickTouch;
                @ThumbstickTouch.canceled += instance.OnThumbstickTouch;
                @ThumbstickTriggered.started += instance.OnThumbstickTriggered;
                @ThumbstickTriggered.performed += instance.OnThumbstickTriggered;
                @ThumbstickTriggered.canceled += instance.OnThumbstickTriggered;
                @ThumbstickDirection.started += instance.OnThumbstickDirection;
                @ThumbstickDirection.performed += instance.OnThumbstickDirection;
                @ThumbstickDirection.canceled += instance.OnThumbstickDirection;
                @PrimaryButtonTriggered.started += instance.OnPrimaryButtonTriggered;
                @PrimaryButtonTriggered.performed += instance.OnPrimaryButtonTriggered;
                @PrimaryButtonTriggered.canceled += instance.OnPrimaryButtonTriggered;
                @PrimaryButtonTouched.started += instance.OnPrimaryButtonTouched;
                @PrimaryButtonTouched.performed += instance.OnPrimaryButtonTouched;
                @PrimaryButtonTouched.canceled += instance.OnPrimaryButtonTouched;
                @SecondaryButtonTriggered.started += instance.OnSecondaryButtonTriggered;
                @SecondaryButtonTriggered.performed += instance.OnSecondaryButtonTriggered;
                @SecondaryButtonTriggered.canceled += instance.OnSecondaryButtonTriggered;
                @SecondaryButtonTouched.started += instance.OnSecondaryButtonTouched;
                @SecondaryButtonTouched.performed += instance.OnSecondaryButtonTouched;
                @SecondaryButtonTouched.canceled += instance.OnSecondaryButtonTouched;
                @DevicePosition.started += instance.OnDevicePosition;
                @DevicePosition.performed += instance.OnDevicePosition;
                @DevicePosition.canceled += instance.OnDevicePosition;
                @DeviceRotation.started += instance.OnDeviceRotation;
                @DeviceRotation.performed += instance.OnDeviceRotation;
                @DeviceRotation.canceled += instance.OnDeviceRotation;
                @DeviceVelocity.started += instance.OnDeviceVelocity;
                @DeviceVelocity.performed += instance.OnDeviceVelocity;
                @DeviceVelocity.canceled += instance.OnDeviceVelocity;
                @DeviceAngularVelocity.started += instance.OnDeviceAngularVelocity;
                @DeviceAngularVelocity.performed += instance.OnDeviceAngularVelocity;
                @DeviceAngularVelocity.canceled += instance.OnDeviceAngularVelocity;
            }
        }
    }
    public LeftHandActions @LeftHand => new LeftHandActions(this);
    public interface IRightHandActions
    {
        void OnGripStrength(InputAction.CallbackContext context);
        void OnGripTriggered(InputAction.CallbackContext context);
        void OnTriggerStrength(InputAction.CallbackContext context);
        void OnTriggerTriggered(InputAction.CallbackContext context);
        void OnThumbstickTouch(InputAction.CallbackContext context);
        void OnThumbstickTriggered(InputAction.CallbackContext context);
        void OnThumbstickDirection(InputAction.CallbackContext context);
        void OnPrimaryButtonTriggered(InputAction.CallbackContext context);
        void OnPrimaryButtonTouched(InputAction.CallbackContext context);
        void OnSecondaryButtonTriggered(InputAction.CallbackContext context);
        void OnSecondaryButtonTouched(InputAction.CallbackContext context);
        void OnDevicePosition(InputAction.CallbackContext context);
        void OnDeviceRotation(InputAction.CallbackContext context);
        void OnDeviceVelocity(InputAction.CallbackContext context);
        void OnDeviceAngularVelocity(InputAction.CallbackContext context);
    }
    public interface ILeftHandActions
    {
        void OnGripStrength(InputAction.CallbackContext context);
        void OnGripTriggered(InputAction.CallbackContext context);
        void OnTriggerStrength(InputAction.CallbackContext context);
        void OnTriggerTriggered(InputAction.CallbackContext context);
        void OnThumbstickTouch(InputAction.CallbackContext context);
        void OnThumbstickTriggered(InputAction.CallbackContext context);
        void OnThumbstickDirection(InputAction.CallbackContext context);
        void OnPrimaryButtonTriggered(InputAction.CallbackContext context);
        void OnPrimaryButtonTouched(InputAction.CallbackContext context);
        void OnSecondaryButtonTriggered(InputAction.CallbackContext context);
        void OnSecondaryButtonTouched(InputAction.CallbackContext context);
        void OnDevicePosition(InputAction.CallbackContext context);
        void OnDeviceRotation(InputAction.CallbackContext context);
        void OnDeviceVelocity(InputAction.CallbackContext context);
        void OnDeviceAngularVelocity(InputAction.CallbackContext context);
    }
}

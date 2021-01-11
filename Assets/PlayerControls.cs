// GENERATED AUTOMATICALLY FROM 'Assets/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""PCMap"",
            ""id"": ""fb5be2ad-5449-4c99-9088-5a7994e54731"",
            ""actions"": [
                {
                    ""name"": ""Vertical"",
                    ""type"": ""Button"",
                    ""id"": ""89e31aa3-0994-4b4c-9f94-adfbbcd66d77"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Horizontal"",
                    ""type"": ""Button"",
                    ""id"": ""06f75ff9-ac57-49bd-b49e-d4cbb8f68d53"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Teleport"",
                    ""type"": ""Button"",
                    ""id"": ""381ac495-02a8-41d5-9100-69ed2543bb6f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""09a7708e-0175-43e3-8633-d16b7556ff06"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""6a21ce18-e9e8-4675-973f-8652febf00f4"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""e65c03e4-a990-4ea8-a17d-5ceef2948b35"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""bd610776-5aa1-44f7-a120-3cdb8c405231"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Controller"",
                    ""id"": ""c038f3af-10c4-4b9c-a695-39afc350c547"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""3e284668-f435-4b33-9c94-0c22a4becfaf"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""3d637c14-637f-4465-9042-143f37d9e229"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard2"",
                    ""id"": ""5210c73f-c910-47ad-b7ac-e96ce514c11e"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""91086bc9-cd36-4e41-a9b0-a99a733bd89d"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""bf252ec8-38c4-4d88-8ff3-ff860e1a8489"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""b1ebc28b-5172-4f52-b01d-9bcbf47f9448"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Teleport"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e230b165-b0c9-4465-93c0-60847da1d9d5"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Teleport"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""8439f945-1484-474d-87af-3033e01f4ec2"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""f3613082-edf0-4827-82be-02f20cdd9519"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""544d58ef-5b9c-448e-861b-8ccc8fd02998"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Controller"",
                    ""id"": ""074807eb-2923-48dd-8166-8baf8636950b"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""72f4a683-af78-4693-a361-ea8e618f924d"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""2fae22a5-0203-4a93-8e6d-46de0a31e5cc"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard2"",
                    ""id"": ""7d9d5b2d-3e1c-42d2-a7cf-1ded4572aca2"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""a8e7927f-ba3f-41de-aed6-ed9a61804224"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""e49217a1-613b-45d7-b235-f5c8d6620a2f"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""382c5838-d7a2-4ef2-9fe5-6cb0973527d5"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e14ed395-c5f1-49fd-be79-e0aa84ef0687"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PCMap
        m_PCMap = asset.FindActionMap("PCMap", throwIfNotFound: true);
        m_PCMap_Vertical = m_PCMap.FindAction("Vertical", throwIfNotFound: true);
        m_PCMap_Horizontal = m_PCMap.FindAction("Horizontal", throwIfNotFound: true);
        m_PCMap_Teleport = m_PCMap.FindAction("Teleport", throwIfNotFound: true);
        m_PCMap_Pause = m_PCMap.FindAction("Pause", throwIfNotFound: true);
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

    // PCMap
    private readonly InputActionMap m_PCMap;
    private IPCMapActions m_PCMapActionsCallbackInterface;
    private readonly InputAction m_PCMap_Vertical;
    private readonly InputAction m_PCMap_Horizontal;
    private readonly InputAction m_PCMap_Teleport;
    private readonly InputAction m_PCMap_Pause;
    public struct PCMapActions
    {
        private @PlayerControls m_Wrapper;
        public PCMapActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Vertical => m_Wrapper.m_PCMap_Vertical;
        public InputAction @Horizontal => m_Wrapper.m_PCMap_Horizontal;
        public InputAction @Teleport => m_Wrapper.m_PCMap_Teleport;
        public InputAction @Pause => m_Wrapper.m_PCMap_Pause;
        public InputActionMap Get() { return m_Wrapper.m_PCMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PCMapActions set) { return set.Get(); }
        public void SetCallbacks(IPCMapActions instance)
        {
            if (m_Wrapper.m_PCMapActionsCallbackInterface != null)
            {
                @Vertical.started -= m_Wrapper.m_PCMapActionsCallbackInterface.OnVertical;
                @Vertical.performed -= m_Wrapper.m_PCMapActionsCallbackInterface.OnVertical;
                @Vertical.canceled -= m_Wrapper.m_PCMapActionsCallbackInterface.OnVertical;
                @Horizontal.started -= m_Wrapper.m_PCMapActionsCallbackInterface.OnHorizontal;
                @Horizontal.performed -= m_Wrapper.m_PCMapActionsCallbackInterface.OnHorizontal;
                @Horizontal.canceled -= m_Wrapper.m_PCMapActionsCallbackInterface.OnHorizontal;
                @Teleport.started -= m_Wrapper.m_PCMapActionsCallbackInterface.OnTeleport;
                @Teleport.performed -= m_Wrapper.m_PCMapActionsCallbackInterface.OnTeleport;
                @Teleport.canceled -= m_Wrapper.m_PCMapActionsCallbackInterface.OnTeleport;
                @Pause.started -= m_Wrapper.m_PCMapActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_PCMapActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_PCMapActionsCallbackInterface.OnPause;
            }
            m_Wrapper.m_PCMapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Vertical.started += instance.OnVertical;
                @Vertical.performed += instance.OnVertical;
                @Vertical.canceled += instance.OnVertical;
                @Horizontal.started += instance.OnHorizontal;
                @Horizontal.performed += instance.OnHorizontal;
                @Horizontal.canceled += instance.OnHorizontal;
                @Teleport.started += instance.OnTeleport;
                @Teleport.performed += instance.OnTeleport;
                @Teleport.canceled += instance.OnTeleport;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
            }
        }
    }
    public PCMapActions @PCMap => new PCMapActions(this);
    public interface IPCMapActions
    {
        void OnVertical(InputAction.CallbackContext context);
        void OnHorizontal(InputAction.CallbackContext context);
        void OnTeleport(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
    }
}

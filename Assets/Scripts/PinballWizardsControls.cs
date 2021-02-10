// GENERATED AUTOMATICALLY FROM 'Assets/PinballWizardsControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PinballWizardsControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PinballWizardsControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PinballWizardsControls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""af05d1f9-abef-461f-800a-685a10d6473e"",
            ""actions"": [
                {
                    ""name"": ""LeftPaddle"",
                    ""type"": ""Button"",
                    ""id"": ""53fefc3e-a70f-4938-9d52-242c2a4f6719"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""RightPaddle"",
                    ""type"": ""Button"",
                    ""id"": ""7e9ee5b9-5575-4e03-9208-74042fa97927"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f26ee3ac-e515-4c05-b5c4-de14c9dbed0a"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBM"",
                    ""action"": ""LeftPaddle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5b6146e5-dda9-4352-8f34-c3d186fe010e"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBM"",
                    ""action"": ""RightPaddle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""KBM"",
            ""bindingGroup"": ""KBM"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_LeftPaddle = m_Player.FindAction("LeftPaddle", throwIfNotFound: true);
        m_Player_RightPaddle = m_Player.FindAction("RightPaddle", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_LeftPaddle;
    private readonly InputAction m_Player_RightPaddle;
    public struct PlayerActions
    {
        private @PinballWizardsControls m_Wrapper;
        public PlayerActions(@PinballWizardsControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @LeftPaddle => m_Wrapper.m_Player_LeftPaddle;
        public InputAction @RightPaddle => m_Wrapper.m_Player_RightPaddle;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @LeftPaddle.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftPaddle;
                @LeftPaddle.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftPaddle;
                @LeftPaddle.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftPaddle;
                @RightPaddle.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightPaddle;
                @RightPaddle.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightPaddle;
                @RightPaddle.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightPaddle;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @LeftPaddle.started += instance.OnLeftPaddle;
                @LeftPaddle.performed += instance.OnLeftPaddle;
                @LeftPaddle.canceled += instance.OnLeftPaddle;
                @RightPaddle.started += instance.OnRightPaddle;
                @RightPaddle.performed += instance.OnRightPaddle;
                @RightPaddle.canceled += instance.OnRightPaddle;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_KBMSchemeIndex = -1;
    public InputControlScheme KBMScheme
    {
        get
        {
            if (m_KBMSchemeIndex == -1) m_KBMSchemeIndex = asset.FindControlSchemeIndex("KBM");
            return asset.controlSchemes[m_KBMSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnLeftPaddle(InputAction.CallbackContext context);
        void OnRightPaddle(InputAction.CallbackContext context);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.2
//     from Assets/[Scripts]/PlayerActions.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerActions : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerActions"",
    ""maps"": [
        {
            ""name"": ""PlayerMoves"",
            ""id"": ""00d9d20c-0254-4888-aa0d-04bb6bb83438"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""b36fd786-78b2-4a76-886b-326caf6382d5"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""8ad07e05-c4d7-4a48-ba07-86849a0968e3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""CameraLook"",
                    ""type"": ""Value"",
                    ""id"": ""5065d0c6-5440-417a-82fc-89eb29591a8f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""9de4d045-499d-40a1-a813-5ea95d5997e2"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""eabf13c0-5188-4fbb-94f0-74e91e2f02a4"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""72a37fea-ff97-4a75-82fb-be996d961e67"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""03bed666-ee70-4e62-b100-cb1566cbe300"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""68709a4f-b0fb-40ef-b03e-7f3f8e7da00b"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""88e61a3d-80b3-4e15-8530-4e8a06b543c7"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""d83b7a2f-681b-47fd-a2f3-28a13fdb184e"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3722c087-49dd-4d42-92d3-1bca3169dcf8"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e8f75bea-0c83-44d1-8754-ce54dea59019"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraLook"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerMoves
        m_PlayerMoves = asset.FindActionMap("PlayerMoves", throwIfNotFound: true);
        m_PlayerMoves_Move = m_PlayerMoves.FindAction("Move", throwIfNotFound: true);
        m_PlayerMoves_Jump = m_PlayerMoves.FindAction("Jump", throwIfNotFound: true);
        m_PlayerMoves_CameraLook = m_PlayerMoves.FindAction("CameraLook", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // PlayerMoves
    private readonly InputActionMap m_PlayerMoves;
    private IPlayerMovesActions m_PlayerMovesActionsCallbackInterface;
    private readonly InputAction m_PlayerMoves_Move;
    private readonly InputAction m_PlayerMoves_Jump;
    private readonly InputAction m_PlayerMoves_CameraLook;
    public struct PlayerMovesActions
    {
        private @PlayerActions m_Wrapper;
        public PlayerMovesActions(@PlayerActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_PlayerMoves_Move;
        public InputAction @Jump => m_Wrapper.m_PlayerMoves_Jump;
        public InputAction @CameraLook => m_Wrapper.m_PlayerMoves_CameraLook;
        public InputActionMap Get() { return m_Wrapper.m_PlayerMoves; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerMovesActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerMovesActions instance)
        {
            if (m_Wrapper.m_PlayerMovesActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerMovesActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerMovesActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerMovesActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_PlayerMovesActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerMovesActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerMovesActionsCallbackInterface.OnJump;
                @CameraLook.started -= m_Wrapper.m_PlayerMovesActionsCallbackInterface.OnCameraLook;
                @CameraLook.performed -= m_Wrapper.m_PlayerMovesActionsCallbackInterface.OnCameraLook;
                @CameraLook.canceled -= m_Wrapper.m_PlayerMovesActionsCallbackInterface.OnCameraLook;
            }
            m_Wrapper.m_PlayerMovesActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @CameraLook.started += instance.OnCameraLook;
                @CameraLook.performed += instance.OnCameraLook;
                @CameraLook.canceled += instance.OnCameraLook;
            }
        }
    }
    public PlayerMovesActions @PlayerMoves => new PlayerMovesActions(this);
    public interface IPlayerMovesActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnCameraLook(InputAction.CallbackContext context);
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/_Project/_MyInputProject/InputActions.inputactions
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

public partial class @InputActions : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""MyActionMapA"",
            ""id"": ""abbfcc8c-627a-4698-ac46-8aabbd39a2e5"",
            ""actions"": [
                {
                    ""name"": ""_GetNameDummy"",
                    ""type"": ""Button"",
                    ""id"": ""0505b1a2-bd81-4b8f-a014-f66892a9ff88"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MyButtonAction"",
                    ""type"": ""Button"",
                    ""id"": ""cdeaee77-4ea3-48f9-b63b-4ac7189aecad"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MyValueActionVector"",
                    ""type"": ""Value"",
                    ""id"": ""19f91964-54c3-4b4c-b468-dcd25aae48de"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""MyButtonAction_PressRelease"",
                    ""type"": ""Button"",
                    ""id"": ""bcc5cdd6-7525-4382-b3e5-8fd27a756f88"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)"",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7306a857-c941-4f0e-b17a-00181c8a2e5d"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""MyButtonAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6960e88b-8e67-4b8a-b3e6-a9e142a8a248"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""MyButtonAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ff0ccf6a-3808-4205-bba2-238820a4ad0f"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""MyValueActionVector"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""94a17375-a316-4287-87fd-dd7f6059216d"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""MyValueActionVector"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e3c0b0c8-5366-4a77-9ec3-0a3224f755f8"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""MyButtonAction_PressRelease"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7dce760c-3948-4b79-9501-9cb72c13d227"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""MyButtonAction_PressRelease"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""95074ee4-8475-413f-b45f-ee2892a96961"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""_GetNameDummy"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""MyActionMapB"",
            ""id"": ""bcf94342-5607-4c34-9a4c-b1dd2d94d08c"",
            ""actions"": [
                {
                    ""name"": ""_GetNameDummy"",
                    ""type"": ""Button"",
                    ""id"": ""7416d56b-7c97-4830-826b-a287f10ad6ff"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MyButtonActionB"",
                    ""type"": ""Button"",
                    ""id"": ""05ad600a-f63c-4cd0-97bd-c174f2894e09"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2baad5de-47cc-492a-9a76-edc1394dd051"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""MyButtonActionB"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7aa2a4ec-ec05-4dd0-8ee1-44e9f44f82ad"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""MyButtonActionB"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2505f946-3b07-49d1-8a1b-65624cc53100"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""_GetNameDummy"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""GamePlay"",
            ""id"": ""73305741-237b-4877-813f-fe396f7b1358"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""582e726f-063c-4c0e-8473-ada8ad9e0bee"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""55dd9c7c-15b7-4ebf-9b5c-5f7769272dc0"",
                    ""path"": ""2DVector"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""f17f631d-1680-4f3c-b590-c90284063c13"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""644c2986-44ae-4813-90b0-6ad28fe93e71"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""71fcc767-858d-464e-886a-35c36cc066b5"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""4443f2cf-2bae-4bd2-a8a1-0680278900a1"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""KeyboardMouse"",
            ""bindingGroup"": ""KeyboardMouse"",
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
        },
        {
            ""name"": ""Controller"",
            ""bindingGroup"": ""Controller"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // MyActionMapA
        m_MyActionMapA = asset.FindActionMap("MyActionMapA", throwIfNotFound: true);
        m_MyActionMapA__GetNameDummy = m_MyActionMapA.FindAction("_GetNameDummy", throwIfNotFound: true);
        m_MyActionMapA_MyButtonAction = m_MyActionMapA.FindAction("MyButtonAction", throwIfNotFound: true);
        m_MyActionMapA_MyValueActionVector = m_MyActionMapA.FindAction("MyValueActionVector", throwIfNotFound: true);
        m_MyActionMapA_MyButtonAction_PressRelease = m_MyActionMapA.FindAction("MyButtonAction_PressRelease", throwIfNotFound: true);
        // MyActionMapB
        m_MyActionMapB = asset.FindActionMap("MyActionMapB", throwIfNotFound: true);
        m_MyActionMapB__GetNameDummy = m_MyActionMapB.FindAction("_GetNameDummy", throwIfNotFound: true);
        m_MyActionMapB_MyButtonActionB = m_MyActionMapB.FindAction("MyButtonActionB", throwIfNotFound: true);
        // GamePlay
        m_GamePlay = asset.FindActionMap("GamePlay", throwIfNotFound: true);
        m_GamePlay_Move = m_GamePlay.FindAction("Move", throwIfNotFound: true);
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

    // MyActionMapA
    private readonly InputActionMap m_MyActionMapA;
    private IMyActionMapAActions m_MyActionMapAActionsCallbackInterface;
    private readonly InputAction m_MyActionMapA__GetNameDummy;
    private readonly InputAction m_MyActionMapA_MyButtonAction;
    private readonly InputAction m_MyActionMapA_MyValueActionVector;
    private readonly InputAction m_MyActionMapA_MyButtonAction_PressRelease;
    public struct MyActionMapAActions
    {
        private @InputActions m_Wrapper;
        public MyActionMapAActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @_GetNameDummy => m_Wrapper.m_MyActionMapA__GetNameDummy;
        public InputAction @MyButtonAction => m_Wrapper.m_MyActionMapA_MyButtonAction;
        public InputAction @MyValueActionVector => m_Wrapper.m_MyActionMapA_MyValueActionVector;
        public InputAction @MyButtonAction_PressRelease => m_Wrapper.m_MyActionMapA_MyButtonAction_PressRelease;
        public InputActionMap Get() { return m_Wrapper.m_MyActionMapA; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MyActionMapAActions set) { return set.Get(); }
        public void SetCallbacks(IMyActionMapAActions instance)
        {
            if (m_Wrapper.m_MyActionMapAActionsCallbackInterface != null)
            {
                @_GetNameDummy.started -= m_Wrapper.m_MyActionMapAActionsCallbackInterface.On_GetNameDummy;
                @_GetNameDummy.performed -= m_Wrapper.m_MyActionMapAActionsCallbackInterface.On_GetNameDummy;
                @_GetNameDummy.canceled -= m_Wrapper.m_MyActionMapAActionsCallbackInterface.On_GetNameDummy;
                @MyButtonAction.started -= m_Wrapper.m_MyActionMapAActionsCallbackInterface.OnMyButtonAction;
                @MyButtonAction.performed -= m_Wrapper.m_MyActionMapAActionsCallbackInterface.OnMyButtonAction;
                @MyButtonAction.canceled -= m_Wrapper.m_MyActionMapAActionsCallbackInterface.OnMyButtonAction;
                @MyValueActionVector.started -= m_Wrapper.m_MyActionMapAActionsCallbackInterface.OnMyValueActionVector;
                @MyValueActionVector.performed -= m_Wrapper.m_MyActionMapAActionsCallbackInterface.OnMyValueActionVector;
                @MyValueActionVector.canceled -= m_Wrapper.m_MyActionMapAActionsCallbackInterface.OnMyValueActionVector;
                @MyButtonAction_PressRelease.started -= m_Wrapper.m_MyActionMapAActionsCallbackInterface.OnMyButtonAction_PressRelease;
                @MyButtonAction_PressRelease.performed -= m_Wrapper.m_MyActionMapAActionsCallbackInterface.OnMyButtonAction_PressRelease;
                @MyButtonAction_PressRelease.canceled -= m_Wrapper.m_MyActionMapAActionsCallbackInterface.OnMyButtonAction_PressRelease;
            }
            m_Wrapper.m_MyActionMapAActionsCallbackInterface = instance;
            if (instance != null)
            {
                @_GetNameDummy.started += instance.On_GetNameDummy;
                @_GetNameDummy.performed += instance.On_GetNameDummy;
                @_GetNameDummy.canceled += instance.On_GetNameDummy;
                @MyButtonAction.started += instance.OnMyButtonAction;
                @MyButtonAction.performed += instance.OnMyButtonAction;
                @MyButtonAction.canceled += instance.OnMyButtonAction;
                @MyValueActionVector.started += instance.OnMyValueActionVector;
                @MyValueActionVector.performed += instance.OnMyValueActionVector;
                @MyValueActionVector.canceled += instance.OnMyValueActionVector;
                @MyButtonAction_PressRelease.started += instance.OnMyButtonAction_PressRelease;
                @MyButtonAction_PressRelease.performed += instance.OnMyButtonAction_PressRelease;
                @MyButtonAction_PressRelease.canceled += instance.OnMyButtonAction_PressRelease;
            }
        }
    }
    public MyActionMapAActions @MyActionMapA => new MyActionMapAActions(this);

    // MyActionMapB
    private readonly InputActionMap m_MyActionMapB;
    private IMyActionMapBActions m_MyActionMapBActionsCallbackInterface;
    private readonly InputAction m_MyActionMapB__GetNameDummy;
    private readonly InputAction m_MyActionMapB_MyButtonActionB;
    public struct MyActionMapBActions
    {
        private @InputActions m_Wrapper;
        public MyActionMapBActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @_GetNameDummy => m_Wrapper.m_MyActionMapB__GetNameDummy;
        public InputAction @MyButtonActionB => m_Wrapper.m_MyActionMapB_MyButtonActionB;
        public InputActionMap Get() { return m_Wrapper.m_MyActionMapB; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MyActionMapBActions set) { return set.Get(); }
        public void SetCallbacks(IMyActionMapBActions instance)
        {
            if (m_Wrapper.m_MyActionMapBActionsCallbackInterface != null)
            {
                @_GetNameDummy.started -= m_Wrapper.m_MyActionMapBActionsCallbackInterface.On_GetNameDummy;
                @_GetNameDummy.performed -= m_Wrapper.m_MyActionMapBActionsCallbackInterface.On_GetNameDummy;
                @_GetNameDummy.canceled -= m_Wrapper.m_MyActionMapBActionsCallbackInterface.On_GetNameDummy;
                @MyButtonActionB.started -= m_Wrapper.m_MyActionMapBActionsCallbackInterface.OnMyButtonActionB;
                @MyButtonActionB.performed -= m_Wrapper.m_MyActionMapBActionsCallbackInterface.OnMyButtonActionB;
                @MyButtonActionB.canceled -= m_Wrapper.m_MyActionMapBActionsCallbackInterface.OnMyButtonActionB;
            }
            m_Wrapper.m_MyActionMapBActionsCallbackInterface = instance;
            if (instance != null)
            {
                @_GetNameDummy.started += instance.On_GetNameDummy;
                @_GetNameDummy.performed += instance.On_GetNameDummy;
                @_GetNameDummy.canceled += instance.On_GetNameDummy;
                @MyButtonActionB.started += instance.OnMyButtonActionB;
                @MyButtonActionB.performed += instance.OnMyButtonActionB;
                @MyButtonActionB.canceled += instance.OnMyButtonActionB;
            }
        }
    }
    public MyActionMapBActions @MyActionMapB => new MyActionMapBActions(this);

    // GamePlay
    private readonly InputActionMap m_GamePlay;
    private IGamePlayActions m_GamePlayActionsCallbackInterface;
    private readonly InputAction m_GamePlay_Move;
    public struct GamePlayActions
    {
        private @InputActions m_Wrapper;
        public GamePlayActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_GamePlay_Move;
        public InputActionMap Get() { return m_Wrapper.m_GamePlay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GamePlayActions set) { return set.Get(); }
        public void SetCallbacks(IGamePlayActions instance)
        {
            if (m_Wrapper.m_GamePlayActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_GamePlayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public GamePlayActions @GamePlay => new GamePlayActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("KeyboardMouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    private int m_ControllerSchemeIndex = -1;
    public InputControlScheme ControllerScheme
    {
        get
        {
            if (m_ControllerSchemeIndex == -1) m_ControllerSchemeIndex = asset.FindControlSchemeIndex("Controller");
            return asset.controlSchemes[m_ControllerSchemeIndex];
        }
    }
    public interface IMyActionMapAActions
    {
        void On_GetNameDummy(InputAction.CallbackContext context);
        void OnMyButtonAction(InputAction.CallbackContext context);
        void OnMyValueActionVector(InputAction.CallbackContext context);
        void OnMyButtonAction_PressRelease(InputAction.CallbackContext context);
    }
    public interface IMyActionMapBActions
    {
        void On_GetNameDummy(InputAction.CallbackContext context);
        void OnMyButtonActionB(InputAction.CallbackContext context);
    }
    public interface IGamePlayActions
    {
        void OnMove(InputAction.CallbackContext context);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/AllXrButtons.inputactions
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

public partial class @AllXrButtons: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @AllXrButtons()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""AllXrButtons"",
    ""maps"": [
        {
            ""name"": ""AllButtons"",
            ""id"": ""ea0b892f-e4c2-4b21-a805-d29f2c8c1076"",
            ""actions"": [
                {
                    ""name"": ""LeftTopButton"",
                    ""type"": ""Button"",
                    ""id"": ""935c26de-2900-40ec-b583-0f0ae2a2fc81"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""RightTopButton"",
                    ""type"": ""Button"",
                    ""id"": ""5d5bbc4c-85a5-4878-b21d-e31cc727adef"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LeftDownButton"",
                    ""type"": ""Button"",
                    ""id"": ""384b16ed-3094-47b2-a4a4-7a0d0e11bc33"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""RightDownButton"",
                    ""type"": ""Button"",
                    ""id"": ""f8f53e3e-1d61-487a-a0d0-0415cdb08eda"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""GrabLeft"",
                    ""type"": ""Button"",
                    ""id"": ""a6bd0dc1-4abc-4ffc-9398-ade615c2d07d"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""GrabRight"",
                    ""type"": ""Button"",
                    ""id"": ""b0f84499-432c-487a-bc56-d5755a9a22e4"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""TriggerLeft"",
                    ""type"": ""Button"",
                    ""id"": ""6ad61329-879e-4aca-81fd-4f15a83115e0"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""TriggerRight"",
                    ""type"": ""Button"",
                    ""id"": ""84eeb74f-0eae-4ddc-8e5b-3b4f1a9358e1"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b4844820-063c-4723-abce-7a4c3d7733bc"",
                    ""path"": ""<XRInputV1::Oculus::OculusTouchControllerOpenXR>{LeftHand}/secondarybutton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftTopButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""65488912-f59b-428b-8420-36e2ab373bcf"",
                    ""path"": ""<XRInputV1::Oculus::OculusTouchControllerOpenXR>{RightHand}/secondarybutton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightTopButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c7123f27-4cda-4687-b2d6-8dedaa95c11a"",
                    ""path"": ""<XRInputV1::Oculus::OculusTouchControllerOpenXR>{LeftHand}/primarybutton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftDownButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2b1ce414-5096-41db-9984-f9f68df78a25"",
                    ""path"": ""<XRInputV1::Oculus::OculusTouchControllerOpenXR>{RightHand}/primarybutton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightDownButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""556d0540-26dd-4786-a06f-1e94716a89b2"",
                    ""path"": ""<XRInputV1::Oculus::OculusTouchControllerOpenXR>{LeftHand}/grippressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GrabLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""52fe0de6-8e4e-4e6f-bb5c-d38a1cc9a698"",
                    ""path"": ""<XRInputV1::Oculus::OculusTouchControllerOpenXR>{RightHand}/grippressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GrabRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d5e69a89-e261-4d24-9a92-fdf54aa16594"",
                    ""path"": ""<XRInputV1::Oculus::OculusTouchControllerOpenXR>{LeftHand}/triggerpressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TriggerLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a9860d6d-be0a-4b6c-9608-ad9e189205fe"",
                    ""path"": ""<XRInputV1::Oculus::OculusTouchControllerOpenXR>{RightHand}/triggerpressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TriggerRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // AllButtons
        m_AllButtons = asset.FindActionMap("AllButtons", throwIfNotFound: true);
        m_AllButtons_LeftTopButton = m_AllButtons.FindAction("LeftTopButton", throwIfNotFound: true);
        m_AllButtons_RightTopButton = m_AllButtons.FindAction("RightTopButton", throwIfNotFound: true);
        m_AllButtons_LeftDownButton = m_AllButtons.FindAction("LeftDownButton", throwIfNotFound: true);
        m_AllButtons_RightDownButton = m_AllButtons.FindAction("RightDownButton", throwIfNotFound: true);
        m_AllButtons_GrabLeft = m_AllButtons.FindAction("GrabLeft", throwIfNotFound: true);
        m_AllButtons_GrabRight = m_AllButtons.FindAction("GrabRight", throwIfNotFound: true);
        m_AllButtons_TriggerLeft = m_AllButtons.FindAction("TriggerLeft", throwIfNotFound: true);
        m_AllButtons_TriggerRight = m_AllButtons.FindAction("TriggerRight", throwIfNotFound: true);
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

    // AllButtons
    private readonly InputActionMap m_AllButtons;
    private List<IAllButtonsActions> m_AllButtonsActionsCallbackInterfaces = new List<IAllButtonsActions>();
    private readonly InputAction m_AllButtons_LeftTopButton;
    private readonly InputAction m_AllButtons_RightTopButton;
    private readonly InputAction m_AllButtons_LeftDownButton;
    private readonly InputAction m_AllButtons_RightDownButton;
    private readonly InputAction m_AllButtons_GrabLeft;
    private readonly InputAction m_AllButtons_GrabRight;
    private readonly InputAction m_AllButtons_TriggerLeft;
    private readonly InputAction m_AllButtons_TriggerRight;
    public struct AllButtonsActions
    {
        private @AllXrButtons m_Wrapper;
        public AllButtonsActions(@AllXrButtons wrapper) { m_Wrapper = wrapper; }
        public InputAction @LeftTopButton => m_Wrapper.m_AllButtons_LeftTopButton;
        public InputAction @RightTopButton => m_Wrapper.m_AllButtons_RightTopButton;
        public InputAction @LeftDownButton => m_Wrapper.m_AllButtons_LeftDownButton;
        public InputAction @RightDownButton => m_Wrapper.m_AllButtons_RightDownButton;
        public InputAction @GrabLeft => m_Wrapper.m_AllButtons_GrabLeft;
        public InputAction @GrabRight => m_Wrapper.m_AllButtons_GrabRight;
        public InputAction @TriggerLeft => m_Wrapper.m_AllButtons_TriggerLeft;
        public InputAction @TriggerRight => m_Wrapper.m_AllButtons_TriggerRight;
        public InputActionMap Get() { return m_Wrapper.m_AllButtons; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(AllButtonsActions set) { return set.Get(); }
        public void AddCallbacks(IAllButtonsActions instance)
        {
            if (instance == null || m_Wrapper.m_AllButtonsActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_AllButtonsActionsCallbackInterfaces.Add(instance);
            @LeftTopButton.started += instance.OnLeftTopButton;
            @LeftTopButton.performed += instance.OnLeftTopButton;
            @LeftTopButton.canceled += instance.OnLeftTopButton;
            @RightTopButton.started += instance.OnRightTopButton;
            @RightTopButton.performed += instance.OnRightTopButton;
            @RightTopButton.canceled += instance.OnRightTopButton;
            @LeftDownButton.started += instance.OnLeftDownButton;
            @LeftDownButton.performed += instance.OnLeftDownButton;
            @LeftDownButton.canceled += instance.OnLeftDownButton;
            @RightDownButton.started += instance.OnRightDownButton;
            @RightDownButton.performed += instance.OnRightDownButton;
            @RightDownButton.canceled += instance.OnRightDownButton;
            @GrabLeft.started += instance.OnGrabLeft;
            @GrabLeft.performed += instance.OnGrabLeft;
            @GrabLeft.canceled += instance.OnGrabLeft;
            @GrabRight.started += instance.OnGrabRight;
            @GrabRight.performed += instance.OnGrabRight;
            @GrabRight.canceled += instance.OnGrabRight;
            @TriggerLeft.started += instance.OnTriggerLeft;
            @TriggerLeft.performed += instance.OnTriggerLeft;
            @TriggerLeft.canceled += instance.OnTriggerLeft;
            @TriggerRight.started += instance.OnTriggerRight;
            @TriggerRight.performed += instance.OnTriggerRight;
            @TriggerRight.canceled += instance.OnTriggerRight;
        }

        private void UnregisterCallbacks(IAllButtonsActions instance)
        {
            @LeftTopButton.started -= instance.OnLeftTopButton;
            @LeftTopButton.performed -= instance.OnLeftTopButton;
            @LeftTopButton.canceled -= instance.OnLeftTopButton;
            @RightTopButton.started -= instance.OnRightTopButton;
            @RightTopButton.performed -= instance.OnRightTopButton;
            @RightTopButton.canceled -= instance.OnRightTopButton;
            @LeftDownButton.started -= instance.OnLeftDownButton;
            @LeftDownButton.performed -= instance.OnLeftDownButton;
            @LeftDownButton.canceled -= instance.OnLeftDownButton;
            @RightDownButton.started -= instance.OnRightDownButton;
            @RightDownButton.performed -= instance.OnRightDownButton;
            @RightDownButton.canceled -= instance.OnRightDownButton;
            @GrabLeft.started -= instance.OnGrabLeft;
            @GrabLeft.performed -= instance.OnGrabLeft;
            @GrabLeft.canceled -= instance.OnGrabLeft;
            @GrabRight.started -= instance.OnGrabRight;
            @GrabRight.performed -= instance.OnGrabRight;
            @GrabRight.canceled -= instance.OnGrabRight;
            @TriggerLeft.started -= instance.OnTriggerLeft;
            @TriggerLeft.performed -= instance.OnTriggerLeft;
            @TriggerLeft.canceled -= instance.OnTriggerLeft;
            @TriggerRight.started -= instance.OnTriggerRight;
            @TriggerRight.performed -= instance.OnTriggerRight;
            @TriggerRight.canceled -= instance.OnTriggerRight;
        }

        public void RemoveCallbacks(IAllButtonsActions instance)
        {
            if (m_Wrapper.m_AllButtonsActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IAllButtonsActions instance)
        {
            foreach (var item in m_Wrapper.m_AllButtonsActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_AllButtonsActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public AllButtonsActions @AllButtons => new AllButtonsActions(this);
    public interface IAllButtonsActions
    {
        void OnLeftTopButton(InputAction.CallbackContext context);
        void OnRightTopButton(InputAction.CallbackContext context);
        void OnLeftDownButton(InputAction.CallbackContext context);
        void OnRightDownButton(InputAction.CallbackContext context);
        void OnGrabLeft(InputAction.CallbackContext context);
        void OnGrabRight(InputAction.CallbackContext context);
        void OnTriggerLeft(InputAction.CallbackContext context);
        void OnTriggerRight(InputAction.CallbackContext context);
    }
}

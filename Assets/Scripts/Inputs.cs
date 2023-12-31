//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Scripts/Inputs.inputactions
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

public partial class @Inputs: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Inputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Inputs"",
    ""maps"": [
        {
            ""name"": ""GameMode"",
            ""id"": ""022fb32c-35ca-4c24-9169-77f581a59127"",
            ""actions"": [
                {
                    ""name"": ""Switch"",
                    ""type"": ""Button"",
                    ""id"": ""510cb533-9bc2-4458-95eb-792fa33d99c3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""04d75f9f-6bd3-473a-b8c4-110ee4cfea51"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Switch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // GameMode
        m_GameMode = asset.FindActionMap("GameMode", throwIfNotFound: true);
        m_GameMode_Switch = m_GameMode.FindAction("Switch", throwIfNotFound: true);
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

    // GameMode
    private readonly InputActionMap m_GameMode;
    private List<IGameModeActions> m_GameModeActionsCallbackInterfaces = new List<IGameModeActions>();
    private readonly InputAction m_GameMode_Switch;
    public struct GameModeActions
    {
        private @Inputs m_Wrapper;
        public GameModeActions(@Inputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Switch => m_Wrapper.m_GameMode_Switch;
        public InputActionMap Get() { return m_Wrapper.m_GameMode; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameModeActions set) { return set.Get(); }
        public void AddCallbacks(IGameModeActions instance)
        {
            if (instance == null || m_Wrapper.m_GameModeActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_GameModeActionsCallbackInterfaces.Add(instance);
            @Switch.started += instance.OnSwitch;
            @Switch.performed += instance.OnSwitch;
            @Switch.canceled += instance.OnSwitch;
        }

        private void UnregisterCallbacks(IGameModeActions instance)
        {
            @Switch.started -= instance.OnSwitch;
            @Switch.performed -= instance.OnSwitch;
            @Switch.canceled -= instance.OnSwitch;
        }

        public void RemoveCallbacks(IGameModeActions instance)
        {
            if (m_Wrapper.m_GameModeActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IGameModeActions instance)
        {
            foreach (var item in m_Wrapper.m_GameModeActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_GameModeActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public GameModeActions @GameMode => new GameModeActions(this);
    public interface IGameModeActions
    {
        void OnSwitch(InputAction.CallbackContext context);
    }
}

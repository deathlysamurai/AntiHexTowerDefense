// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Input/Manager/InputManager.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputManager : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputManager()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputManager"",
    ""maps"": [
        {
            ""name"": ""LevelEditor"",
            ""id"": ""a83af19c-c610-4655-9ce5-7c4f2414d627"",
            ""actions"": [
                {
                    ""name"": ""SpawnTile"",
                    ""type"": ""Button"",
                    ""id"": ""7643783c-28f1-46bf-850e-769f5e0f4a68"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RemoveTile"",
                    ""type"": ""Button"",
                    ""id"": ""96be4259-3eeb-449a-8855-10514a7d055b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5097f138-9165-4fdf-974e-0d7c9af58f03"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SpawnTile"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e2b4fdbd-1580-400b-af94-06e6e008c220"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RemoveTile"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""CameraMovement"",
            ""id"": ""46948e3d-8d6d-4f02-bdb1-a0e8c04031af"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""82dd09fe-fa1e-472d-a558-cd38e31e65a4"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotation"",
                    ""type"": ""Button"",
                    ""id"": ""4dfe3453-b305-4130-adf0-ea9f5eb732ae"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Zoom"",
                    ""type"": ""PassThrough"",
                    ""id"": ""ad3ab45e-42fa-4f84-8c2b-8ee0a2ef1cb1"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""488c772f-2be9-4f66-91fc-b60867839ce7"",
                    ""path"": ""<Mouse>/middleButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4abd6e10-9018-4a1b-85d3-38a222031e5e"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""f744f89a-948d-4bec-b46a-4b157b6304bc"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""01fab94f-b65a-4be7-a785-f4f88e662563"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a490102b-aa9c-4c0c-b021-c9adf7ab0139"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""cc494bbc-cbd1-4826-b66b-ca86e38856ae"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""b7d84455-9a05-43df-98c2-d3e130c2cf75"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // LevelEditor
        m_LevelEditor = asset.FindActionMap("LevelEditor", throwIfNotFound: true);
        m_LevelEditor_SpawnTile = m_LevelEditor.FindAction("SpawnTile", throwIfNotFound: true);
        m_LevelEditor_RemoveTile = m_LevelEditor.FindAction("RemoveTile", throwIfNotFound: true);
        // CameraMovement
        m_CameraMovement = asset.FindActionMap("CameraMovement", throwIfNotFound: true);
        m_CameraMovement_Movement = m_CameraMovement.FindAction("Movement", throwIfNotFound: true);
        m_CameraMovement_Rotation = m_CameraMovement.FindAction("Rotation", throwIfNotFound: true);
        m_CameraMovement_Zoom = m_CameraMovement.FindAction("Zoom", throwIfNotFound: true);
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

    // LevelEditor
    private readonly InputActionMap m_LevelEditor;
    private ILevelEditorActions m_LevelEditorActionsCallbackInterface;
    private readonly InputAction m_LevelEditor_SpawnTile;
    private readonly InputAction m_LevelEditor_RemoveTile;
    public struct LevelEditorActions
    {
        private @InputManager m_Wrapper;
        public LevelEditorActions(@InputManager wrapper) { m_Wrapper = wrapper; }
        public InputAction @SpawnTile => m_Wrapper.m_LevelEditor_SpawnTile;
        public InputAction @RemoveTile => m_Wrapper.m_LevelEditor_RemoveTile;
        public InputActionMap Get() { return m_Wrapper.m_LevelEditor; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(LevelEditorActions set) { return set.Get(); }
        public void SetCallbacks(ILevelEditorActions instance)
        {
            if (m_Wrapper.m_LevelEditorActionsCallbackInterface != null)
            {
                @SpawnTile.started -= m_Wrapper.m_LevelEditorActionsCallbackInterface.OnSpawnTile;
                @SpawnTile.performed -= m_Wrapper.m_LevelEditorActionsCallbackInterface.OnSpawnTile;
                @SpawnTile.canceled -= m_Wrapper.m_LevelEditorActionsCallbackInterface.OnSpawnTile;
                @RemoveTile.started -= m_Wrapper.m_LevelEditorActionsCallbackInterface.OnRemoveTile;
                @RemoveTile.performed -= m_Wrapper.m_LevelEditorActionsCallbackInterface.OnRemoveTile;
                @RemoveTile.canceled -= m_Wrapper.m_LevelEditorActionsCallbackInterface.OnRemoveTile;
            }
            m_Wrapper.m_LevelEditorActionsCallbackInterface = instance;
            if (instance != null)
            {
                @SpawnTile.started += instance.OnSpawnTile;
                @SpawnTile.performed += instance.OnSpawnTile;
                @SpawnTile.canceled += instance.OnSpawnTile;
                @RemoveTile.started += instance.OnRemoveTile;
                @RemoveTile.performed += instance.OnRemoveTile;
                @RemoveTile.canceled += instance.OnRemoveTile;
            }
        }
    }
    public LevelEditorActions @LevelEditor => new LevelEditorActions(this);

    // CameraMovement
    private readonly InputActionMap m_CameraMovement;
    private ICameraMovementActions m_CameraMovementActionsCallbackInterface;
    private readonly InputAction m_CameraMovement_Movement;
    private readonly InputAction m_CameraMovement_Rotation;
    private readonly InputAction m_CameraMovement_Zoom;
    public struct CameraMovementActions
    {
        private @InputManager m_Wrapper;
        public CameraMovementActions(@InputManager wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_CameraMovement_Movement;
        public InputAction @Rotation => m_Wrapper.m_CameraMovement_Rotation;
        public InputAction @Zoom => m_Wrapper.m_CameraMovement_Zoom;
        public InputActionMap Get() { return m_Wrapper.m_CameraMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CameraMovementActions set) { return set.Get(); }
        public void SetCallbacks(ICameraMovementActions instance)
        {
            if (m_Wrapper.m_CameraMovementActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_CameraMovementActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_CameraMovementActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_CameraMovementActionsCallbackInterface.OnMovement;
                @Rotation.started -= m_Wrapper.m_CameraMovementActionsCallbackInterface.OnRotation;
                @Rotation.performed -= m_Wrapper.m_CameraMovementActionsCallbackInterface.OnRotation;
                @Rotation.canceled -= m_Wrapper.m_CameraMovementActionsCallbackInterface.OnRotation;
                @Zoom.started -= m_Wrapper.m_CameraMovementActionsCallbackInterface.OnZoom;
                @Zoom.performed -= m_Wrapper.m_CameraMovementActionsCallbackInterface.OnZoom;
                @Zoom.canceled -= m_Wrapper.m_CameraMovementActionsCallbackInterface.OnZoom;
            }
            m_Wrapper.m_CameraMovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Rotation.started += instance.OnRotation;
                @Rotation.performed += instance.OnRotation;
                @Rotation.canceled += instance.OnRotation;
                @Zoom.started += instance.OnZoom;
                @Zoom.performed += instance.OnZoom;
                @Zoom.canceled += instance.OnZoom;
            }
        }
    }
    public CameraMovementActions @CameraMovement => new CameraMovementActions(this);
    public interface ILevelEditorActions
    {
        void OnSpawnTile(InputAction.CallbackContext context);
        void OnRemoveTile(InputAction.CallbackContext context);
    }
    public interface ICameraMovementActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnRotation(InputAction.CallbackContext context);
        void OnZoom(InputAction.CallbackContext context);
    }
}

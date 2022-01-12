using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

[CreateAssetMenu(fileName = "InputController", menuName = "Input/Input Controller")]

public class InputController : ScriptableObject, InputManager.ILevelEditorActions
{
    InputManager inputManager;

    #region Events

    //Events for LevelEditor controls
    public event UnityAction<string> ChangeTileEvent = delegate { };

    #endregion

    #region Enable/Disable

    private void OnEnable()
    {
        if (inputManager == null)
        {
            inputManager = new InputManager();

            inputManager.LevelEditor.SetCallbacks(this);
        }

        inputManager.Enable();
    }

    private void OnDisable()
    {
        inputManager.Disable();
    }

    #endregion

    #region LevelEditor Callbacks

    public void OnSpawnTile(InputAction.CallbackContext ctx)
    {
        if (ctx.started)
            ChangeTileEvent.Invoke("Spawn");
    }

    public void OnRemoveTile(InputAction.CallbackContext ctx)
    {
        if (ctx.started)
            ChangeTileEvent.Invoke("Remove");
    }

    #endregion

    #region Enable/Disable Action Maps

    #endregion
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[CreateAssetMenu(menuName = "InputReader")]
public class InputReader : ScriptableObject, GameController.IGameplayActions
{
    private GameController _gameController; 

    private void OnEnable(){
        if(_gameController == null){
            _gameController = new GameController();
            _gameController.Gameplay.SetCallbacks(this);
            _gameController.Enable();
        }
    }
    private void OnDisable(){
        _gameController.Disable();
    }

    public event Action<Vector2> MoveEvent;

    public event Action MouseClick;

    public event Action<Vector2> AimEvent;

    public void OnMouseClick(InputAction.CallbackContext context)
    {
        if(context.phase == InputActionPhase.Performed){
            MouseClick?.Invoke();
        }
    }

    public void OnMousePosition(InputAction.CallbackContext context)
    {
        AimEvent?.Invoke(context.ReadValue<Vector2>());
    }

    public void OnMovement(InputAction.CallbackContext context)
    {
        MoveEvent?.Invoke(context.ReadValue<Vector2>());
    }
}

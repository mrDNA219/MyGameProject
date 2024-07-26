using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerStateManager : MonoBehaviour
{
    PlayerBaseState currentState;

    public PlayerActiveState ActiveState = new();
    public PlayerDeadState DeadState = new();
    void Start()
    {
        currentState = ActiveState;
        currentState.EnterState(this);
    }

    // Update is called once per frame
    void Update()
    {
        currentState.UpdateState(this);
    }
    public void SwitchState(PlayerBaseState state){
        currentState = state;
        state.EnterState(this);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActiveState : PlayerBaseState
{
    
    Vector3 playerPosition;
    public override void EnterState(PlayerStateManager player){
        Debug.Log("Starting Active State");
    }
    public override void UpdateState(PlayerStateManager player){
        Debug.Log("Active");
    }
}

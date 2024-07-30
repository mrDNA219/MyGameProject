using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeadState : PlayerBaseState
{
    public override void EnterState(PlayerStateManager player)
    {
        Debug.Log("Starting Dead State");
    }
    public override void UpdateState(PlayerStateManager player)
    {
        Debug.Log("dead");
  }
}

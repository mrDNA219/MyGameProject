using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   [SerializeField] private InputReader input;
   [SerializeField] private float speed;

   private Vector2 _moveDirection;

   private void Start(){
    input.MoveEvent += HandleMove;

   }
   private void Update(){
    Move();
   }

   private void HandleMove(Vector2 direction){
        _moveDirection = direction;
   }

   private void Move(){
    if(_moveDirection == Vector2.zero){
        return;
    }
    transform.position += new Vector3(-_moveDirection.y, 0, _moveDirection.x) * (speed * Time.deltaTime);
   }
}

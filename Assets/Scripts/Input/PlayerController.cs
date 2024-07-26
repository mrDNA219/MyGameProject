using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   [SerializeField] private InputReader input;
   [SerializeField] private float speed;
   [SerializeField] private GameObject _targetingReticule;
    Quaternion target = Quaternion.Euler(90, 0, 180);

   private Vector2 _moveDirection;
   private Vector2 _aimDirection;

   private void Start(){
    input.MoveEvent += HandleMove;
    var targetingReticule = Instantiate(_targetingReticule, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
    targetingReticule.transform.rotation = Quaternion.Euler(90, 0, 180);
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
   private void HandleAim(Vector2 direction){
        _aimDirection = direction;
   }
   

}

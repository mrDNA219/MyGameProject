using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetingReticule : MonoBehaviour
{
    Quaternion target = Quaternion.Euler(90, 0, 180);

    
    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * 5.0f);
    }
}

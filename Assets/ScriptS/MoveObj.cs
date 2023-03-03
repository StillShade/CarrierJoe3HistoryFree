using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObj : MonoBehaviour
{
    
    
    public Vector2 mover;
    public float speed;
   
    void FixedUpdate()
    {
        transform.Translate(mover.normalized * speed);
    }
}

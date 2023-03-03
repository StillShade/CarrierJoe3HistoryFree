using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitchhiker : MonoBehaviour
{
    public GameObject hitchhikerPnl;
    public GameObject Camera;
    public float speed;

    void Update()
    {
        speed = Camera.GetComponent<Movecar>().speed;
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (speed <= 1)
        {
            hitchhikerPnl.SetActive(true);
        }
    }
}

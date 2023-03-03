using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{    
    public GameObject patrolOn;
    public GameObject patrolOnScript;
    public int rndOn;

    public void ActivePatrol()
    {
        rndOn = Random.Range(1, 101);
        patrolOnScript.GetComponent<PatrolOn>().ActivePatrolOn();
    }    

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (rndOn <= 40)
        {
            patrolOn.SetActive(true);
        }           
    }
}

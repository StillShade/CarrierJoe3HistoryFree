using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolOn : MonoBehaviour
{
    public GameObject patrol;
    public GameObject Camera;
    private float speed;
    public GameObject pnlPatrol;
    public GameObject dashBoardPatrolShtraf;
    public GameObject patrolOn;
    public GameObject patrolSignal;
    public AudioSource click;
    public int rndOn;
    public int verPass;
    public int i;

    public void ActivePatrolOn()
    {
        verPass = 0;
        i = 0;
    }
    void Update()
    {
        speed = Camera.GetComponent<Movecar>().speed;
        rndOn = patrol.GetComponent<Patrol>().rndOn;
    }
    IEnumerator delay()
    {
        yield return new WaitForSeconds(5f);
        dashBoardPatrolShtraf.SetActive(false);
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (rndOn <= 40)
            {
                if (speed < 1)
                {
                    if(verPass < 1)
                    {
                        pnlPatrol.SetActive(true);
                        patrolOn.SetActive(false);
                        patrolSignal.SetActive(false);
                        verPass++;
                    }                    
                }
            }           
        }       
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (rndOn <= 40)
            {
                if (verPass < 1)
                {
                    if (i < 1)
                    {
                        dashBoardPatrolShtraf.SetActive(true);
                        patrolOn.SetActive(false);
                        patrolSignal.SetActive(false);
                        click.Play();
                        Main.Money -= 5000;
                        StartCoroutine(delay());
                        i++;
                    }
                }
            }            
        }        
    }
}

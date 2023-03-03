using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolRnd : MonoBehaviour
{
    public GameObject patrol1;
    public GameObject patrol2;
    public GameObject patrol3;

    public int rndPatrol1;
    public int rndPatrol2;
    public int rndPatrol3;

    public void ActiveRndPatrol()
    {
        rndPatrol1 = Random.Range(1, 101);
        rndPatrol2 = Random.Range(1, 101);
        rndPatrol3 = Random.Range(1, 101);
    }

    
    public void ActivePatrol()
    {
        ActiveRndPatrol();

        if (rndPatrol1 <= 40)
        {
            patrol1.SetActive(true);
            patrol1.GetComponent<Patrol>().ActivePatrol();
        }
        else patrol1.SetActive(false);

        if (rndPatrol2 <= 40)
        {
            patrol2.SetActive(true);
            patrol2.GetComponent<Patrol>().ActivePatrol();
        }
        else patrol2.SetActive(false);

        if (rndPatrol3 <= 40)
        {
            patrol3.SetActive(true);
            patrol3.GetComponent<Patrol>().ActivePatrol();
        }
        else patrol3.SetActive(false);
    }
}

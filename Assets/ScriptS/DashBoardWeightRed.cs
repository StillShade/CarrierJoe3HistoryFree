using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashBoardWeightRed : MonoBehaviour
{
    public GameObject dashBoardWeightRed;
    public GameObject dashBoardWeightGreen;

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            dashBoardWeightRed.SetActive(false);
            dashBoardWeightGreen.SetActive(false);
        }       
    }
}

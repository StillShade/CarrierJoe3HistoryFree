using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class offShtrafPnl2 : MonoBehaviour
{
    public GameObject shtrafPnl2;

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
            shtrafPnl2.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbientSoundsOff : MonoBehaviour
{
    public GameObject presenceObj;
    public GameObject ambientSoundsOn;
    public GameObject ambientSoundsOff;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            presenceObj.SetActive(false);
            ambientSoundsOn.SetActive(true);
            ambientSoundsOff.SetActive(false);
        }
    }
}

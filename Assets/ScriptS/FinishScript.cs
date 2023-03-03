using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinishScript : MonoBehaviour
{    
    public int i;
    public GameObject PanelFinish;    

    void Start()
    {
        i = 0;        
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PanelFinish.SetActive(true);
        }
    }
}

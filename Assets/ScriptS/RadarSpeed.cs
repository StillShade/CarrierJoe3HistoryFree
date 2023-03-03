using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadarSpeed : MonoBehaviour
{
    [Header("Панель штрафов")]
    public GameObject shtrafPnl;    
    [Header("Рандомное состояние камеры")]
    public int randomCam;
    public GameObject cameraOn;
    public GameObject cameraOff;
    [Header("Скорость и ограничение")]
    public float speed;
    public float speedLimit;
    public int i;
    public AudioSource click;
    void Start()
    {
        i = 0;
        randomCam = Random.Range(1, 11);
        if (randomCam >= 6)
        {
            cameraOn.SetActive(true);
            cameraOff.SetActive(false);            
        }
        else
        {
            cameraOff.SetActive(true);
            cameraOn.SetActive(false);            
        }            
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (i < 1)
        {
            if (other.CompareTag("Player"))
            {
                if (speed > (speedLimit + 19))
                {
                    click.Play();
                    shtrafPnl.SetActive(true);
                    Main.Money -= 500;
                    i++;
                }
            }
        }        
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            shtrafPnl.SetActive(false);            
        }
    }
    void Update()
    {
        speed = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Movecar>().realSpeed;
    }
}

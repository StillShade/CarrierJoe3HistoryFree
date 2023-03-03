using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveAZS : MonoBehaviour
{	
	public GameObject activeAzs;
	

	private float speed;

	private void Update()
    {
		speed = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Movecar>().speed;
	}	

	void OnTriggerStay2D(Collider2D other)
	{
		if (other.CompareTag("Player"))
		{
			if (speed <= 1)
			{				
				activeAzs.SetActive(true);
			}			
		}
	}

    private void OnTriggerExit2D(Collider2D other)
    {
		if (other.CompareTag("Player"))
		{
			activeAzs.SetActive(false);
		}
	}
}

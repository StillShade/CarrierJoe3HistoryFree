using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShtrafScript2 : MonoBehaviour
{

	public GameObject shtrafPnl2;
	public float speed;
	public int i;
	public AudioSource click;

	void Start()
	{
		i = 0;
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("Player"))
		{
			if (i < 1)
			{
				if (speed > 1)
				{
					click.Play();
					Main.Money -= 1000;
					shtrafPnl2.SetActive(true);					
					i++;					
				}
			}
		}
	}	

	void Update()
	{
		speed = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Movecar>().speed;
	}
}

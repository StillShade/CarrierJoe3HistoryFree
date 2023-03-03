using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedLimit : MonoBehaviour
{
	public float speed;

	void OnTriggerStay2D(Collider2D other)
	{
		if (other.CompareTag("Player"))
		{
			if(Main.Gear > 0 && Main.Gear < 5)
			GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Movecar>().carSpeed = -400;	
		}
	}	
	void Update()
	{
		speed = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Movecar>().speed;
	}
}
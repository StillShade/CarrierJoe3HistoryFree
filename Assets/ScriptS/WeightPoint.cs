using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeightPoint : MonoBehaviour
{
	private float speed;
	public int fulfilledCondition;

	public GameObject Camera;
	public GameObject pnlWeight;

    public void FulFilCon()
    {
		fulfilledCondition = 0;
    }

    private void Update()
	{
		speed = Camera.GetComponent<Movecar>().speed;
	}

	void OnTriggerStay2D(Collider2D other)
	{
		if (other.CompareTag("Player"))
		{
			if (speed <= 1)
			{
				pnlWeight.SetActive(true);
				fulfilledCondition = 1;
			}
		}
	}
}

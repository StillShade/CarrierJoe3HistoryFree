using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleTrailerkWheels : MonoBehaviour
{
	public ParticleSystem smoke;

	void Update()
	{
		if (Main.Smoke == 2)
		{
			smoke.Play();
		}
		else
		{
			smoke.Stop();
		}
	}
}

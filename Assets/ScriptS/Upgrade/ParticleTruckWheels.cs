using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleTruckWheels : MonoBehaviour
{
	public ParticleSystem smoke;

	void Update()
	{
		if (Main.Smoke == 1)
		{
			smoke.Play();
		}
		else
		{
			smoke.Stop();
		}
	}
}

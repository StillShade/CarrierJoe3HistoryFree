using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleTruck : MonoBehaviour
{
	public ParticleSystem smoke;

	void Update()
	{
		if (Main.TruckSmoke == 1)
		{
			smoke.Play();
		}
		else
		{
			smoke.Stop();
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GPS : MonoBehaviour
{
	public GameObject finish;
	public GameObject dashbordGPS;
	public Text Ostaloskmtext;
	public float ostaloskm;
	public Transform _cashedPlayerTransform;

	public float realSpeed;
	public float startPos;
	public float endPos;
	public int i = 0;
    
    public void StartRealSpeed()
    {
		StartCoroutine(delay());
	}

    IEnumerator delay()
	{
		startPos = ostaloskm;
		yield return new WaitForSeconds(0.5f);
		endPos = ostaloskm;
		realSpeed = (startPos - endPos) * 110f;
		StartCoroutine(delay());
	}	

	void Update()
	{
		_cashedPlayerTransform = GameObject.FindGameObjectWithTag("Player").transform;
		ostaloskm = ((finish.transform.position.x - _cashedPlayerTransform.position.x) / 10);
		if (ostaloskm > 0)
		{
			Ostaloskmtext.text = ostaloskm.ToString("0.0") + " km" + "  ->";
		}
		Main.RealSpeed = realSpeed;
	}
}

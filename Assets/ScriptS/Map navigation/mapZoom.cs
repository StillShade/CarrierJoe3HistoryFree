using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapZoom : MonoBehaviour
{
    public GameObject Map;
	
	public float CamZ = 0f;

	public void CamZoomPlus()
	{
		if (CamZ >= 25f)
		{
			transform.position = new Vector3(transform.position.x, transform.position.y, CamZ - 25);
		}
	}	
	public void CamZoomMinus()
	{
		if (CamZ <= 100f)
		{
			transform.position = new Vector3(transform.position.x, transform.position.y, CamZ + 25);
		}
	}
	void Start()
	{
		CamZ = 10;
	}
	void Update()
    {
        CamZ = Map.GetComponent<RectTransform>().position.z;
    }
}

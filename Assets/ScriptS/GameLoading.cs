using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameLoading : MonoBehaviour {

	public GameObject loadingInfo;
	private AsyncOperation async;
	public GameObject ImgLoad1;
	public GameObject ImgLoad2;
	public GameObject ImgLoad3;
	public GameObject ImgLoad4;
	public GameObject ImgLoad5;
	public GameObject ImgLoad6;
	public GameObject ImgLoad7;
	public GameObject ImgLoad8;
	public GameObject ImgLoad9;
	public GameObject ImgLoad10;
	public GameObject ImgLoad11;
	public GameObject ImgLoad12;
	public GameObject ImgLoad13;
	public GameObject ImgLoad14;
	public GameObject ImgLoad15;

	int r;
	
	IEnumerator Start() 
	{
		r = Random.Range(0, 13);

		switch (r)
		{
			case 0:
				ImgLoad1.SetActive(true);
				break;
			case 1:
				ImgLoad2.SetActive(true);
				break;
			case 2:
				ImgLoad3.SetActive(true);
				break;
			case 3:
				ImgLoad4.SetActive(true);
				break;
			case 4:
				ImgLoad5.SetActive(true);
				break;
			case 5:
				ImgLoad6.SetActive(true);
				break;
			case 6:
				ImgLoad7.SetActive(true);
				break;
			case 7:
				ImgLoad8.SetActive(true);
				break;
			case 8:
				ImgLoad9.SetActive(true);
				break;
			case 9:
				ImgLoad10.SetActive(true);
				break;
			case 10:
				ImgLoad11.SetActive(true);
				break;
			case 11:
				ImgLoad12.SetActive(true);
				break;
			case 12:
				ImgLoad13.SetActive(true);
				break;
			case 13:
				ImgLoad14.SetActive(true);
				break;
			case 14:
				ImgLoad15.SetActive(true);
				break;
		}		

		async = SceneManager.LoadSceneAsync(GameMenedjer.levelName);
		loadingInfo.SetActive(false);
		yield return true;
		async.allowSceneActivation = false;
		loadingInfo.SetActive(true);
	}

	public void GoLevel () {
		async.allowSceneActivation = true;
	}

}

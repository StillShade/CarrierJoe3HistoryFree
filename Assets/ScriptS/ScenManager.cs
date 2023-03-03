using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScenManager : MonoBehaviour
{
    [Header("����������� �����")]
    public int sceneID;
    [Header("��������� �������")]
    public Image loadingImg;
    public Text progressTx;
   
    void Start()
    {
        StartCoroutine(AsyncLoad());
    }

    
    IEnumerator AsyncLoad()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneID);
        while (!operation.isDone)
        {
            float progress = operation.progress / 0.9f;
            loadingImg.fillAmount = progress;
            progressTx.text = string.Format("{0:0}%", progress * 100);
            yield return null;
        }
    }
}

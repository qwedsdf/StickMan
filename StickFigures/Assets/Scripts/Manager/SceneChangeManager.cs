using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneChangeManager : SingletonMonoBehaviour<SceneChangeManager>
{
    public GameObject feedImg;
    private float FeedSpeed;

	// Use this for initialization
	void Start () {
        feedImg.SetActive(false);
        FeedSpeed = 3f;
    }
	
	// Update is called once per frame
	void Update () {
		
	}


	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
	static void LoadManagerScene()
	{
		SceneManager.LoadSceneAsync(DefineData.SCENE_MANAGER, UnityEngine.SceneManagement.LoadSceneMode.Additive);
	}

	public void LoadScene(string scene_name)
	{
        StartCoroutine("SceneChange", scene_name);
	}


    IEnumerator SceneChange(string scene_name){
        float alpha = 0;
        feedImg.SetActive(true);
        while (alpha < 1)
        {
            alpha += Time.deltaTime * FeedSpeed;
            feedImg.GetComponent<Image>().color = new Color(255f,255f,255f,alpha);
            yield return null;
        }

        AsyncOperation async = SceneManager.LoadSceneAsync(scene_name);
        while (!async.isDone)
        {
            yield return null;
        }

        while (alpha > 0)
        {
            alpha -= Time.deltaTime * FeedSpeed;
            feedImg.GetComponent<Image>().color = new Color(255f, 255f, 255f, alpha);
            yield return null;
        }
        feedImg.SetActive(false);
    }
}

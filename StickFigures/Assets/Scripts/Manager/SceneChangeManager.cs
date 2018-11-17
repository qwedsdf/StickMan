using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeManager : SingletonMonoBehaviour<SceneChangeManager>
{

	// Use this for initialization
	void Start () {
		
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
		SceneManager.LoadScene(scene_name);
	}
}

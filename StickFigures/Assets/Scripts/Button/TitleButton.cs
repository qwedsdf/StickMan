using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		LoadScene();
	}

	void LoadScene()
	{
		if(Input.GetMouseButton(0)) SceneChangeManager.Instance.LoadScene(DefineData.SCENE_FACTURING);
	}
}

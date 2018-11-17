using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleButton : MonoBehaviour {
	public GameObject Stickman;

	void Start () {
		
	}
	
	void Update () {
		
	}

	public void FormStickman()
	{
		Vector3 pos = new Vector3( Random.Range(0.0f,0.5f), Random.Range(0.0f, 1f),0f);
		Vector3 pos1 = transform.position;
		Vector3 pos2 = pos + pos1;
		Instantiate(Stickman, pos2,Quaternion.identity);
	}
}

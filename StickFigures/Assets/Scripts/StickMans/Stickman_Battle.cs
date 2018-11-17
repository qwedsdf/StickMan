using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stickman_Battle : StickmanBase
{

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void FixedUpdate()
	{
		Move(DefineData.LEFT);
	}

	private void OnTriggerEnter2D(Collider2D col)
	{
		if (col.tag == "Enemy")
		{
			Destroy(this.gameObject);
		}
	}
}

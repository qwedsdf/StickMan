using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stickman_Battle : StickmanBase
{
	public float AttackPowwer;

	// Use this for initialization
	void Start () {
		AttackPowwer = 1;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void FixedUpdate()
	{
		Move(DefineData.LEFT);
	}
}

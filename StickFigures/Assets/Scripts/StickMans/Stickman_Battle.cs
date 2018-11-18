using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stickman_Battle : StickmanBase
{
	public float AttackPowwer;
    bool walk_flg;

	// Use this for initialization
	void Start () {
        walk_flg = false;
        AttackPowwer = 1;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void FixedUpdate()
	{
		if(walk_flg)Move(DefineData.LEFT);
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "floor")
        {
            walk_flg = true;
        }
    }
}

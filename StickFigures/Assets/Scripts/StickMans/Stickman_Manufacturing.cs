using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stickman_Manufacturing : StickmanBase
{
	int TimeCount;
	const int ChangeDirectionIntervalTime = 20;
	int direction;
	

	void Start () {
		TimeCount = 0;
		direction = (int)Random.Range(0.0f,4.9f);
	}
	
	void Update () {

	}

	private void FixedUpdate()
	{
		MoveStickman();
	}

	private void MoveStickman()
	{
		TimeCount++;
		if(TimeCount% ChangeDirectionIntervalTime == 0)
		{
			direction = (int)Random.Range(0.0f, 3.9f);
		}
		Move(direction);
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag == "Wall")
		{
			direction = (int)Random.Range(0.0f, 3.9f);
		}
	}
}

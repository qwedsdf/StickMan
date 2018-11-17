using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickmanBase : MonoBehaviour {
	private const int SPD = 5;

	/// <summary>
	/// 指定した方向にスティックマンを移動
	/// </summary>
	/// <param name="direction">進む方向</param>
	public void Move(int direction)
	{
		Vector3 pos = transform.position;
		switch (direction) {
			case DefineData.LEFT:
				pos.x += SPD * Time.deltaTime;
				break;
			case DefineData.UP:
				pos.y += SPD * Time.deltaTime;
				break;
			case DefineData.RIGHT:
				pos.x -= SPD * Time.deltaTime;
				break;
			case DefineData.DOWN:
				pos.y -= SPD * Time.deltaTime;
				break;
		}
		
		transform.position = pos;
	}
	
}

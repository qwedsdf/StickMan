using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : MonoBehaviour {
	float HP = 10;
	float Max_HP;

	void Start () {
		Max_HP = HP;
	}
	

	void Update () {
		
	}

	private void OnTriggerEnter2D(Collider2D col)
	{
		if (col.tag == DefineData.STICKMAN_TAG)
		{
			HP -= col.gameObject.GetComponent<Stickman_Battle>().AttackPowwer;
			Destroy(col.gameObject);
			float size = HP / Max_HP;
			transform.Find("EnemySprite").transform.localScale = new Vector2(size, size);
			if (HP < 1) Destroy(this.gameObject);
		}
	}
}

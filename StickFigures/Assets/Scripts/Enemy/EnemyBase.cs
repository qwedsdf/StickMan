using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyBase : MonoBehaviour {
	float HP = 10;
	float Max_HP;
    public Slider slider;

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
            slider.value = HP / Max_HP;
            if (HP < 1)
            {
                Destroy(this.gameObject);
            }
		}
	}
}

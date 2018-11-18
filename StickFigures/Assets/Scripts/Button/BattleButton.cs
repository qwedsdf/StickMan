using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleButton : MonoBehaviour {
	public GameObject Stickman;
    public float powwer;
    GameObject Cannon;
    Vector3 CannonAngle;


    void Start () {
        Cannon = GameObject.Find("Cannon").gameObject;
    }
	
	void Update () {
		
	}

	public void FormStickman()
	{
		Vector3 pos = new Vector3( Random.Range(0.0f,0.5f), Random.Range(0.0f, 1f),0f);
		Vector3 pos1 = transform.position;
		Vector3 pos2 = pos + pos1;
		GameObject gameobject = Instantiate(Stickman, pos2,Quaternion.identity);

        Rigidbody2D rb = gameobject.GetComponent<Rigidbody2D>();

        GetCannonAngle();
        rb.AddForce(CannonAngle * powwer, ForceMode2D.Impulse);
    }

    public void GetCannonAngle()
    {
        CannonAngle= Quaternion.Euler(Cannon.transform.localEulerAngles) * new Vector2(0f, 1f).normalized;
        Debug.Log(CannonAngle);
    }
}

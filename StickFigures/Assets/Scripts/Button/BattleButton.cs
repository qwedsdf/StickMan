using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleButton : MonoBehaviour {
	public GameObject Stickman;
    public float powwer;
    GameObject Cannon;
    Vector3 CannonAngle;
    public Text Text_Stock;


    void Start () {
        Cannon = GameObject.Find("CannonPivot").gameObject;
        Text_Stock.text = GameData.StickmanStock.ToString();
    }
	
	void Update () {
		
	}

	public void FormStickman()
	{
        if (GameData.StickmanStock == 0) return;
		Vector3 pos = new Vector3( Random.Range(0.0f,0.5f), Random.Range(0.0f, 1f),0f);
		Vector3 pos1 = transform.position;
		Vector3 pos2 = pos + pos1;
		GameObject gameobject = Instantiate(Stickman, pos2,Quaternion.identity);

        Rigidbody2D rb = gameobject.GetComponent<Rigidbody2D>();

        GetCannonAngle();
        rb.AddForce(CannonAngle*powwer, ForceMode2D.Impulse);

        GameData.StickmanStock--;
        Text_Stock.text = GameData.StickmanStock.ToString();
    }

    public void GetCannonAngle()
    {
        CannonAngle= Quaternion.Euler(Cannon.transform.localEulerAngles) *  new Vector2(0f, 1f).normalized;
        Debug.Log(CannonAngle);
    }

    public void ReturnFactory()
    {
        SceneChangeManager.Instance.LoadScene(DefineData.SCENE_FACTURING);
    }
}

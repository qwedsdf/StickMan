using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManufacturingButton : MonoBehaviour {
	public GameObject Stickman;
	public Transform FromPos;
	public GameObject TextObject;

	private void Update()
	{
		ChackGetStickman();
	}

	/// <summary>
	/// 棒人間を生成する
	/// </summary>
	public void FromStickman()
	{
		Instantiate(Stickman, FromPos.position,Quaternion.identity);
	}

    public void LoadScene()
    {
        SceneChangeManager.Instance.LoadScene(DefineData.SCENE_GAME);
    }

	/// <summary>
	/// タッチし、スティックマンをゲットしているかどうかを調べる
	/// </summary>
	private void ChackGetStickman()
	{
		if (Input.GetMouseButton(0))
		{
			Vector2 tapPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Collider2D collition2d = Physics2D.OverlapPoint(tapPoint);
			if (collition2d&& collition2d.gameObject.tag== DefineData.STICKMAN_TAG)
			{
				Destroy(collition2d.gameObject);
				GameData.StickmanStock++;
				TextObject.GetComponent<Text>().text = GameData.StickmanStock.ToString();
			}
		}
	}
}

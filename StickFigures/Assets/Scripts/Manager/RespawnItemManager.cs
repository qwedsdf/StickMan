using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item
{
    public Sprite img;
    public int id;
}

public class RespawnItemManager : SingletonMonoBehaviour<RespawnItemManager>
{
    Item getitem;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public Item RespawnItem()
    {
        StartCoroutine("RespawnItemStaging");

        return getitem;
    }

    IEnumerator RespawnItemStaging()
    {
        yield return new WaitForSeconds(2.0f);

        getitem = GetItem();
    }

    private Item GetItem()
    {
        Item item = new Item();
        item.id = 0;
        item.img = Resources.Load<Sprite>("Textures/Item/shirt_00");

        return item;
    }
}

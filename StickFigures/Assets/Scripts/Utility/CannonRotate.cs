using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonRotate : MonoBehaviour {


    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        RotateCannon();
    }

    /// <summary>
    /// 大砲を回転させる
    /// </summary>
    void RotateCannon()
    {

        if (Input.GetMouseButton(0))
        {
            Ray ray = new Ray();
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity);

            //マウスクリックした場所からRayを飛ばし、オブジェクトがあればtrue 
            if (hit.collider)
            {
                if (hit.collider.gameObject.CompareTag("RotateArea"))
                {
                    Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                    mousePos.z = 0f;
                    Vector3 diff = (mousePos - transform.position);

                    this.transform.rotation = Quaternion.FromToRotation(Vector3.up, diff);
                }
            }
            
        }
        
    }
}

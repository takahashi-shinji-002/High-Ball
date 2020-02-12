using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarScript : MonoBehaviour
{
	// Use this for initialization
	void Update ()
    {
        //  Barの座標を取る
        Transform BarTrans = GameObject.Find("Bar").transform;
        Vector3 pos = BarTrans.position;

        //  左キーを入力すると左にBarが動く
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if(pos.x > -15)
            {
                this.transform.Translate(-0.8f, 0f, 0f);
            }
            
        }
        //  右キーを入力すると右にBarが動く
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if(pos.x < 15)
            {
                this.transform.Translate(0.8f, 0f, 0f);
            }
            
        }
	}
}

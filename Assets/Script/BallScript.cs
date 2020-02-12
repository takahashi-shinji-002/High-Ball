using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {

    private float Speed = 250;

	// Use this for initialization
	void Start ()
    {
		//  RigidBodyの取得
        Rigidbody rb = GetComponent<Rigidbody>();
        //  力を設定
        Vector3 force = new Vector3(10.0f, 10,0f)*Speed;
        //  力を加える
        rb.AddForce(force);
	}
}

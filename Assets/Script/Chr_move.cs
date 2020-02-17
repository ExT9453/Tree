using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chr_move : MonoBehaviour {
	int speed=500;
	float xMove;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


		xMove = 0;


		if (Input.GetKey (KeyCode.RightArrow)) {
			xMove = speed * Time.deltaTime;
		} else if (Input.GetKey (KeyCode.LeftArrow)) {
			xMove = -speed * Time.deltaTime;
		}
		this.transform.Translate (new Vector3 (xMove, 0, 0));

	}
}

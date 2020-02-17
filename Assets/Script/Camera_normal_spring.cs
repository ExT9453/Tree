using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_normal_spring : MonoBehaviour {
	
	public GameObject A;
	Transform AT_A;
	// Use this for initialization
	void Start () {
		AT_A = A.transform;


	}

	// Update is called once per frame
	void Update () {

		transform.position = new Vector3 (AT_A.position.x, AT_A.position.y+250, AT_A.position.z - 10);




	}
}

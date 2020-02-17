using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRenderer_S : MonoBehaviour {
	LineRenderer lr;
	Vector3 chrPos, collPos;


	// Use this for initialization
	void Start () {
		lr = GetComponent<LineRenderer>();
		lr.startWidth = .05f;
		lr.endWidth = .05f;



	}
	
	// Update is called once per frame
	void Update () {
		chrPos = gameObject.GetComponent<Transform>().position;

		lr.SetPosition(0, chrPos);
		lr.SetPosition(1, GameObject.Find("chr_skill_1_shoot").GetComponent<Transform>().position);


	}
}

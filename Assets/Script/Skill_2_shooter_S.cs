using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill_2_shooter_S : MonoBehaviour {
	public GameObject shoot;
	Vector2 dir;
	public float speed=3000;
	GameObject tempobj;
	public GameObject chr;
	Transform chr_p;

	// Use this for initialization
	void Start () {
		chr_p = chr.transform;
		dir = (Camera.main.ScreenToWorldPoint (Input.mousePosition) - shoot.transform.position);

	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetMouseButton (0)) {
			tempobj = Instantiate (shoot,chr_p.position + new Vector3 (50, 50, 0) ,Quaternion.identity);
				
			tempobj.GetComponent<Transform> ().transform.Translate (dir.normalized * speed * Time.deltaTime);

		}

	}
}

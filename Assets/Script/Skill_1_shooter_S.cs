using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill_1_shooter_S : MonoBehaviour {
	public GameObject shoot;
	public GameObject chr;
	public Camera maincamera;
	public Transform firepoint;
	Vector3 firedirection;
	public float firespeed=10000;
	bool enableshoot=true;
	GameObject tempobj;
	Vector3 lastInputPosition;
	Vector3 tempVector3;
	Vector2 tempVector2=new Vector2();
	Transform chr_pos;
	// Use this for initialization
	void Start () {
		chr_pos = chr.transform;


	}

	// Update is called once per frame
	void Update () {
		this.transform.position = new Vector3 (chr_pos.position.x, chr_pos.position.y, 0);
		if (Input.GetMouseButton (0)) {
			lastInputPosition = Input.mousePosition;
			if (enableshoot) {
				//애니메이션 변환
				FireTrigger();
				tempobj.transform.localScale = new Vector3 (50.0f, 50.0f, 50.0f);
			}
		}
	}

	void FireTrigger()
	{
		Fire (lastInputPosition);
	}
	void FireEnd()
	{
		enableshoot = true;
	}
	void Fire(Vector3 inputPosition)
	{
		//입력위치를 카메라가 바라보는 영역 안의 절대좌표로 변환
		tempVector3 = maincamera.ScreenToWorldPoint (inputPosition);
		tempVector3.z = 0;
		//벡터의 뺄셈 후 방향만 지닌 단위벡터로 변경
		firedirection = tempVector3 - firepoint.position;
		firedirection = firedirection.normalized;
		//발사
		tempobj = Instantiate (shoot, firepoint.position,
			Quaternion.LookRotation (firedirection)) as GameObject;
		//투사체 속도 계산
		tempVector2.Set(firedirection.x,firedirection.y);
		tempVector2 = tempVector2 * firespeed;
		//속도 적용
		tempobj.GetComponent<Rigidbody2D>().velocity=tempVector2; 







	}
}

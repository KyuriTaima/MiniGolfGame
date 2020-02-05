using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallShooting : MonoBehaviour {

	public Camera mainCam;
	public float intervall = 0F;
	public static int tries = 0;

	public Vector3 startPos;

	// Use this for initialization
	void Start () {
		startPos = this.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		float forcepower = 10.0f;
		if(Input.GetMouseButtonDown(0)){
			intervall = Time.time;
		}
		if(Input.GetMouseButtonUp(0)){
			tries++;
			intervall = Time.time-intervall;
			forcepower = intervall*10;
			Debug.Log(forcepower);
			Rigidbody rigid = this.transform.GetComponent<Rigidbody>();
			Vector3 vect = mainCam.transform.forward;
			vect.y = 0;
			rigid.AddForce(vect * forcepower, ForceMode.Impulse);
		}
		if(this.transform.position.y < 0){
			Rigidbody rigid = this.transform.GetComponent<Rigidbody>();
			rigid.velocity = Vector3.zero;
			this.transform.position = startPos;
		}

	}
}

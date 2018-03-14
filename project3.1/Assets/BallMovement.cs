using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour {
	public Rigidbody R2;
	private int Speed=5;
	private int SpeedForLR=10;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	R2.velocity = new Vector3 (0f,0f,-Speed);
		if(Input.GetMouseButton(0)){
			R2.velocity = new Vector3 (SpeedForLR,0f,-Speed);
			R2.constraints = RigidbodyConstraints.FreezeRotationX;
			R2.constraints = RigidbodyConstraints.FreezeRotationX;
		//	R2.velocity = new Vector3 (0f,0f,-Speed);
		}
		if(Input.GetMouseButton(1)){
			//R2.velocity = new Vector3 (-SpeedForLR,0f,0f);
			R2.constraints = RigidbodyConstraints.FreezeRotationX;
	    	R2.constraints = RigidbodyConstraints.FreezeRotationX;
			R2.velocity = new Vector3 (-SpeedForLR,0f,-Speed);
		}
	}
}

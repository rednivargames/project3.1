using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour {
	public Rigidbody R2;
	public WheelCollider BallCollider;
	private int speed=5;
	public bool Grounded;
	public Transform CenterPoint;
	private float Radius = 1f;
	public LayerMask Ground;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	//	Grounded = Physics.OverlapSphere(CenterPoint.position,Radius,Ground);
	
		R2.velocity = new Vector3 (0f,0f,-speed);

	}
}

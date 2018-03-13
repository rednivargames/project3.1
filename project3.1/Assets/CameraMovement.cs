using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {
	public Transform Player;
	public Rigidbody R2;
	private float Speed=5f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	//	transform.position = new Vector3 (transform.position.x,transform.position.y,Player.position.z);
		R2.velocity = new Vector3 (0f,0f,-Speed);
	}
}

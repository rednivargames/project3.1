using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class playercontroller : MonoBehaviour {
	
	public float speed;
	public Text countText;
	public Text winText;
	private int count;
	private Rigidbody rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();	
		count = 0;
		SetCountText ();
		winText.text = "";
	}

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement*speed);
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("pickups"))
		{
			other.gameObject.SetActive (false);
			count = count + 1;
			SetCountText ();
		}
	}

	void SetCountText ()
	{
		countText.text = "Count: " + count.ToString ();
		if (count == 8) 
		{
			winText.text = "Game Over";
		}
	}
}

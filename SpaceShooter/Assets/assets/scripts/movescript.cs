using System.Collections.Generic;
using UnityEngine;

public class movescript : MonoBehaviour {
	private Rigidbody rb;
	void Start ()
	{
		rb = GetComponent<Rigidbody> ();
	}

	void FixedUpdate ()

	{
		
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		rb.velocity = movement;
	}

}
	// Use this for initialization
	
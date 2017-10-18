using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Boundary
{
	public float xMin, xMax, zMin, zMax;
}
public class movescript : MonoBehaviour {
	private Rigidbody rb;
	public float tilt;
	public Boundary boundary;
	public float speed;

	public GameObject Bolt;
	public Transform ShotSpawn;
	public float fireRate;

	private float nextFire;

	void Update ()
	{
		if (Input.GetButton("Fire1") && Time.time > nextFire)
		{
			nextFire = Time.time + fireRate;
			Instantiate(Bolt, ShotSpawn.position, ShotSpawn.rotation);
		}
	}

	void Start ()
	{
		rb = GetComponent<Rigidbody> ();
	}

	void FixedUpdate ()

	{
		
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (0.0f, 0.0f, moveVertical);
		rb.velocity = movement * speed;
		Vector3 angularMovement = new Vector3 (0.0f, moveHorizontal, 0.0f);
		rb.angularVelocity = angularMovement * speed;
		//transform.forward

		rb.position = new Vector3 
			(
			Mathf.Clamp (rb.position.x, boundary.xMin, boundary.xMax),
			0.0f, 
			Mathf.Clamp (rb.position.z, boundary.zMin, boundary.zMax)
		);
		//rb.rotation = Quaternion.Euler (0.0f, 0.0f, 0.0f);
	}

}
	// Use this for initialization
	
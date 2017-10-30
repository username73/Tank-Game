using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieScript : MonoBehaviour 
	{
		void OnTriggerEnter(Collider other) 
		{
			if (other.tag == "Boundary")
			{
				return;
			}
			Destroy(other.gameObject);
			Destroy(gameObject);
		}
	}
/*{
	public GameObject explosion;
	public GameObject playerExplosion;
	public int scoreValue;
	private GameController gameControllerA;

	void Start ()
	{
		GameObject gameControllerObject = GameObject.FindWithTag ("GameController");
		if (gameControllerObject != null)
		{
			gameController = gameControllerObject.GetComponent <gameController>();
		}
		if (gameController == null)
		{
			Debug.Log ("Cannot find 'GameController' script");
		}
	}

	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "Boundary")
		{
			return;
		}
		Instantiate(explosion, transform.position, transform.rotation);
		if (other.tag == "Player")
		{
			Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
			gameControllerA.gameOver ();
		}
		//gameController.AddScore (scoreValue);
		Destroy(other.gameObject);
		Destroy(gameObject); */
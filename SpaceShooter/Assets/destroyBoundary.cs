﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyBullets : MonoBehaviour 
{
	void OnTriggerExit(Collider other)
	{
		Destroy(other.gameObject);
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

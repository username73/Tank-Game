using System.Collections.Generic;
using UnityEngine;

public class movescript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//	ForPractice ();
	}

	// Update is called once per frame
	void Update () {
		MovePaddle ();
	}

	void MovePaddle(){
		if (Input.GetKey ((KeyCode.DownArrow))) {
			transform.position += Vector3.down;// * speed;
			//print ("down!");
		} else if (Input.GetKey ((KeyCode.UpArrow))) {
			transform.position += Vector3.up;// * speed;
			//print ("up!");
		}
	}

	void ForPractice(){
		int i = 0;
		while (i < 10) {
			i++;
			print (i);
			//	for (int i = 0; i < 100; i++) {
			//		print (i);
		}
	}
}//}
//}

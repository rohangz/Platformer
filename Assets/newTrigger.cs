using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newTrigger : MonoBehaviour {
	int chk=0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		float distance=100.0f;
		if(chk==0)
		 distance = gameObject.transform.position.x - GameObject.FindGameObjectWithTag ("Player").transform.position.x;
		if(distance<=0.1)
		{
			Debug.Log ("Done it ");
			PlayerPrefs.SetInt ("generate",1);
			Destroy (gameObject);
			chk = 1;
			distance = 100.0f;
		}

	}

}

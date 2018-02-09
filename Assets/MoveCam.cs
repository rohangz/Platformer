using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCam : MonoBehaviour {


	public float speed=0.07f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.A))
		{
			gameObject.transform.Translate (Vector3.left*Time.deltaTime);
		}
		if(Input.GetKey(KeyCode.D))
		{
			gameObject.transform.Translate (Vector3.right*Time.deltaTime);
		}
	}
}

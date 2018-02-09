using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateFloor001 : MonoBehaviour {

	// Use this for initialization
	private int check=0;
	GameObject player;
	void Start () {
		
	}
	void Awake()
	{
		player = GameObject.FindGameObjectWithTag ("Player");
	}
	// Update is called once per frame
	void Update () {
		if (check == 0) {
	//		Debug.Log (gameObject.transform.GetChild (0).position);	
		//	Debug.Log ("local position ");
		//	Debug.Log (gameObject.transform.GetChild (0).localPosition);
			float d1 = gameObject.transform.GetChild (0).localPosition.x;
			float distance = d1 + gameObject.transform.position.x - player.transform.position.x;
			if (distance <= 0.1) {
				GameObject obj = GameObject.Instantiate (gameObject,new Vector3(transform.position.x+15.0f, gameObject.transform.position.y, gameObject.transform.position.z),gameObject.transform.rotation)as GameObject;
				check = 1;
			}
		}
		if (check == 1)
			Destroy (gameObject, 5);
		
	}
}

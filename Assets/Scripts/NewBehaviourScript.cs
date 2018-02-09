using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	public GameObject cam;
	public GameObject front;
	public GameObject mid;
	public GameObject end;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		cam.transform.Translate (Vector3.right*10*Time.deltaTime);
		front.transform.Translate (Vector2.right*10*Time.deltaTime);
		mid.transform.Translate (Vector2.right*9*Time.deltaTime);
		end.transform.Translate (Vector2.right*8*Time.deltaTime);
	
	}



}

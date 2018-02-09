using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class MoveImageForScrolling : MonoBehaviour {
	public float speed = 5.0f;
	// Use this for initialization
	private void Awake()
	{
	}
	void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.Translate (Vector3.left*speed*Time.deltaTime);
	}
}

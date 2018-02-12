using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class MoveImageForScrolling : MonoBehaviour {
	public float speed = 5.0f;
	private float increaseSpeedTime=5.0f;
	// Use this for initialization
	private void Awake()
	{
	}
	void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update () {
		if (increaseSpeedTime >= 0)
			increaseSpeedTime -= Time.deltaTime;
		else {
			increaseSpeedTime = 60.0f;
			speed = speed + 1.0f;
		}
		gameObject.transform.Translate (Vector3.left*speed*Time.deltaTime);
	}
}

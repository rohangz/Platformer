using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
	private GameObject target;
	public Vector3 offset;
	public float smoothSpeed=0.125f;
	// Use this for initialization
	void Start () {
			
		target = GameObject.FindGameObjectWithTag ("Player");

	}
	
	// Update is called once per frame
	void FixedUpdate () {


		if (target != null)
		{
			Vector3 desiredPosition = target.transform.position + offset;
			Vector3 smoothedPosiion = Vector3.Lerp (transform.position, desiredPosition, smoothSpeed);
			transform.position = smoothedPosiion;
			transform.LookAt (target.transform);
		}
	}

}

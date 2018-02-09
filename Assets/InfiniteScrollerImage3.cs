using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiniteScrollerImage3 : MonoBehaviour {
	public Transform[] objects;
	private int start;
	private int end;
	private Transform cam;
	public float paraSpeed;
	private float camOldX;
	// Use this for initialization
	void Awake()
	{
		start = 0;
		end = objects.Length - 1;

	}
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		

	
	
	}
}


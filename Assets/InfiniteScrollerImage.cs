using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiniteScrollerImage : MonoBehaviour {
	private Transform[] objects;
	private int start;
	private int end;
	private Transform cam;
	public float paraSpeed;
	private float camOldX;

	void Awake()
	{
	
		objects=new Transform[gameObject.transform.childCount];
		for (int i = 0; i < gameObject.transform.childCount; i++)
			objects [i] = gameObject.transform.GetChild (i);
		start = 0;
		end= objects.Length - 1;
	/*	for (int i = 0; i < gameObject.transform.childCount; i++) {
			//Debug.Log (gameObject.transform.GetChild(i).transform.localPosition);
		}*/
		cam = Camera.main.transform;

		camOldX = cam.transform.position.x;
	
	
	}



	private void ScrollLeft()
	{
		Debug.Log("ScrollLeft");
		Transform toUpdate = objects [end];
		int i = start;
		int j = (i + 1)%objects.Length;
		Debug.Log (objects [i].transform.position.x);
		Debug.Log (objects [j].transform.position.x);
		float mid = 2.0f * objects [i].transform.position.x - objects [j].transform.position.x;
		Debug.Log (mid);
		toUpdate.transform.position = new Vector3 (mid,toUpdate.transform.position.y,toUpdate.transform.position.z);
		start--;
		end--;
		if (start < 0)
			start = objects.Length - 1;
		if (end < 0)
			end = objects.Length - 1;



	}
	private void ScrollRight()
	{
		Debug.Log("ScrollRight");
		Transform toUpdate = objects [start];
		int i = end;
		int j = end - 1;
		if (j < 0)
			j = objects.Length - 1;
		float mid = 2.0f * objects [i].transform.position.x - objects [j].transform.position.x;
		toUpdate.transform.position = new Vector3 (mid,transform.position.y,toUpdate.transform.position.z);
		start=(start+1)%objects.Length;
		end = (end + 1) % objects.Length;

	}

	// Use this for initialization
	void Start () {
		
	}
	private float abs(float a,float b)
	{
		float c = a - b;
		if (c < 0)
			c = c * (-1.0f);
		return c;
			
	}
		
	// Update is called once per frame
	void Update () {



	//	ScrollLeft ();
	float xs=cam.transform.position.x-objects[start].transform.position.x;
	float xe = objects [end].transform.position.x - cam.transform.position.x;
		if (xs >= 0 && xs <= 15.0f)
			ScrollLeft ();
		
		else if (xe >= 0 && xe <= 15.0f)

			ScrollRight ();


		float deltaX = (cam.transform.position.x - camOldX)*paraSpeed;
			gameObject.transform.position+=Vector3.right*(deltaX);
				


	/*	if(Input.GetKey(KeyCode.A))
		{
			ScrollLeft ();
		}
		if(Input.GetKey(KeyCode.D))
		{
			ScrollRight ();
		}
		*/
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax001 : MonoBehaviour {

	private float viewZone;
	private Transform cam;
	private Transform[] layers;
	private int lower;	
	private int upper;


	public Transform[] images;
	public float[] parascales;
	private Vector3 camOldX;

	void Awake()
	{
		parascales=new float[images.Length];
		for (int i = 0; i < images.Length; i++) 
			parascales[i]=images[i].transform.position.z*(-1);
	}

	private void Start()
	{
		cam = Camera.main.transform;
		camOldX = cam.transform.position;


	}
	private void Update()
	{
		for (int i = 0; i < images.Length; i++)
		{
			
			float para = (camOldX.x - cam.position.x) * parascales [i];
			float taget = images [i].position.x + para;
			Vector3 newPos = new Vector3 (taget,images[i].position.y,images[i].position.z);
			images [i].position = Vector3.Lerp (images[i].position,newPos,Time.deltaTime);
		}
		camOldX = cam.position;
	}
	private void ScrollLeft()
	{
		int left = lower;



	}
	private void ScrollRight()
	{
	}
}

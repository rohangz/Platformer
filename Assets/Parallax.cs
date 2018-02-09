using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour {


	public float backgroundSize;
	public float parlaxSpeed=2.0f;

	private float lastCameraX;

	private Transform cameraTransform;
	private Transform[] layers;
	private float viewZone=10;
	private int leftIndex;
	private int rightIndex;

	private void Start()
	{
		cameraTransform = Camera.main.transform;
		layers=new Transform[transform.childCount];
		for (int i = 0; i < transform.childCount; i++)
			layers [i] = transform.GetChild (i);
		leftIndex = 0;
		rightIndex = layers.Length - 1;
		lastCameraX = cameraTransform.position.x;
	}
	private void ScrollLeft()
	{

		int lastRight = rightIndex;
		layers[rightIndex].position=Vector3.right*(layers[leftIndex].position.x-backgroundSize);
		leftIndex = rightIndex;
		rightIndex--;
		if (rightIndex < 0)
			rightIndex = layers.Length - 1;
	}
	private void ScrollRight()
	{

		int lastLeft = leftIndex;
		layers[leftIndex].position=Vector3.right*(layers[rightIndex].position.x+backgroundSize);
		rightIndex = leftIndex;
		leftIndex++;
		if (leftIndex == layers.Length)
			leftIndex = 0;
	}
	void Update()
	{
		float delta = cameraTransform.position.x - lastCameraX;
		transform.position+=Vector3.right*(delta*parlaxSpeed);
		if(cameraTransform.position.x<(layers[leftIndex].transform.position.x+viewZone))
		{
			ScrollLeft ();
		}
		if(cameraTransform.position.x>(layers[rightIndex].transform.position.x-viewZone))
		{
			ScrollRight ();
		}
	}

}

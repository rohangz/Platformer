using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour {
	private GameObject player;
	public GameObject[] obstacles;

	// Use this for initialization
	float t=2.0f;
	void Start () {
		
	}
	void Awake()
	{
		player = GameObject.FindGameObjectWithTag ("Player");
	}
	// Update is called once per frame
	void Update () {
		if (t >= 0)	
		{
			t -= Time.deltaTime;
		} 
		else 
		{
			t = 2.0f;
			GameObject obj = Instantiate (obstacles[Random.RandomRange(0,obstacles.Length)],new Vector3(player.transform.position.x+5,-12.5f,player.transform.position.z),player.transform.rotation)as GameObject;
			Destroy (obj, 10);
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generateFloor : MonoBehaviour {
	// Use this for initialization
	public GameObject floor;
	void Start () {
		
	}
	void Awake()
	{
		PlayerPrefs.SetInt ("generate",0);
	}
	
	// Update is called once per frame
	void Update () {
		if(PlayerPrefs.GetInt("generate")==1)
		{
			Debug.Log ("mil gaya ");
			PlayerPrefs.SetInt ("generate",0);
			GameObject obj = GameObject.Instantiate (floor,new Vector3(gameObject.transform.position.x*(-1),gameObject.transform.position.y,11.11356f),gameObject.transform.rotation)as GameObject;
			Debug.Log (obj.transform.position+"fkladjsflkjsdfkljf");
			Destroy (gameObject, 5);

		}
	}
}

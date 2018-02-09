using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	// Use this for initialization
	private Rigidbody2D rb;
	private GameObject cam;
	float speed=2.0f;
	float jump=5.0f;
	private Vector3 pos;
	private bool isGrounded = true;
	private Animator anim;




	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
		anim.SetBool ("isGrounded",true);
	
	}


	void Update()
	{
		
	}
	// Update is called once per frame
	void FixedUpdate () {
		
		if (anim.GetBool ("isDead") == false) 
		{
			rb.velocity = new Vector2 (10.0f, rb.velocity.y);
			if (Input.GetKeyDown (KeyCode.Space) && isGrounded == true) {
				rb.velocity = new Vector2 (rb.velocity.x, jump);
				isGrounded = false;
				anim.SetBool ("isGrounded", false);
			}

		}


		

	}
	protected void OnCollisionEnter2D(Collision2D col)
	{
		//Debug.Log (col.gameObject.name);
		if(col.gameObject.tag=="Respawn")
		{
			Debug.Log ("grounded ");
			isGrounded = true;
			anim.SetBool ("isGrounded",true);

		}
		if(col.gameObject.tag=="Death")
		{
			Debug.Log ("player died working");
			anim.SetBool ("isDead",true);
			Destroy (gameObject,0.7f);
		}

	}
}

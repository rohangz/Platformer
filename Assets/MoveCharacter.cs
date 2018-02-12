using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour {

	private bool isGrounded = true;
	private Animator anim;
	public float jumpVelocity;
	private Transform gameObjectTransform;



	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		gameObjectTransform = gameObject.transform;
	}
	
	// Update is called once per frame
	void Update () {


		if(Input.GetKeyDown(KeyCode.Space) && isGrounded==true)
		{
			gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector2 (gameObject.GetComponent<Rigidbody2D>().velocity.x,jumpVelocity);
			isGrounded = false;
			anim.SetBool ("isJumping",true);
		}
		if (Input.GetKeyDown (KeyCode.D)) {
			anim.SetBool ("isExploding", true);
			Destroy (gameObject, 0.5f);
		}
		if (Input.GetKeyDown (KeyCode.F)) {
			anim.SetBool ("isDead",true);

		
		}
		if (Input.GetKey (KeyCode.C)) {
			anim.SetBool ("isCrouching", true);
	//		gameObject.transform.position = new Vector3 (gameObject.transform.position.x, gameObject.transform.position.y - 0.7f, gameObject.transform.position.z);

		} else {
			anim.SetBool ("isCrouching", false);
//			gameObject.transform.position.y = gameObjectTransform.position.y;
	//		gameObject.transform.position=new Vector3(gameObject.transform.position.x,gameObjectTransform.position.y,gameObject.transform.position.z);
		}
	
		
	}
	private void OnCollisionEnter2D(Collision2D col)
	{
		Debug.Log (col.collider.gameObject.tag);
		if(col.collider.gameObject.tag=="Floor")
		{
			isGrounded = true;
			anim.SetBool ("isJumping",false);
		}
	}
}

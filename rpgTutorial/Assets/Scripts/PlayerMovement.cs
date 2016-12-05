using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	Rigidbody2D rBody;
	Animator anim;

	// Use this for initialization
	void Start () {

		rBody = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {
	
		Vector2 movementVector = new Vector2 (Input.GetAxisRaw ("Horizontal"), Input.GetAxisRaw ("Vertical"));

		if (movementVector != Vector2.zero)
		{
			anim.SetBool ("IsWalking", true);
			anim.SetFloat ("Input_X", movementVector.x);
			anim.SetFloat ("Input_Y", movementVector.y);
		} 

		else
		{
			anim.SetBool ("IsWalking", false);	
		}

		rBody.MovePosition (rBody.position + movementVector * Time.deltaTime);
			
	}
}

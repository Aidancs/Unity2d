using UnityEngine;
using System.Collections;

public class Warp : MonoBehaviour {

	public Transform warp_target;

	void OnTriggerEnter2D(Collider2D other){

		Debug.Log ("an object collided");

		other.gameObject.transform.position = warp_target.position;
		Camera.main.transform.position = warp_target.position;
	}

}

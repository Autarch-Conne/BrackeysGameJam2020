using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
	GameObject Player;

	void Start () 
	{
		Player = gameObject.transform.parent.gameObject;
	}

	void Update () 
	{

	}

	OnCollisionEnter3D(Collision3D collsion) 
	{
		if (collision.collider.tag = "Ground") {
			Player.GetComponent<PlayerMovement>().isGrounded = true;
		}
	}

	OnCollisionExit3D(Collision3D collision) 
	{
		if (collision.collider.tag = "Ground") {
			Player.GetComponent<PlayerMovement>().isGrounded = false;
		}
	}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
	public bool isGrounded;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
void GroundChecker()
{
	RaycastHit hit;
	float distance = 1f;
	Vector3 dir = new Vector3(0, -1);

	if(Physics.Raycast(transform.position, dir, out hit, distance))
	{
		isGrounded = true;
	}
	else
	{
		isGrounded = false;
	}
}}

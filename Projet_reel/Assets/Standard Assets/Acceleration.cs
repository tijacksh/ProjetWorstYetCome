using UnityEngine;
using System.Collections;

public class Acceleration : MonoBehaviour 
{
	// Update is called once per frame
	void Update () 
	{
		if (transform.position.y > 1)
			rigidbody.AddForce(Vector3.down * 45);
	}
}

using UnityEngine;
using System.Collections;

public class StopMomentum : MonoBehaviour
{
	// Update is called once per frame
	void OnTriggerEnter(Collider other) 
    {
		if (Input.GetKeyDown(KeyCode.S))
		{
        	rigidbody.velocity = Vector3.zero;
			rigidbody.angularVelocity = Vector3.zero;
		}
	}
}

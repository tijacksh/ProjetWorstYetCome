using UnityEngine;
using System.Collections;

public class StopMomentum : MonoBehaviour
{
	// Update is called once per frame
	void OnTriggerEnter(Collision other) 
    {
        rigidbody.velocity = Vector3.zero;
	}
}

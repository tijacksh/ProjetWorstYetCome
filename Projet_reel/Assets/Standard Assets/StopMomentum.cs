using UnityEngine;
using System.Collections;

public class StopMomentum : MonoBehaviour
{
	public float changeSpeed;

	// Update is called once per frame
	void FixedUpdate()
	{
		float speed = 1;
		changeSpeed = 0.2f;
			speed -= Time.deltaTime * 0.98f;
			rigidbody.velocity = rigidbody.velocity * speed;
	}
}

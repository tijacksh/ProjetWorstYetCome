using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ResetBall : MonoBehaviour {
	//651 0.15 844

	private Vector3 initialPos;
	private Quaternion originalRotation;
	Rigidbody body;

	Text instruction;

	// Use this for initialization
	void Start () 
	{
		initialPos = transform.position;
		originalRotation = transform.rotation;

		body = new Rigidbody ();
		instruction = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		if (body.position.x == 570f)
						isScored ();
	}

	void isScored()
	{
		transform.position = initialPos;
		transform.rotation = originalRotation;
		
		rigidbody.velocity = Vector3.zero;
		rigidbody.angularVelocity = Vector3.zero;

		instruction.text = "YOU SCORED !!!";
	}
}

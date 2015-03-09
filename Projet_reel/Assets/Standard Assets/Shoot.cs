using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Shoot : MonoBehaviour
{
	Text text;

	public static int Team1Score, Team2Score;

	private Vector3 initialPos;
    private Quaternion originalRotation;

	void Awake()
    {
        initialPos = transform.position;
        originalRotation = transform.rotation;
		
		text = GetComponent <Text> ();
		Team1Score = 0;
		Team2Score = 0;
    }

	Vector3 dir;

    void Update()
	{
		change ();

		rigidbody.transform.LookAt(Camera.current.transform);

		RaycastHit hit;

		float dist = 4F;



		Vector3 fwd = transform.TransformDirection (Vector3.forward);

		if (Physics.Raycast(transform.position, fwd, out hit))
		{
			dist = hit.distance;

			if (Input.GetKey(KeyCode.C) && dist <= 1f && dist > -1f)
			{
				rigidbody.AddForce(-transform.forward * 5000);
			}

			else if (Input.GetKey(KeyCode.E) && dist <= 1f && dist > -1f)
			{
				rigidbody.AddForce (-transform.forward * 1500);
				rigidbody.AddForce (transform.up * 1000);
			}
		}

        if (Input.GetKey(KeyCode.G))
		{
			transform.position = initialPos;
			transform.rotation = originalRotation;
			
			rigidbody.velocity = Vector3.zero;
			rigidbody.angularVelocity = Vector3.zero;
		}
		
		if (Input.GetKeyDown(KeyCode.S))
		{
			rigidbody.velocity = Vector3.zero;
			rigidbody.angularVelocity = Vector3.zero;
		}

		if (rigidbody.position.x < -84.4)
		{
			Team2Score++;
			reset ();
		}			

		if (rigidbody.position.x > 67.3f)
		{
			Team1Score++;
			reset ();
		}
		
		text.text = Team1Score + "       -      " + Team2Score;
	}

	void change()
	{
		if (Input.GetKeyDown (KeyCode.T))
			Application.LoadLevel ("voivlavoila");
	}

	void reset()
	{
		transform.position = initialPos;
		transform.rotation = originalRotation;
		
		rigidbody.velocity = Vector3.zero;
		rigidbody.angularVelocity = Vector3.zero;
	}
}

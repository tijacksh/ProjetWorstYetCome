using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour
{/*

    CharacterController thePlayer;
    Transform ParentPart = null;    //An empty object which is parented in front of the player
    float PickUpDistance = 2.4f;
    bool canPickUp = false;
    bool parented = false;
    float dist;

    void Start()
    {
        thePlayer = GetComponent<CharacterController>();
        dist = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        //is the player near enough to the football to pick it up?
        dist = Vector3.Distance(thePlayer.transform.position, transform.position);
        if (dist <= PickUpDistance) { canPickUp = true; } else { canPickUp = false; }

        //take the ball (parent it to the empty objekt which is parented to the player)
        if (Input.GetButtonDown("Fire2") && canPickUp)
        {
            transform.parent = ParentPart;
            parented = true;
        }

        //Shoot
        if (Input.GetButtonDown("Fire1") && Input.GetKey(KeyCode.C) && parented)
        {
            parented = false;
            transform.parent = null;
            transform.rigidbody.constraints = RigidbodyConstraints.None;

            transform.rigidbody.AddForce(thePlayer.velocity + thePlayer.transform.forward * 100);
        }

        //set the balls position to the position of the empty
        if (parented)
        {
            transform.position = ParentPart.position;
            transform.rigidbody.constraints = RigidbodyConstraints.FreezeAll;
        }
    }
    */


	private Vector3 initialPos;
    private Quaternion originalRotation;

    void Start()
    {
        initialPos = transform.position;
        originalRotation = transform.rotation;
    }

    CharacterController player;
	Vector3 dir;

    void Update()
    {
		//dir = rigidbody.transform.position - transform.position;
		//dir = dir.normalized;
		
		/*if (Input.GetKeyDown (KeyCode.C)) 
		{
			float dist = 4F;
			RaycastHit hit;
			Vector3 fwd = transform.TransformDirection(Vector3.forward);

			if (Physics.Raycast(transform.position, fwd, out hit))
				dist = hit.distance;

			if (dist <= 1f && dist > -1f)
				print("There is something in front of the object!");
			else
				print("xxx");
		}*/

		//Vector3 fwd = transform.TransformDirection(Vector3.forward);
		//RaycastHit hit;

		//Vector3 forceDirection = Camera.current.transform.forward;
		//forceDirection = new Vector3( forceDirection.x, 0, forceDirection.y );
		/*
		if (Physics.Raycast (transform.position, fwd, out hit))
	 	{
			if (Input.GetKey (KeyCode.C))
				rigidbody.AddRelativeForce( forceDirection.normalized * 100 );
		}*/
		rigidbody.transform.LookAt(Camera.current.transform);

		if (Input.GetKey(KeyCode.C))
			rigidbody.AddForce(-transform.forward * 500);
		
		if (Input.GetKey(KeyCode.R))
            rigidbody.AddForce(-transform.forward * 100);

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
	}
}

using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour 
{/*

    CharacterController thePlayer;
    Transform ParentPart = null;    //An empty object which is parented in front of the player
    float PickUpDistance = 2.4f;
    bool canPickUp = false;
    bool parented = false;
    float dist = 0f;

    void Start()
    {
        thePlayer = GetComponent<CharacterController>();
    }

	// Update is called once per frame
	void Update () 
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

    void OnCollisionEnter(Collider collide)
    {
        if (collide.gameObject.name == "Sphere")
        {
            Reset();
        }
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
            rigidbody.AddForce(Vector3.left * 1000);

        if (Input.GetKeyDown(KeyCode.R))
            rigidbody.AddForce(Vector3.right * 1000);

        if (Input.GetKeyDown(KeyCode.G))
            Reset();
    }

    void Reset()
    {
        transform.position = initialPos;
        transform.rotation = originalRotation;

        rigidbody.velocity = Vector3.zero;
        rigidbody.angularVelocity = Vector3.zero;
    }
}

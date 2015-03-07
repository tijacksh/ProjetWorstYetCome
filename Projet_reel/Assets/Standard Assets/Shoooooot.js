#pragma strict

 var thePlayer : CharacterController = GetComponent(CharacterController);
 var ParentPart : Transform;    //An empty object which is parented in front of the player
 var PickUpDistance : float = 2.4;
 var canPickUp : boolean = false;
 var parented : boolean = false;
 var dist : float = 0;
 
 function Update () 
 {
     //is the player near enough to the football to pick it up?
     dist = Vector3.Distance(thePlayer.transform.position, transform.position);
     if (dist <= PickUpDistance) {canPickUp = true;} else { canPickUp = false; }
 
     //take the ball (parent it to the empty objekt which is parented to the player)
     if(Input.GetButtonDown("Fire2") && canPickUp) 
      {
          transform.parent = ParentPart;
          parented = true;
     }
             
     //Shoot
     if(Input.GetButtonDown("Fire1") && Input.GetKey(KeyCode.C) && parented)
      {
         parented = false;
         transform.parent = null;
         transform.rigidbody.constraints = RigidbodyConstraints.None;
         
          transform.rigidbody.AddForce (thePlayer.velocity + thePlayer.transform.forward*100);
     }
 
     //set the balls position to the position of the empty
     if(parented) 
     { 
         transform.position = ParentPart.position;
         transform.rigidbody.constraints = RigidbodyConstraints.FreezeAll;
     }
 }
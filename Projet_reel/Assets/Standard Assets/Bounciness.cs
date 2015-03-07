using UnityEngine;
using System.Collections;

public class Bounciness : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		PhysicMaterial pm = new PhysicMaterial();
		pm.bounciness = 0.8f;
	}
}
